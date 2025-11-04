using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyDesktop
{
    public partial class frmclsSuppliers : Form
    {
        public frmclsSuppliers()
        {
            InitializeComponent();
        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmclsSuppliers_Load(object sender, EventArgs e)
        {
            //_RefreshSuppliers();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

            dataGridView1.CurrentRow.Cells[0].Value = 1;
           // _RefreshSuppliers(); 
        
      
        }
    }
}
