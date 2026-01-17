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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=Efe;Initial Catalog=Personeldata;Integrated Security=True");

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            baglantı.Open();

            SqlCommand z1 =new SqlCommand("select count (*) from PersonelTablo",baglantı);
            SqlDataReader komut=z1.ExecuteReader();
            while (komut.Read())
            {
                lbltoplamp.Text = komut[0].ToString();
            }
            baglantı.Close();

            baglantı.Open();
            SqlCommand z2 = new SqlCommand("select count(*) from PersonelTablo where Perdurum=1",baglantı);
            SqlDataReader komut2=z2.ExecuteReader();
            while (komut2.Read()) 
            { 
            
                Lblevli.Text= komut2[0].ToString();
            
            }
            baglantı.Close();

            baglantı.Open();

            SqlCommand z3 = new SqlCommand("select count(*) from PersonelTablo where Perdurum=0",baglantı);
            SqlDataReader komut3= z3.ExecuteReader();
            while (komut3.Read()) 
            { 
            
                lblbekar.Text=komut3[0].ToString();
            
            }

            baglantı.Close();

            baglantı.Open();

            SqlCommand z4 = new SqlCommand("select sum(Permaas) from PersonelTablo ",baglantı);
            SqlDataReader komut4=z4.ExecuteReader();
            while (komut4.Read()) 
            { 
            
            lblmaas.Text=komut4[0].ToString();

            }

            baglantı.Close();
            
            baglantı.Open();

            SqlCommand z5 = new SqlCommand("select avg(Permaas) from PersonelTablo",baglantı);
            SqlDataReader komut5=z5.ExecuteReader();
            while (komut5.Read()) 
            {
            
             lblavg.Text=komut5[0].ToString();            
            
            }

            baglantı.Close();

            baglantı.Open();

            SqlCommand z6 = new SqlCommand("select count(distinct(Persehir)) from PersonelTablo",baglantı);
            SqlDataReader komut6=z6.ExecuteReader();
            while (komut6.Read())
            {

                lblsehir.Text=komut6[0].ToString();

            }

            baglantı.Close();

        }
    }
}
