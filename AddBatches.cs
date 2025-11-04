using Business_Layer;
using DoseMate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyDesktop
{
  
public partial class AddBatches : Form
    {
        public enum enMode
        {
            AddNew = 0 , Update = 1
        }
            private enMode _Mode;
        int BatchID;
        string Caption;

    clsBatches _Batch;
   
        Countries Country_ID;
        public AddBatches(int BatchID)
        { 
             InitializeComponent();

            this.BatchID = BatchID;
            if (BatchID == -1 )

                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;
        }



        private void _FillCountriesInComboBox()
        {
            DataView DV = Countries.GetAllProductsByUseDataView();
            foreach (DataRowView rowView in DV)
            {
                CBcountries.Items.Add(rowView["CountryName"]);
            }
        }

        protected void _LoadData()
        {
            _FillCountriesInComboBox();
            CBcountries.SelectedIndex = 0;

            if (_Mode == enMode.AddNew)
            {
                lCaption.Text = "Add New Batch";
                _Batch = new clsBatches();
                return;
            }
            _Batch = clsBatches.Find(BatchID);


            if (_Batch == null)
            {
                MessageBox.Show($"This form will be closed because No products with {_Batch} found!");
                this.Close();
                return;
            }



            lCaption.Text = "Edit Batch ID = " + _Batch.Batches_ID;
            LblBatchID.Text = _Batch.ToString();
            CountryIDMSK.Text = _Batch.Coutry_ID.ToString();
            ProductIDMSK.Text = _Batch.ProductID.ToString();
           
           

            CBcountries.SelectedIndex = CBcountries.FindString(Countries.Find(Country_ID.Countries_ID)._CountryName);
        }

        private void AddEdit_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click_1(object sender, EventArgs e)
        {
            int CountryID = Countries.Find(CBcountries.Text).Countries_ID;

            //_Batch.Coutry_ID = CountryID;
            _Batch.Coutry_ID = 4;//CountryID ;
            _Batch.ProductID = 12;//int.Parse(ProductIDMSK.Text);
            //_Batch.Product_ID = 

            if (_Batch.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Error: Data Is Not Saved Successfully." + clsBatches.ShowErrors(), "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            _Mode = enMode.Update;
            Caption = "Edit Product ID = " + _Batch.Batches_ID;
            LblBatchID.Text = _Batch.Batches_ID.ToString();
        }

        private void AddBatches_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btn_Close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

