using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Frmrapor : Form
    {
        public Frmrapor()
        {
            InitializeComponent();
        }

        private void Frmrapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personeldataDataSet.PersonelTablo' table. You can move, or remove it, as needed.
            this.personelTabloTableAdapter.Fill(this.personeldataDataSet.PersonelTablo);


            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
