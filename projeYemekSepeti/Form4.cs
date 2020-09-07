using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace _16253013projeYemekSepeti
{
    public partial class Form4 : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;

        public Form4()
        {
            InitializeComponent();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //con = new OleDbConnection("Data Source=LAPTOP-VB4BVHDI\\SQLEXPRESS;Initial Catalog=ozpauyemeksepeti;Integrated Security=True");
            //cmd = new OleDbCommand();
            //con.Open();
            //cmd.Connection = con;
            //cmd.CommandText = "SELECT * FROM restaurantlar";
            //dr = cmd.ExecuteReader();

            //while (dr.Read())
            //{

            //        listBox1.Items.Add(dr["adı"]);




            //}
            //con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection("Data Source=LAPTOP-VB4BVHDI\\SQLEXPRESS;Initial Catalog=ozpauyemeksepeti;Integrated Security=True");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM restaurantlar";
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                listBox1.Items.Add(dr["adı"]);




            }
            con.Close();
        }
    }
}
