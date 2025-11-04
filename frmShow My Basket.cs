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
    public partial class frmShow_My_Basket : Form
    {
        public frmShow_My_Basket()
        {
            InitializeComponent();
        }
        private void _RefreshAllPaymentsData()
        {
            DGVShowMyOrders.DataSource = cls_Buy.GetAllPayments();
        }
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmShow_My_Basket_Load(object sender, EventArgs e)
        {
            DGVShowMyOrders.ReadOnly = true;
            _RefreshAllPaymentsData();
        }

        private void btn_HideData_Click(object sender, EventArgs e)
        {
            DGVShowMyOrders.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DGVShowMyOrders.Show();
        }
    }
}
