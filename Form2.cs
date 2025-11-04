using Business_Layer;
using DoseMate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PharmacyDesktop
{
    public partial class Showallproducts : Form
    {
        public Showallproducts()
        {
            InitializeComponent();
        }
        public DataGridView DV
        {
            get
            {
                return dataGridView2;
            }
        }
        private void showProducts1_Load(object sender, EventArgs e)
        {

        }

        private void showProducts1_Load_1(object sender, EventArgs e)
        {

        }

        private void showProducts1_Load_2(object sender, EventArgs e)
        {

        }
        private void _RefreshAllProducts()
        {
           dataGridView2.DataSource = cls_AddProduct.GetAllDataProductsAsDataView();
           dataGridView2.Focus();
        }



        private void SetIndex()
        {

            if (Cbx_Filter.SelectedIndex == 0)
            {

                // comboBox1.SelectedItem = 0;
                dataGridView2.DataSource = cls_AddProduct.GetProduct_IDByDataView();
                // MessageBox.Show($"{Cbx_Filter.SelectedIndex}");
            }
            else
                dataGridView2.DataSource = cls_AddProduct.GetNameProductsAsDataView();
            
        }


        //GetProduct_IDByDataView
        //public void FilterBy_ID(string FilterAllProducts)
        //{

        //    var filteredlist = cls_AddProduct.Filter(FilterAllProducts);
        //    if (String.IsNullOrEmpty(FilterAllProducts))
        //    {
        //        MessageBox.Show("FilterAllProducts By ID is Empty.");
        //    }
        //    if (filteredlist == null || filteredlist.Count == 0)
        //    {
        //        MessageBox.Show("FilterAllProducts is null or zero values!");
        //        return;
        //    }
        //    {
        //        try
        //        {
        //            dataGridView2.DataSource = filteredlist;
        //            dataGridView2.Focus();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show($"Error filtering products: {ex.Message}", "Error",
        //                     MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //}
        //public void FilterAllProducts(string FilterAllProducts)
        //{

        //    var filteredlist = cls_AddProduct.FilterAllProducts(FilterAllProducts);
        //    if (String.IsNullOrEmpty(FilterAllProducts))
        //    {
        //        MessageBox.Show("FilterAllProducts is Empty.");
        //    }
        //    if (filteredlist == null || filteredlist.Count == 0)
        //    {
        //        MessageBox.Show("FilterAllProducts is null or zero values!");
        //        return;
        //    }
        //    {
        //        try
        //        {
        //            dataGridView2.DataSource = filteredlist;
        //            dataGridView2.Focus();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show($"Error filtering products: {ex.Message}", "Error",
        //                     MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //}




        private void Form2_Load(object sender, EventArgs e)
        {
            Caption.Text = "Show all products\n";
            Caption.Font = new Font(Font, FontStyle.Bold);
         
        }

        private void showProducts1_Load_3(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void DVG1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }//FilterAllProducts


        


        

        void FilterByName(string Filter)
        {
            var filteredlist = cls_AddProduct.FilterByName(Filter);
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
                  dataGridView2.DataSource = filteredlist;
                    dataGridView2.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error filtering products: {ex.Message}", "Error",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }



        private void textBox1_TextChanged(object sender, KeyPressEventArgs e)
        {
            //cls_AddProduct.FindByIdAndName(2, "Aspirin_2");

            if (e.KeyChar == (char)Keys.Enter)
            {
                ///    FilterByName(textBox1.Text.Trim());
                e.Handled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //  FilterByName(textBox1.Text.Trim());
                e.Handled = true;
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //FilterAllProducts(textBox1.Text.Trim());
            //if (/*comboBox1.SelectedIndex == 0*/)
            //{

            //    // comboBox1.SelectedItem = 0;
            //    DVG1.DataSource = cls_AddProduct.GetProduct_IDByDataView();
            //}
            //else
            //{
            //    DVG1.DataSource = cls_AddProduct.GetNameProductsAsDataView();
            //    //MessageBox.Show($"Selected Index = {comboBox1.SelectedIndex}");

            //    //MessageBox.Show("No");
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //FilterAllProducts(textBox1.Text.Trim());

        }
        private void ShowAllData()
        {
            _RefreshAllProducts();
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            ShowAllData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userInfo1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
             
        }

        private void userInfo1_Load_1(object sender, EventArgs e)
        {
           
             
        }

        private void userInfo1_Load_2(object sender, EventArgs e)
        {

        }

        private void button1_Click_4(object sender, EventArgs e)
        {

            //FilterAllProducts(guna2TextBox1.Text.Trim());
          //  dataGridView2.DataSource = cls_AddProduct.GetProduct_IDByDataView();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SetIndex();
        }

        private void Caption_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}