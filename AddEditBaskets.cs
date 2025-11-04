//using Business_Layer;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace PharmacyDesktop
//{
//    public partial class AddEditBaskets : Form
//    {


//        public enum enMode
//        {
//            AddNew = 1, Update = 1
//        }
//        private enMode _Mode;
//        int _BasketsID;
//        string Caption;
//        public AddEditBaskets()
//        {
//            InitializeComponent();
//        }

//        private void panel1_Paint(object sender, PaintEventArgs e)
//        {

//        }



         

//        Bask _Product;
//        Countries Country_ID;
//        public AddEdit(int ProductID)
//        {
//            InitializeComponent();

//            label7.Text = Caption;
//            _ProductID = ProductID;
//            if (_ProductID == -1)

//                _Mode = enMode.AddNew;
//            else
//                _Mode = enMode.Update;
//        }



//        private void _FillCountriesInComboBox()
//        {
//            DataView DV = Countries.GetAllProductsByUseDataView();
//            foreach (DataRowView rowView in DV)
//            {
//                cbxCountries.Items.Add(rowView["CountryName"]);
//            }
//        }

//        protected void _LoadData()
//        {
//            _FillCountriesInComboBox();
//            cbxCountries.SelectedIndex = 0;

//            if (_Mode == enMode.AddNew)
//            {
//                label7.Text = "Add New Product";
//                _Product = new cls_AddProduct();
//                return;
//            }
//            _Product = cls_AddProduct.Find(_ProductID);


//            if (_Product == null)
//            {
//                MessageBox.Show($"This form will be closed because No products with {_ProductID} found!");
//                this.Close();
//                return;
//            }



//            label7.Text = "Edit Product ID = " + _ProductID;
//            lblProductID.Text = _ProductID.ToString();
//            MskName.Text = _Product.Name;
//            MSKDV_Category.Text = _Product.Category;
//            DateProducts.Value = _Product.ExpiryDate;
//            Suppliers.Text = _Product.Supplier_ID.ToString();

//            if (_Product.ImagePath != "")
//            {
//                pictureBox1.Load(_Product.ImagePath);
//            }

//            lbl_Remove.Visible = (_Product.ImagePath != "");


//            cbxCountries.SelectedIndex = cbxCountries.FindString(Countries.Find(Country_ID.Countries_ID)._CountryName);
//        }

//        private void AddEdit_Load(object sender, EventArgs e)
//        {
//            _LoadData();
//        }

//        private void btn_Save_Click(object sender, EventArgs e)
//        {
//            int CountryID = Countries.Find(cbxCountries.Text).Countries_ID;


//            _Product.Name = MskName.Text;
//            _Product.Category = MSKDV_Category.Text;
//            _Product.ExpiryDate = DateProducts.Value;
//            _Product.Supplier_ID = int.Parse(Suppliers.Text);
//            _Product.ImagePath = Image.Text; ;
//            //_Batch.Product_ID = 
//            if (_Product.ImagePath != null)
//            {
//                _Product.ImagePath = pictureBox1.ImageLocation;

//            }
//            else
//            {
//                _Product.ImagePath = null;
//            }
//            if (_Product.Save())
//            {
//                MessageBox.Show("Data Saved Successfully.", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);

//            }
//            else
//            {
//                MessageBox.Show("Error: Data Is Not Saved Successfully." + cls_AddProduct.ShowErrors(), "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);

//            }
//            _Mode = enMode.Update;
//            Caption = "Edit Product ID = " + _Product.Product_ID;
//            lblProductID.Text = _Product.Product_ID.ToString();
//        }

//    }
//}
