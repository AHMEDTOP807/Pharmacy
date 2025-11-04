using Business_Layer;
using DoseMate;
using System;
using System.Threading;
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
    public partial class frmShowaRecords : Form
    {
        public frmShowaRecords()
        {
            InitializeComponent();
        }
        public void ShowAllProducts()
        {
            DGV_ShowAllIData.DataSource = cls_AddProduct.GetAllDataProductsAsDataView();
        }


        public void ShowAllBills()
        {
            Bills Invoice = new Bills();
            DGV_ShowAllIData.DataSource = Invoice.GetAllInvoicesDataView();
        }
        public void FilterBy_ID(string Filter)
        {

            var filteredlist = cls_AddProduct.Filter(Filter);
            if (String.IsNullOrEmpty(Filter))
            {
                MessageBox.Show("FilterAllProducts By ID is Empty.");
            }
            if (filteredlist == null || filteredlist.Count == 0)
            {
                MessageBox.Show("FilterAllProducts is null or zero values!");
                return;
            }
            {
                try
                {
                  DGV_ShowAllIData.DataSource = filteredlist;
                    DGV_ShowAllIData.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error filtering products: {ex.Message}", "Error",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void FilterAllProducts(string Filter)
        {

            var filteredlist = cls_AddProduct.Filter(Filter);
            if (String.IsNullOrEmpty(Filter))
            {
                MessageBox.Show("FilterAllProducts is Empty.");
            }
            if (filteredlist == null || filteredlist.Count == 0)
            {
                MessageBox.Show("FilterAllProducts is null or zero values!");
                return;
            }
            {
                try
                {
                    DGV_ShowAllIData.DataSource = filteredlist;
                    DGV_ShowAllIData.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error filtering products: {ex.Message}", "Error",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void FilterAllSuppliers(string Filter)
        {

            var filteredlist = clsSuppliers.Filter(Filter);
            if (String.IsNullOrEmpty(Filter))
            {
                MessageBox.Show("FilterAllProducts is Empty.");
            }
            if (filteredlist == null || filteredlist.Count == 0)
            {
                MessageBox.Show("FilterAllProducts is null or zero values!");
                return;
            }
            {
                try
                {
                    DGV_ShowAllIData.DataSource = filteredlist;
                    DGV_ShowAllIData.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error filtering products: {ex.Message}", "Error",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void _ShowAllInventoryRecords()
        {
            DGV_ShowAllIData.DataSource = cls_AddToInventories.GetGetAllRecordsFromInventoriesByUseDataView();
        }

        public void _ShowAllSuppliers()
        {
            DGV_ShowAllIData.DataSource = clsSuppliers.GetAllSuppliersByDataView();
        }
        public void _ShowAllBatchesRecords()
        {
            DGV_ShowAllIData.DataSource = clsBatches.GetAllBatchesByUseDataView();
        }

        static void SortProductsAsc()
        {
            cls_AddProduct Add = new cls_AddProduct();


           var SortProducts = Add.GetProductsOrderedByIdAsc();


            for (int Counter = 0; Counter < SortProducts.Count; Counter++)
            {
               
                    string Name =
                    SortProducts[Counter][0].ToString();

                MessageBox.Show($"Name = {Name}" );
            }
        }


        public void ShowBasket()
        {
            DGV_ShowAllIData.DataSource = Baskets.GetAllDataBaskets();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MyProducts Frm = new MyProducts((int)DGV_ShowAllIData.CurrentRow.Cells[0].Value);
            //Frm.ShowDialog();

            MainForm MFR = new MainForm();
            MFR._UpdateProducts(8);
            ShowAllProducts();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //_DeleteRecordProducts
            MainForm MFR = new MainForm();
            MFR._DeleteRecordProducts(8);
            ShowAllProducts();
        }

        private void filterByIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TxtFilter.Visible = true;
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Showallproducts Show = new Showallproducts();
            FilterAllProducts(TxtFilter.Text.Trim());
            // FilterAllProducts(guna2TextBox1.Text.Trim());
        }

        private void frmShowaRecords_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Showallproducts Show = new Showallproducts();
            FilterAllSuppliers(TxtFilter.Text.Trim());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SortProductsAsc();
        }
    }
}
