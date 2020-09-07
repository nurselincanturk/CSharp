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
    public partial class asdf : System.Web.UI.Page
    {

        SqlConnection sqlCon = new SqlConnection(@"Data Source=LAPTOP-VB4BVHDI\SQLEXPRESS;Initial Catalog=WebProje;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

         
            


        }



        

        protected void btnSave_Click(object sender, EventArgs e)
        {
            gvProduct.Visible = true ;

            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            SqlDataAdapter sqlDa = new SqlDataAdapter("urunsiparisBilgisip", sqlCon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            sqlCon.Close();
            gvProduct.DataSource = dtbl;
            gvProduct.DataBind();
            GridView1.Visible = false;
            GridView2.Visible = false;

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            GridView1.Visible = true;
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            SqlDataAdapter sqlDa = new SqlDataAdapter("SiParisStokSorgulama", sqlCon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            sqlCon.Close();
           GridView1.DataSource = dtbl;
            GridView1.DataBind();
            gvProduct.Visible = false;
            GridView2.Visible = false;


        }

        protected void btnfiyat(object sender, EventArgs e)
        {
            
            GridView2.Visible = true;
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM fiyatlarArtan", sqlCon);
            sqlDa.SelectCommand.CommandType = CommandType.TableDirect;
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            sqlCon.Close();
            GridView2.DataSource = dtbl;
            GridView2.DataBind();
            gvProduct.Visible = false;
            GridView1.Visible = false;

        }
    }
}