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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        
        SqlConnection baglantı = new SqlConnection("Data Source=Efe;Initial Catalog=Personeldata;Integrated Security=True");

        private void Form3_Load(object sender, EventArgs e)
        {
            baglantı.Open();

            SqlCommand g1 = new SqlCommand("select PerSehir, count(*) from PersonelTablo group by PerSehir",baglantı);
            SqlDataReader komut1 = g1.ExecuteReader();
            while (komut1.Read())
            {

                chart1.Series["Sehirler"].Points.AddXY(komut1[0], komut1[1]);

            }
            baglantı.Close();

            baglantı.Open();

            SqlCommand g2 = new SqlCommand("select Permeslek, avg(Permaas) from PersonelTablo group by Permeslek",baglantı);
            SqlDataReader komut2= g2.ExecuteReader();
            while (komut2.Read())
            {

                chart2.Series["Meslek-Maas"].Points.AddXY(komut2[0], komut2[1]);

            }
            baglantı.Close();


        }
    }
}
