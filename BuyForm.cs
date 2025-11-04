using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna;
using System.Windows.Forms;

namespace PharmacyDesktop
{
    public partial class BuyForm : Form
    {
        public BuyForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { }

        private void button2_Click(object sender, EventArgs e)

        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            cls_Buy buy = new cls_Buy();

            //  buy.Price = 100m;
          //  Calculation.Value = buy.Price.Value;
         //  buy.UserBalance = 220m;
            if (buy.Buy(Price.Value, UserBalance.Value))
            {
                MessageBox.Show($"Your balance is not enough! ");
                return;
            }
            else
                MessageBox.Show("Your balance is enough");

            bool result = buy.Buy(Price.Value,0);

            if (result)
            {
                MessageBox.Show($"Purchase successful!\nCurrent user balance: {UserBalance.Value:C}\nFinal Price: {buy.FinalAmount:C}\nRemaining Balance: {UserBalance.Value - buy.FinalAmount:C}", "Confirm", MessageBoxButtons.OK);
                btn_ContinueToBuy.Visible = true;
            }
            else
            {
                MessageBox.Show("Insufficient balance.", "Error", MessageBoxButtons.OK);
            }
        }
    

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            cls_Buy buy = new cls_Buy();
            MessageBox.Show($"Your FRMProducts Average = {buy.ProductsAverage().ToString()}");

        }
       
        private void BuyForm_Load(object sender, EventArgs e)
        {
            btn_ContinueToBuy.Visible = false;
            this.BackgroundImage = Image.FromFile(@"C:\Users\ahmed\Downloads\shopping.png");
           
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UserBalance.Minimum = 0;
            UserBalance.Maximum = 1000;
            UserBalance.Increment = 2;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Price_ValueChanged(object sender, EventArgs e)
        {
            Price.Minimum = 0;
            Price.Maximum = 1000;
            Price.Increment = 2;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            //frm_Shippingmethod frmShipping = new frm_Shippingmethod();
            //frmShipping.Show();
        }

        private void deliveryUserCtrl1_Load(object sender, EventArgs e)
        {

        }
    }
}
