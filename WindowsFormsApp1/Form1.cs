using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection("Data Source=Efe;Initial Catalog=Personeldata;Integrated Security=True");
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            this.personelTabloTableAdapter.Fill(this.personeldataDataSet.PersonelTablo);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.personelTabloTableAdapter.Fill(this.personeldataDataSet.PersonelTablo);


        }

        private void button1_Click(object sender, EventArgs e)
        {
          baglantı.Open();
          SqlCommand n1 = new SqlCommand("insert into PersonelTablo (Perad,Persoyad,Persehir,Permaas,Perdurum,Permeslek) values (@p1,@p2,@p3,@p4,@p5,@p6)",baglantı);
            n1.Parameters.AddWithValue("@p1", txtperad.Text);
            n1.Parameters.AddWithValue("@p2", txtpersoy.Text);
            n1.Parameters.AddWithValue("@p3", cmbxsehir.Text);
            n1.Parameters.AddWithValue("@p4", mskdmaas.Text);
            if (radioButton1.Checked)
            {
                label7.Text = "True";
            }
            else { label7.Text = "False"; }
            n1.Parameters.AddWithValue("@p5", label7.Text);
            n1.Parameters.AddWithValue("@p6",txtmeslek.Text);
            n1.ExecuteNonQuery();
            MessageBox.Show("Personel Eklendi!");
          baglantı.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglantı.Open();

            SqlCommand k1 = new SqlCommand("delete from PersonelTablo where Perid=@k1",baglantı);
            k1.Parameters.AddWithValue("@k1",textBox1.Text);
            k1.ExecuteNonQuery();
            MessageBox.Show("Personel Kaydı Silindi!");
            baglantı.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            txtperad.Text = "";
            txtpersoy.Text = "";
            txtmeslek.Text = "";
            cmbxsehir.Text = "";
            mskdmaas.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtperad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtpersoy.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbxsehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskdmaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label7.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            if (label7.Text == "True") { radioButton1.Checked=true; }
            else { radioButton2.Checked=true; }
            txtmeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void la(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglantı.Open();

            SqlCommand u1 = new SqlCommand("Update PersonelTablo set Perad=@u1,Persoyad=@u2,Persehir=@u3,Permaas=@u4,Perdurum=@u5,Permeslek=@u6 where Perid=@u7",baglantı);
            u1.Parameters.AddWithValue("@u1", txtperad.Text);
            u1.Parameters.AddWithValue("@u2", txtpersoy.Text);
            u1.Parameters.AddWithValue("@u3", cmbxsehir.Text);
            u1.Parameters.AddWithValue("@u4", mskdmaas.Text);
            if (radioButton1.Checked)
            {
                label7.Text = "True";
            }
            else { label7.Text = "False"; }
            u1.Parameters.AddWithValue("@u5", label7.Text);
            u1.Parameters.AddWithValue("@u6", txtmeslek.Text);
            u1.Parameters.AddWithValue("@u7", textBox1.Text);
            u1.ExecuteNonQuery();
            MessageBox.Show("Kayıt Güncellendi!");
            baglantı.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
Frmrapor frm5 = new Frmrapor();
            frm5.Show();
        }
    }
}
