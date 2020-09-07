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
    public partial class Form3 : Form
    {
        string baglanti;
        public Form3()
        {
            InitializeComponent();
            
            baglanti = "Data Source=LAPTOP-VB4BVHDI\\SQLEXPRESS;Initial Catalog=ozpauyemeksepeti;Integrated Security=True";

        }

        private void textsifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textsoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 db = new Class1(baglanti);
            string musteriEkle = "Insert into musteribilgi Values('" + textad.Text + "', '" + textsoyad.Text + "','" + texteposta.Text + "', '" + textsifre.Text + "','" + comboBox1.Text + "', '" + textilceev.Text + "','" + textevadres.Text + "', '" + comboBox2.Text + "','" + textisilce.Text + "', '" + textisadres.Text + "')";
            MessageBox.Show(musteriEkle);
            int res = db.RunCommand(musteriEkle);
            if (res >= 0)
            {
                MessageBox.Show("Müşteri Başarı ile eklendi");
                
            }
            else
                MessageBox.Show("Müşteri Eklemede bir hata oluştu");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form4 restaurant = new Form4();
            restaurant.Show();
            this.Hide();


        }

        private void label9_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
