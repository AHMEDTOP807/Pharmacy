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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PharmacyDesktop
{
    public partial class frm_ResetPInformation : Form
    {
        public frm_ResetPInformation()
        {
            InitializeComponent();
        }
        void ResetPass()
        {
            clsFile C = clsFile.Find(NewUser.Text, NewPass.Text);
            
            if (C != null)
            {
               
                MessageBox.Show("The record is here");
                MessageBox.Show("Please enter a new pass");
                C.UserName = NewUser.Text;
                C.Password = NewPass.Text;

                if (C.Save())
                {
                    MessageBox.Show("Done Saved Successfully.");
                }
            }
            else MessageBox.Show("Record is not here!");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            ResetPass();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsShowMyInformation Show = new clsShowMyInformation();
            Show.ShowDialog();
        }

        private void frm_ResetPInformation_Load(object sender, EventArgs e)
        {
            ResetPass();
        }

        private void NewUser_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ResetPass();
        }
    }
}
