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

namespace _16253013projeYemekSepeti
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnn = new SqlConnection("Data Source=LAPTOP-VB4BVHDI\\SQLEXPRESS;Initial Catalog=ozpauyemeksepeti;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("select  from musteribilgi where eposta = @eposta and sifre = @sifre", cnn);
                cmd.Parameters.AddWithValue("@eposta", eposta.Text);
                cmd.Parameters.AddWithValue("@sifre", sifre.Text);
                cmd.Connection.Open();
                SqlDataReader rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (rd.HasRows) 
                {
                    while (rd.Read()) 
                    {

                        Form4 kul = new Form4();
                        kul.Show();
                        this.Hide();

                    }
                }
                else 
                {
                    rd.Close();
                    MessageBox.Show("Kullanıcı Adı veya Parola Geçersizdir");
                }
            }
            catch 
            {
                MessageBox.Show("DB ye ulaşılamadı");
            }
        
    }
    }
}
