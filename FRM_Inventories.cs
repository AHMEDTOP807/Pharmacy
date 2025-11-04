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
    public partial class FRM_Inventories : Form
    {
        public FRM_Inventories()
        {
            InitializeComponent();
        }
        private void _AddToInventory()
        {

            cls_AddToInventories AddToInventoty = new cls_AddToInventories();
            AddToInventoty.Date = new DateTime(2025, 02, 02, 0, 0, 0);
            AddToInventoty.ProductsQuantity = 4;
            AddToInventoty.ExpiryDateForInventories = new DateTime(2026, 02, 02, 0, 0, 0);
            AddToInventoty.LastUpdated = "Updated";
            AddToInventoty.Product_Key = 2;
            if (AddToInventoty.Save())
            {
                MessageBox.Show("Done added successfully.");
            }
            else
            {
                MessageBox.Show("Failed added." + cls_AddToInventories.ShowErrors());
            }
        }

        private void _ShowInventoryRecords()
        {
            frmShowaRecords frmShowInventoryRecords = new frmShowaRecords();
            frmShowInventoryRecords._ShowAllInventoryRecords();
            frmShowInventoryRecords.ShowDialog();
        }


        private void _UpdateInventory(int ID)
        {

            cls_AddToInventories UpdateInventoty = cls_AddToInventories.Find(ID);
            if (UpdateInventoty != null)
            {
                UpdateInventoty.Date = new DateTime(2026, 02, 02, 0, 0, 0);
                UpdateInventoty.ProductsQuantity = 6;
                UpdateInventoty.ExpiryDateForInventories = new DateTime(2027, 02, 02, 0, 0, 0);
                UpdateInventoty.LastUpdated = "Updated";
                UpdateInventoty.Product_Key = 6;
                if (UpdateInventoty.Save())
                {
                    MessageBox.Show("Done updated successfully.");
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
        }
        private void _DeleteRecordFromInventory(int ID)
        {
            cls_AddToInventories Record = new cls_AddToInventories();

            if (cls_AddToInventories.IsExists(ID))
            {
                Record.DeleteRecordFromInventory(ID);
                MessageBox.Show("Done Deleted Successfully.");

            }
            else
                MessageBox.Show("The record " + ID + "'s not found");

        }
        private void FRM_Inventories_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            _AddToInventory();
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            _ShowInventoryRecords();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            _DeleteRecordFromInventory(1);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            _UpdateInventory(5);
        }
    }
}
