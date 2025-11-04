using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyDesktop
{
    public partial class SmallPrWaiting : Form
    {
        public SmallPrWaiting()
        {
            InitializeComponent();
        }

        
        private async void SmallPrWiat_Load(object sender, EventArgs e)
        {
            Pr_Wait.Maximum = 100;
            Pr_Wait.Minimum = 0;
            Pr_Wait.Value = 0;

            for (int count = 1; count <= 10; count++)
            {
                if (Pr_Wait.Value < Pr_Wait.Maximum)
                {
                    await Task.Delay(500); // non-blocking delay
                    Pr_Wait.Value += 10;
                    lblPrWait.Text = $"{((float)Pr_Wait.Value / Pr_Wait.Maximum) * 100}%";
                }

                if (Pr_Wait.Value == Pr_Wait.Maximum)
                {
                    frmShowaRecords show = new frmShowaRecords();
                    show.Show();
                    show._ShowAllSuppliers();
                    //this.Close();
                    //return;
                }
            }
        }

    }

}

            
