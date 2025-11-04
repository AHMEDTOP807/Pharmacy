using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyDesktop
{
    public partial class InventoriesForm : Form
    {
        public InventoriesForm()
        {
            InitializeComponent();
        }

        private void InventoriesForm_Load(object sender, EventArgs e)
        {
            
        }
        private void _AddAcountBankTable()
        {
            Createion.CreateTheAccountBankTable();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cls_AddToInventories Search = new cls_AddToInventories();
            var results = Search.FilterByInventory_Quantity(textBox1.Text);
            if(textBox1.Text == "Quantity='2'")
            {
                MessageBox.Show("The inventory is low");
            }


        }
    }
}
