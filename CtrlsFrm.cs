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
    public partial class CtrlsFrm : Form
    {
        public CtrlsFrm()
        {
            InitializeComponent();
        }

        private int ReadInput()
        {
            MessageBox.Show($"Please enter Invoice Key","Caption", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
           return (int) Nmer_Filter.Value;
        }
        private void AddController()
        {
            clsControlls AddCtrls = new clsControlls();
            AddCtrls.Invoice_Key = ReadInput();

            MessageBox.Show($"Your Name Is {maskedTextBox1.Text.ToUpper()}");

            AddCtrls.ActionType = "Payment";

            AddCtrls.ActionDate = new DateTime();
            AddCtrls.Description = "None";

            if (AddCtrls.Save())
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
        private void CtrlsFrm_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            AddController();
        }

        private void maskedTextBox3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maskedTextBox3.Text))
            {
                MessageBox.Show("Please enter value before continuing!");
                maskedTextBox3.Focus();
            }
            else
            {
                MessageBox.Show($"You entered: {maskedTextBox3.Text}");
            }
        }
    }
}
