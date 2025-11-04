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
    public partial class clsShowMyInformation : Form
    {
        public clsShowMyInformation()
        {
            InitializeComponent();

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("UserName", "UserName");
            dataGridView1.Columns.Add("Password", "Password");




            //List<string> info = clsFile.Read();
            //foreach (var item in info)
            //{

            //    string[] parts = item.Split(',');
            //    if (parts.Length == 2)
            //        dataGridView1.Rows.Add(parts[0], parts[1]);
            //}
        }
        static void ReadFile()
        {
           
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }

        private void Form3_Load(object sender, EventArgs e)
        { 
        }
    }
}
