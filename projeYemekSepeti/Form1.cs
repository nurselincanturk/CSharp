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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Form5 uyegiris = new Form5();
            uyegiris.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form3 kaydol = new Form3();
            kaydol.Show();
            this.Hide();

        }
    }
}
