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
    public partial class ShowBatchesForm : Form
    {
        public ShowBatchesForm()
        {
            InitializeComponent();
        }
        private void _RefreshAllDataOfBatches()
        {
            DgvBatchesData.DataSource = clsBatches.GetAllBatchesByUseDataView();
        }
        int Ask()
        {
            int A = 1;
            MessageBox.Show("Enter your number...");
            return A;
        }
        private string _Query()
        {
            //int Query = -1;
            //Query = Ask();


            if (textBox1.Text == "-1")
            {
                MessageBox.Show("Your entered.");

            }
            else
            {
                MessageBox.Show("Close!");
            }
            return textBox1.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void ShowBatchesForm_Load(object sender, EventArgs e)
        {
            _RefreshAllDataOfBatches();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            AddBatches AddBatch = new AddBatches(-1);
            AddBatch.ShowDialog();
        }

        private void DgvBatchesData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CEditAndDelete_Opening(object sender, CancelEventArgs e)
        {
            // CEditAndDelete = new ContextMenuStrip();


        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBatches frmclsBatches = new AddBatches((int)DgvBatchesData.CurrentRow.Cells[0].Value);
            frmclsBatches.ShowDialog();
            _RefreshAllDataOfBatches();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show
                ("Are you sure do you want to delete the Batch record?" + DgvBatchesData.CurrentRow.Cells[0].Value.ToString(), "Confirm", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsBatches.IsBatchExist((int)DgvBatchesData.CurrentRow.Cells[0].Value))
                    MessageBox.Show("The batch is exists.");
                    if (clsBatches.DeleteBatchByID((int)DgvBatchesData.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Done deleted successfully.");
                    _RefreshAllDataOfBatches();
                }
                else
                    MessageBox.Show("Failed deleted.");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          //  DgvBatchesData.ClearSelection();
            DgvBatchesData.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // DgvBatchesData.DataSource = null;
            DgvBatchesData.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clsBatches.TruncateBatches();
        }
    }
    }
