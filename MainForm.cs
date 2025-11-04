using Business_Layer;
using DoseMate;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Business_Layer.Baskets;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace PharmacyDesktop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
      
        //private enum enUpdateOrDeleteMode
        //{
        //    UpdateMode = 0, DeleteMode = 1
        //}
         //_ShowAllBatchesRecords
        private int _ReadValue(int ID)
        {
            // = ID;
          //  numericUpDown1.Value = ID;
           
            String Input = "Please enter an ID to delete it..";
            MessageBox.Show(Input);

            return ID;
        }
        
        
        
        public int F;

        public  void _ShowAllProducts()
        {
            frmShowaRecords frmShowInventoryRecords = new frmShowaRecords();
            frmShowInventoryRecords.ShowAllProducts();
            frmShowInventoryRecords.ShowDialog();
        }
       
        protected  void _ShowAllSupplierss()
        {
            frmShowaRecords frmShowInventoryRecords = new frmShowaRecords();
            frmShowInventoryRecords._ShowAllSuppliers();
            frmShowInventoryRecords.ShowDialog();
        }
        private void testAnyValueIsNull()
        {
            var DV = cls_AddToInventories.AnyValueIsNull();



            for (int i = 0; i < DV.Count; i++)
            {
              MessageBox.Show("Product_ID {0} \t null",
               DV[i][0].ToString());
            }
            //  MessageBox.Show(cls_AddToInventories.AnyValueIsNull().ToString());
        }
        
        public bool _UpdateProducts(int ID)
        {

            cls_AddProduct  UpdateProduct = cls_AddProduct.Find(ID);
            if (UpdateProduct != null)
            {
                UpdateProduct.Name = "Lal";
                UpdateProduct.Category  = "Perfume";
                UpdateProduct.ExpiryDate = new DateTime(2027, 02, 02, 0, 0, 0);
                UpdateProduct.Supplier_ID = 24;
                UpdateProduct.ImagePath = null;
                if (UpdateProduct.Save())
                {
                     MessageBox.Show("Done updated successfully.");
                    return true;
                }
                else
                {
                    MessageBox.Show("Failed added." + cls_AddToInventories.ShowErrors());
                }
            }
            else
            {

                MessageBox.Show("Failed added because the object is null!.");
               
            }
            return false;
        }
        public void _DeleteRecordProducts(int ID)
        {
            cls_AddProduct Record = new cls_AddProduct();

            if (Record.IsProductExist(ID))
            {
                cls_AddProduct.DeleteProductByID(ID);
                MessageBox.Show("Done Deleted Successfully.");

            }
            else
                MessageBox.Show("The record " + ID + "'s not found");

        }

         
        private string  ReadSupplierName(string SupplierName)
        {
           
            return maskedTextBox1.Text.Trim();
        }
        private string ReadSupplieContactInfo(string ContactInfo)
        {
            //MessageBox.Show("Please enter a Supplier Contact info.", "Confirm".ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return maskedTextBox2.Text.Trim();
        }


        private string ReadSupplieAddress(string Address)
        {
            //MessageBox.Show("Please enter a Supplier Address.", "Confirm".ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return maskedTextBox3.Text.Trim();
        }
        private void _UpdateSuppliers(int ID)
        {

            clsSuppliers UpdateSupplier = clsSuppliers.Find(ID);
            if (UpdateSupplier != null)
            {
                UpdateSupplier.Name = "YTY";
                UpdateSupplier.ContactInfo = "9090";
                UpdateSupplier.Address = "Ryiadh";
                if (UpdateSupplier.SaveModes())
                {
                    MessageBox.Show("Done updated successfully.");
                }
                else
                {
                    MessageBox.Show("Failed updated." + clsSuppliers.GetLastError());
                }
            }
            else
            {

                MessageBox.Show("Failed added because the object is null!.");
            }
        }
      

        //private void _DeleteRecordFromBatches(int ID)
        //{

        //    if (clsBatches.IsExists(ID))
        //    {
        //        clsBatches.DeleteBatchByID(ID);
        //        MessageBox.Show("Done Deleted Successfully.");

        //    }
        //    else
        //        MessageBox.Show("The record " + ID + "'s not found");

        //}

        private void _DeleteRecordFromSupplierss(int ID)
        {
            clsSuppliers DeleteSupplier = new clsSuppliers();
           /* ID =  1*/;/* _ReadValue((int)numericUpDown1.Value);*/
           // _ShowAllSupplierss();
            //if (clsSuppliers.IsSupplierExist(ID))
            //{
             
                if(DeleteSupplier.DeleteNullValues())
                MessageBox.Show("Done Deleted Successfully." );
            //return true;
            //}
            else
                MessageBox.Show("The record " + ID + "'s not found" + clsSuppliers.GetLastError());
            ///return false;
        }

        private enum _Index
        {
            ShowAllProducts = 0, ShowAllSuppliers = 1
        }
        _Index Choice;

        private void _AddToBasket()
        {

            Baskets AddToBasket = new Baskets();
            AddToBasket.ProductID = 19;
           

            if (AddToBasket.Save())
            {
                MessageBox.Show("Done added successfully.");
                MessageBox.Show("Please wait...");
                SmallPrWaiting frmShowInventoryRecords = new SmallPrWaiting();
                frmShowInventoryRecords.ShowDialog();
            }
            else
            {
                MessageBox.Show("Failed added." + cls_AddToInventories.ShowErrors());
            }
        }


        private void _AddSupplier()
        {

            clsSuppliers AddSupplier = new clsSuppliers();
           AddSupplier.Name = ReadSupplierName(maskedTextBox1.Text);

            MessageBox.Show($"Your Name Is {maskedTextBox1.Text.ToUpper()}");
             
            AddSupplier.ContactInfo = ReadSupplieContactInfo(maskedTextBox2.Text);
            AddSupplier.Address = ReadSupplieAddress(maskedTextBox3.Text);


            if (AddSupplier.SaveModes())
            {
                MessageBox.Show("Done added successfully.");
                MessageBox.Show("Please wait...");
                SmallPrWaiting frmShowInventoryRecords = new SmallPrWaiting();
                frmShowInventoryRecords.ShowDialog();
            }
            else
            {
                MessageBox.Show("Failed added." + cls_AddToInventories.ShowErrors());
            }
        }
        public enum enMode
        {
            AddNew = 1, Update = 1
        }
      
         public MainForm(int ProductID)
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
        }

        private void DVG1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    






        private void MainForm_Load(object sender, EventArgs e)
        {
            //if (cbs_ShowMenu.Items.Count == 0)
            Pnl_Supplers.Show();

            //_LoadData();
            //Products.BackgroundImage = Properties.Resources.drugstore;
            //Products.BackgroundImageLayout = ImageLayout.None;
            //tabPage2.BackgroundImage = Properties.Resources.drugstore;
            //tabPage2.BackgroundImageLayout = ImageLayout.None;
            //TB_Inventory.BackgroundImage = Properties.Resources.inventory;
            //TB_Inventory.BackgroundImageLayout = ImageLayout.None;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void cbxCountries_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         }

        private void button2_Click(object sender, EventArgs e)
        {
         }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            testAnyValueIsNull();
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
           
        }

        private void button17_Click(object sender, EventArgs e)
        {
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            
        }

        private void button20_Click(object sender, EventArgs e)
        {
            
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            _AddToBasket();
        }

        private void tabPage12_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            _AddSupplier();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            _ShowAllSupplierss();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            MyProducts Show = new MyProducts(-1);
            Show.Show();



        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton6.Checked)
            {
                FRM_AddaProduct MoveToFRM_AddaProduct = new FRM_AddaProduct();
                MoveToFRM_AddaProduct.Show();
            }
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
             
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Products_Click(object sender, EventArgs e)
        {

        }

        private void Rd_SuppliersBtn_CheckedChanged(object sender, EventArgs e)
        {
            //if(Rd_SuppliersBtn.Checked)
            //{
            //    Pnl_Supplers.Visible = true;
               
            //    //frmclsSuppliers Show = new frmclsSuppliers();
            //    //Show.ShowDialog();
            //}
        }

        private void button22_Click(object sender, EventArgs e)
        {
        }

        private void cbs_ShowMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

            frmShowaRecords ShowForm = new frmShowaRecords();
           Choice =  (_Index)cbs_ShowMenu.SelectedIndex;
            if (cbs_ShowMenu.Items.Count == 0)
            {
                MessageBox.Show($"Please select an option from the menu first!");
                return;
            }
            switch (Choice)
            {
                case _Index.ShowAllProducts:

                    cbs_ShowMenu.SelectedIndex = 0;

              
                    ShowForm.ShowAllProducts();
                    
                    break;

                case  _Index.ShowAllSuppliers:
                    cbs_ShowMenu.SelectedIndex = 1;

                    ShowForm._ShowAllSuppliers();
                 
                    break;

            }
            ShowForm.Show();

        }

        private void RD_Inventories_CheckedChanged(object sender, EventArgs e)
        {
            if(RD_Inventories.Checked)
            {
                FRM_Inventories Move_ToInventories = new FRM_Inventories();
                Move_ToInventories.ShowDialog();
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pnl_Inventories_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {
             
        }

        private void button24_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button26_Click(object sender, EventArgs e)
        {
           
        }

        private void button27_Click(object sender, EventArgs e)
        {
            _DeleteRecordFromSupplierss((int)Nmer_Filter.Value);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
            //numericUpDown1.Value= _ReadValue((int)numericUpDown1.Value);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            _UpdateSuppliers((int)Nmer_Filter.Value);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            if(RD_Batches.Checked)
            {
                BatchesForm MoveToBatches = new BatchesForm();
                MoveToBatches.ShowDialog();
            }
        }

        private void PNL_Suppliers_Click(object sender, EventArgs e)
        {
           
         }

        private void button5_Click_1(object sender, EventArgs e)
        {
            //panel1.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void rd_Invoices_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_Invoices.Checked)
            {
                Invoices MoveToInvoices = new Invoices();
                MoveToInvoices.ShowDialog();

            }
        }

        private void guna2CirclePictureBox7_Click(object sender, EventArgs e)
        {

        }



        void NoneMode(int ID)
        {
            clsSuppliers supplier = new clsSuppliers();
            //supplier = supplier._SetNoneMode();

            //MessageBox.Show(supplier.None);


            supplier = new clsSuppliers();

            ID = (int)Nmer_Filter.Value;
              
                supplier.Name = "";
                supplier.ContactInfo = "";
                supplier.Address = "";
                if (supplier.SaveModes())
                {
                    MessageBox.Show($"Done updated Successfully.");
                    //   MessageBox.Show(Choice1.ShowNone());
                    MessageBox.Show("The record " + Nmer_Filter.Value + "'s not found");

                }
            }



            



        /// <summary>
        /// ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExecute_Click(object sender, EventArgs e)
        {
            button10.Enabled = false;
            button27.Enabled = false;
            button28.Enabled = false;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
          //  MessageBox.Show("You finished typing: " + maskedTextBox1.Text);
        }

        private void maskedTextBox1_DragLeave(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
       
            if (string.IsNullOrWhiteSpace(maskedTextBox1.Text))
            {
                MessageBox.Show("Please enter supplier name before continuing!");
                maskedTextBox1.Focus(); 
            }
            else
            {
                MessageBox.Show($"You entered: {maskedTextBox1.Text}");
            }
        }

        private void maskedTextBox2_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(maskedTextBox2.Text))
            {
                MessageBox.Show("Please enter a contoct info of supplier before continuing!");
                maskedTextBox2.Focus();
            }
            else
            {
                MessageBox.Show($"You entered: {maskedTextBox2.Text}");
            }
        }

        private void maskedTextBox3_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(maskedTextBox3.Text))
            {
                MessageBox.Show("Please enter a supplier address before continuing!");
                maskedTextBox3.Focus();
            }
            else
            {
                MessageBox.Show($"You entered: {maskedTextBox3.Text}");
            }
        }

        private void Pnl_Supplers_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
             
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (RD_Countries.Checked)
            {
                Countriesfrm MoveToCountries = new Countriesfrm();
                MoveToCountries.ShowDialog();
            }
        }

        private void RD_Ctrls_CheckedChanged(object sender, EventArgs e)
        {
            if (RD_Ctrls.Checked)
            {
                CtrlsFrm Move_ToCtrls = new CtrlsFrm();
                Move_ToCtrls.ShowDialog();
            }
        }

        private void BtnEmployees_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnEmployees.Checked)
            {
                frmEmployees MoveToEmployees = new frmEmployees();
                MoveToEmployees.ShowDialog();
            }
        }

        private void Rd_Prescriptions_CheckedChanged(object sender, EventArgs e)
        {
            if (Rd_Prescriptions.Checked)
            {
                frmPrescriptions MoveTofrmPrescriptions = new frmPrescriptions();
                MoveTofrmPrescriptions.ShowDialog();
            }
        }

        private void RD_Purchase_CheckedChanged(object sender, EventArgs e)
        {
            if (RD_Purchase.Checked)
            {
                frmPurchase MoveTofrmPurchase = new frmPurchase();
                MoveTofrmPurchase.ShowDialog();
            }
        }

        private void Rd_PurchaseDetails_CheckedChanged(object sender, EventArgs e)
        {
            if (Rd_PurchaseDetails.Checked)
            {
                PurchaseDetails MoveToPurchaseDetails = new PurchaseDetails();
                MoveToPurchaseDetails.ShowDialog();
            }
        }
    }
}

