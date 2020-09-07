using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace veritabani
{
    public partial class kategori : System.Web.UI.Page
    {     SqlConnection sqlCon = new SqlConnection(@"Data Source=LAPTOP-VB4BVHDI\SQLEXPRESS;Initial Catalog=WebProje;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {
                btnDelete.Enabled = false;
            }
            FillGridView();




        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            SqlCommand sqlCmd = new SqlCommand("addKategori", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            sqlCmd.Parameters.AddWithValue("@idKategori", (kategoriID.Value == "" ? 0 : Convert.ToInt32(kategoriID.Value)));
            sqlCmd.Parameters.AddWithValue("@kategoriAdi", kategoriAditxt.Text.Trim());
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();
            Clear();
            if (kategoriID.Value == "")
            {
                lblSuccessMessage.Text = "Saved succesfully";
            }
            else
            {
                lblSuccessMessage.Text = "Update succesfully";
            }
            FillGridView();



        }
        void FillGridView()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            SqlDataAdapter sqlDa = new SqlDataAdapter("kategoriGoster", sqlCon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            sqlCon.Close();
            gvProduct.DataSource = dtbl;
            gvProduct.DataBind();

        }

        void Clear()
        {
            kategoriID.Value = "";
           kategoriAditxt.Text = "";
            lblSuccessMessage.Text = lblErrorMessage.Text;
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
            lblErrorMessage.Text = lblSuccessMessage.Text = "";
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}