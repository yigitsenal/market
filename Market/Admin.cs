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

namespace Market
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            
        }

        private void kullanıcıekle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=Yigit-Senal;Initial Catalog=dbLogin;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into tblUser (username,password,usertype) values ('" + txtkullanıcıadı.Text + "','" + txtsifre.Text + "','" + comboBox1.Text + "' )", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kasiyer Başarıyla Eklendi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=Yigit-Senal;Initial Catalog=dbLogin;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from tblUser where username='" + txtkullanıcıadı.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kasiyer Başarıyla Silindi");
        }
    }
}

        
  