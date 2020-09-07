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
    public partial class Form2 : Form
    //{
    //    SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-VB4BVHDI\\SQLEXPRESS;Initial Catalog=ozpauyemeksepeti;Integrated Security=True");
        //string baglanti;
        public Form2()
        {

            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    //Class1 db = new Class1(baglanti);
            //    baglanti.Open();
            //    string musterigiris = "select from  musteribilgi where eposta='" + textBox1.Text + "and sifre'" + textBox2.Text + "'";
            //    SqlParameter prmtr1 = new SqlParameter("eposta", textBox1);
            //    SqlParameter prmtr2 = new SqlParameter("sifre", textBox2);
            //    SqlCommand komut = new SqlCommand(musterigiris, baglanti);
            //    komut.Parameters.Add(prmtr1);
            //    komut.Parameters.Add(prmtr2);
            //    DataTable dt = new DataTable();
            //    SqlDataAdapter dat = new SqlDataAdapter(komut);
            //    dat.Fill(dt);
            //    if (dt.Rows.Count>0)
            //    {
            //        Form4 siparis = new Form4();
            //        siparis.Show();
            //        this.Hide();
            //    }
            //}
            //catch (Exception)
            //{

            //    MessageBox.Show("Hatalı giriş yaptınız.");
            //}
            try
            {
                SqlConnection cnn = new SqlConnection("Data Source=LAPTOP-VB4BVHDI\\SQLEXPRESS;Initial Catalog=ozpauyemeksepeti;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("select  from musteribilgi where eposta = @eposta and sifre = @sifre", cnn);
                cmd.Parameters.AddWithValue("@KAdi", txtKAdi.Text);
                cmd.Parameters.AddWithValue("@KParola", txtKParola.Text);
                cmd.Connection.Open();
                SqlDataReader rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (rd.HasRows) // Girilen K.Adı ve K.Parola Dahilinde Gelen Data var ise 
                {
                    while (rd.Read()) // reader Okuyabiliyorsa
                    {
                      
                        
                        
                            // Kullanıcı Rolü 1 dışında ise Kullanıcı Ekranı Aç
                            Form4 kul = new Form4();
                            kul.Show();
                            this.Hide();
                        
                    }
                }
                else /// Reader SATIR döndüremiyorsa K.Adı Parola Yanlış Demekdir
                {
                    rd.Close();
                    MessageBox.Show("Kullanıcı Adı veya Parola Geçersizdir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch // Bağlantı açamayıp Sorgu Çalıştıramıyorsa Veritabanına Ulaşamıyor Demekdir
            {
                MessageBox.Show("DB ye ulaşılamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
    }
}
