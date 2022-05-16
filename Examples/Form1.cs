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


namespace Examples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 ac = new Form2();
            this.Hide();
            ac.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataReader dr;
            string kullaniciadi = textBox1.Text;
            string sifre = textBox2.Text;
            SqlConnection connect = new SqlConnection("Data Source=DESKTOP-OSIBJH7\\SQLEXPRESS;Initial Catalog=user;Integrated Security=True");
            SqlCommand com = new SqlCommand();
            connect.Open();
            com.Connection = connect;
            com.CommandText = "select * from users where kullaniciadi='" + textBox1.Text + "' and sifre='" + textBox2.Text + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Basarili giris");
            }
            else
            {
                MessageBox.Show("Kullanici adi veya sifre yanlis");
            }
            connect.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
 
