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
    public partial class Baskestsfrm : Form
    {
        public Baskestsfrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmShow_My_Basket Frm_ShowMyOrders = new frmShow_My_Basket();
            Frm_ShowMyOrders.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmclsSuppliers Suppliers = new frmclsSuppliers();
            Suppliers.ShowDialog();
        }
    }
}
