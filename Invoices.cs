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
    public partial class Invoices : Form
    {
        public Invoices()
        {
            InitializeComponent();
        }
        private  void _ShowAllBills()
        {
            frmShowaRecords frmShowInventoryRecords = new frmShowaRecords();
            frmShowInventoryRecords.ShowAllBills();
            frmShowInventoryRecords.ShowDialog();
        }
        private void Invoices_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            _ShowAllBills();
        }
    }
}
