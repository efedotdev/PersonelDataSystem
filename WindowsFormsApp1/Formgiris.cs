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

namespace WindowsFormsApp1
{
    public partial class Formgiris : Form
    {
        public Formgiris()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=Efe;Initial Catalog=Personeldata;Integrated Security=True");

        private void Formgiris_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand z1 = new SqlCommand("select * from tblyonetici where KullanıcıAdı=@p1 and Sifre=@p2 ", baglantı);
            z1.Parameters.AddWithValue("@p1", txtkullanıcı.Text);
            z1.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader komut = z1.ExecuteReader();

            if (komut.Read())
            {
                MessageBox.Show("Hoş Geldiniz!");
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Yanlış şifre veya kullanıcı adı!");
                txtkullanıcı.Text = "";
                txtsifre.Text = "";
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
                baglantı.Close();
        }
    }
}
