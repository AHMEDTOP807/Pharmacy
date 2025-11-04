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
    public partial class FRM_AddaProduct : Form 
    {
        MainForm Mfr = new MainForm();
        frmShowaRecords ShowAllProducts;
        private void AddProducts()
        {
            MyProducts AddProducts = new MyProducts(-1);
            AddProducts.Show();
        }

        private void _UpdateProduct()
        {
            MainForm MFR = new MainForm();
            MFR._UpdateProducts(7);
           // ShowAllProducts.ShowAllProducts();
        }
        private void _ShowAllProducts()
            {
              Mfr._ShowAllProducts();
            }
        
        public FRM_AddaProduct()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            AddProducts();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            _ShowAllProducts();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm MFR = new MainForm();
            MFR._DeleteRecordProducts(2);
          //  ShowAllProducts.ShowAllProducts();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _UpdateProduct();
        }
    }
}
