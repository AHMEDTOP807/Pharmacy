using Business_Layer;
using DoseMate;
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
    public partial class BatchesForm : Form
    {
        public BatchesForm()
        {
            InitializeComponent();
        }
        private void _AddToBatches()
        {

            clsBatches AddToInventoty = new clsBatches();
            AddToInventoty.ProductID = 2;
            AddToInventoty.Coutry_ID = 4;

            if (AddToInventoty.Save())
            {
                MessageBox.Show("Done added successfully.");
            }
            else
            {
                MessageBox.Show("Failed added." + cls_AddToInventories.ShowErrors());
            }
        }


        private void _ShowAllBatchesRecords()
        {
            frmShowaRecords frmShowInventoryRecords = new frmShowaRecords();
            frmShowInventoryRecords._ShowAllBatchesRecords();
            frmShowInventoryRecords.ShowDialog();
        }

        private void _DeleteRecordFromBatches(int ID)
        {

            if (clsBatches.IsExists(ID))
            {
                clsBatches.DeleteBatchByID(ID);
                MessageBox.Show("Done Deleted Successfully.");

            }
            else
                MessageBox.Show("The record " + ID + "'s not found");

        }

        private void _UpdateBatches(int ID)
        {

            clsBatches UpdateInventoty = clsBatches.Find(ID);
            if (UpdateInventoty != null)
            {
                UpdateInventoty.ProductID = 55;
                UpdateInventoty.Coutry_ID = 6;

                if (UpdateInventoty.Save())
                {
                    MessageBox.Show("Done updated successfully.");
                }
                else
                {
                    MessageBox.Show("Failed updated." + cls_AddToInventories.ShowErrors());
                }
            }
            else
            {

                MessageBox.Show("Failed added because the object is null!.");
            }
        }
        private void BatchesForm_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            _AddToBatches();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            _ShowAllBatchesRecords();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            _UpdateBatches(4);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            _DeleteRecordFromBatches(15);
        }
    }
}
