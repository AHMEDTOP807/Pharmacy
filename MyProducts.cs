using Business_Layer;
using Guna.UI2.WinForms;
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
    public partial class MyProducts : Form
    {
     private enum enMode
        {
            AddNew = 0, Update = 1
        }
        private enMode _Mode;
        int _ProductID;
        string Caption;

        cls_AddProduct _Product;
        Countries Country_ID;
        public MyProducts(int ProductID)
        {
            InitializeComponent();

            Caption2.Text = Caption;
            _ProductID = ProductID;
            if (_ProductID == -1)

                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;
        }

        private void _FillCountriesInComboBox()
        {
            DataView DV = Countries.GetAllProductsByUseDataView();
            foreach (DataRowView rowView in DV)
            {
                cbxCountries.Items.Add(rowView["CountryName"]);
            }
        }

        protected void _LoadData()
        {
            _FillCountriesInComboBox();
            cbxCountries.SelectedIndex = 0;

            if (_Mode == enMode.AddNew)
            {
                Caption3.Text = "Add New Product";
                _Product = new cls_AddProduct();
                return;
            }
            _Product = cls_AddProduct.Find(_ProductID);


            if (_Product == null)
            {
                MessageBox.Show($"This form will be closed because No products with {_ProductID} found!");
                this.Close();
                return;
            }



            Caption3.Text = "Edit Product ID = " + _ProductID;
            lbl_ProductID.Text = _ProductID.ToString();
            MskName.Text = _Product.Name;
            MSKDV_Category.Text = _Product.Category;
            DateProducts.Value = _Product.ExpiryDate;
            SupplierID.Text = _Product.Supplier_ID.ToString();

            if (_Product.ImagePath != "")
            {
                pictureBox2.Load(_Product.ImagePath);
            }

            lbl_Remove.Visible = (_Product.ImagePath != "");


            cbxCountries.SelectedIndex = cbxCountries.FindString(Countries.Find(Country_ID.Countries_ID)._CountryName);
        }




        private void MyProducts_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            int CountryID = Countries.Find(cbxCountries.Text).Countries_ID;


            _Product.Name = MskName.Text;
            _Product.Category = MSKDV_Category.Text;
            _Product.ExpiryDate = DateProducts.Value;
            _Product.Supplier_ID = int.Parse(SupplierID.Text);
            _Product.ImagePath = pictureBox2.Text; ;
            //_Batch.Product_ID = 
            if (_Product.ImagePath != null)
            {
                _Product.ImagePath = pictureBox2.ImageLocation;

            }
            else
            {
                _Product.ImagePath = null;
            }
            if (_Product.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Error: Data Is Not Saved Successfully." + cls_AddProduct.ShowErrors(), "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            _Mode = enMode.Update;
            Caption3.Text = "Edit Product ID = " + _Product.Product_ID;
            lbl_ProductID.Text = _Product.Product_ID.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Showallproducts ShowallData = new Showallproducts();
            ShowallData.Show();
           // BTN_FTR.Animated = true;
        }
    }
}
