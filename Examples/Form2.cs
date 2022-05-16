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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection("Data Source=DESKTOP-OSIBJH7\\SQLEXPRESS;Initial Catalog=user;Integrated Security=True");
            if (connect.State == ConnectionState.Closed)
            {
                
                string kayitekle = "insert into users (adi,kullaniciadi,sifre,eposta) values (@adi,@kullaniciadi,@sifre,@eposta)";
                connect.Open();
                SqlCommand com = new SqlCommand(kayitekle, connect);
                com.Parameters.AddWithValue("@adi", textBox1.Text);
                com.Parameters.AddWithValue("@kullaniciadi", textBox2.Text);
                com.Parameters.AddWithValue("@sifre", textBox3.Text);
                com.Parameters.AddWithValue("@eposta", textBox4.Text);
                com.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Basarili");
            }
            else
            {
                MessageBox.Show("HATA OLUSTU");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 ac = new Form1();
            this.Hide();
            ac.Show();
        }
    }
}
  