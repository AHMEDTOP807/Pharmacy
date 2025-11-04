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
    public partial class ShowProducts : UserControl
    {
        public ShowProducts()
        {
            InitializeComponent();
        }
        public void RefreshAllProducts()
        {
            Dgv1.DataSource = cls_AddProduct.GetNameFromProducts();
        }
        private void Show_All_Products_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
