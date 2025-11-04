using Business_Layer;
using System;
using System.Drawing;
using System.Windows.Forms;
using static Business_Layer.clsFile;

namespace PharmacyDesktop
{
    public partial class Form1 : Form

    {
       

        private const int MAX_LOGIN_ATTEMPTS = 3;
        int _LoginAttemps = 0;
        bool _IsAccountLocked = false;
        int LockedDuration = 30;
        int _CurrentLockedTime = 0;
       

        private int _ReadPermissions()
        {
            clsFile V = new clsFile();
           
            int Permissions = 0;
             DialogResult result = MessageBox.Show("Do you want to set supplier permissions?",
                                                  "Permissions Setup",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                return -1;



            //DialogResult result = MessageBox.Show("Allow 'Show Supplier' permission?", "Permission", MessageBoxButtons.YesNo);
            //if (result == DialogResult.Yes)
            //    permissions |= (int)en_ModePermissions._ShowAllSuppliers;


            result = MessageBox.Show("Allow 'Show Supplier' permission?", "Permission", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Permissions = (int)en_ModePermissions._ShowAllSuppliers;

            result = MessageBox.Show("Allow 'Add New Supplier' permission?", "Permission", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Permissions = (int)en_ModePermissions._AddNewSupplier;

            result = MessageBox.Show("Allow 'Update Supplier' permission?", "Permission", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Permissions += Convert.ToInt32(en_ModePermissions._UpdateSuppliers);

            result = MessageBox.Show("Allow 'Delete Supplier' permission?", "Permission", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Permissions += Convert.ToInt32(en_ModePermissions._DeleteSuppliers);

            result = MessageBox.Show("Allow 'Find Supplier' permission?", "Permission", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Permissions += Convert.ToInt32(en_ModePermissions._FindSuppliers);


             
            return Permissions;
        }

        
        public Form1()
        {
            InitializeComponent();
            InitilizeTimerComponent();


        }

 
            private void InitilizeTimerComponent()
        {
            Lock_Counter.Interval = 1000;
            Lock_Counter.Stop();
            UpdateUI();
        }
        //public clsFile  ReadNewUser()
        //{
        //    clsFile File = new clsFile();
        //    DialogResult result = MessageBox.Show("Enter UserName",
        //                                        "Confirm",
        //                                        MessageBoxButtons.YesNo,
        //                                        MessageBoxIcon.Question);


        //    clsFile N = new clsFile();
        //    if (N.UserExistsByUserName(File.UserName, File.Password))
        //    {
        //        MessageBox.Show("Username or password already exists.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        //return;
        //    }
        //    else
        //    {
        //        MessageBox.Show("Username or password does not exist.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }



        //     _Permissions = _ReadPermissions();

        //    MessageBox.Show($"User permissions code: {this._Permissions}");

        //    return File;
        //}
        //public void AddNewUser()
        //{
        //    clsFile File = new clsFile();
        //    File = ReadNewUser();

        //    File.UserName = "Rami";
        //    File.Password = "p12345";
        //    if(File.Save())
        //    {
        //        MessageBox.Show("Done added successfully.");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Failed added.");
        //    }
        //}

        private void AccountLocked()
        {
            _IsAccountLocked = true;

            _CurrentLockedTime = 0;
            Lock_Counter.Start();
            btn_Login.Enabled = false;
            UpdateUI();
        }
        private void MoveToProductsForm()
        {
            MainForm productsForm = new MainForm(-1);
           // this.Hide();
            productsForm.ShowDialog();
         //   this.Show();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Information;
            notifyIcon1.BalloonTipText = "Dear customer, a verification code has been sent to your phone number.\n";
            notifyIcon1.BalloonTipTitle = "System Message";
            notifyIcon1.ShowBalloonTip(3000);
        }

           private void btnLogin_Click(object sender, EventArgs e)
        {
            clsFile N = new clsFile();

             if (string.IsNullOrWhiteSpace(MS_UserName.Text))
            {
                MessageBox.Show("Please enter your username.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MS_UserName.Focus();
                return;
            }

             if (string.IsNullOrWhiteSpace(MSPassword.Text))
            {
                MessageBox.Show("Please enter your password.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MSPassword.Focus();
                return;
            }

             if (N.LoginSystem(MS_UserName.Text, MSPassword.Text))
            {
                MessageBox.Show("Successfful login.", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Lofin failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
 
        }



            //else
            //{
            //    // Login failed
            //    _LoginAttemps++;

            //    if (_LoginAttemps >= MAX_LOGIN_ATTEMPTS)
            //    {
            //        AccountLocked();
            //    }
            //    else
            //    {
            //        MessageBox.Show($"Invalid username or password. Attempts remaining: {MAX_LOGIN_ATTEMPTS - _LoginAttemps}",
            //                      "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }

            //    UpdateUI();
            //}
        

        private void UpdateUI()
        {
            if (_IsAccountLocked)
            {
                btn_Login.Enabled = false;
                Lbl_Attention.Text = $"Account locked. Time remaining: {LockedDuration - _CurrentLockedTime} seconds";
                Lbl_Attention.ForeColor = Color.Red;
            }
            else
            {
                btn_Login.Enabled = true;
                Lbl_Attention.Text = $"Login attempts: {_LoginAttemps}/{MAX_LOGIN_ATTEMPTS}";
                Lbl_Attention.ForeColor = Color.Black;
            }
        }


        private void ResetLoginSecurity()
        {
            _LoginAttemps = 0;

            _IsAccountLocked = false;

            _CurrentLockedTime = 0;

            Lock_Counter.Stop();

            btn_Login.Enabled = true;
            UpdateUI();
        }
        private void Lock_Counter_Tick(object sender, EventArgs e)
        {
            _CurrentLockedTime++;

            if (_CurrentLockedTime >= LockedDuration)
            {
                Lock_Counter.Stop();
                ResetLoginSecurity();
                MessageBox.Show("Account unlocked. You can try logging in again.",
                              "Account Unlocked", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                UpdateUI();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void MS_UserName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            errorProvider1.SetError(MS_UserName, "Required!");
            
        }

        private void MS_UserName_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
            
        }

        private void btn_ResetInfo_Click(object sender, EventArgs e)
        {
            //frm_ResetPInformation RS = new frm_ResetPInformation();
            //RS.ShowDialog();
            clsFile N = new clsFile();
            
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

            clsFile N = new clsFile();

            if (string.IsNullOrWhiteSpace(MS_UserName.Text))
            {
                MessageBox.Show("Please enter your username.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MS_UserName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(MSPassword.Text))
            {
                MessageBox.Show("Please enter your password.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MSPassword.Focus();
                return;
            }

            if (N.LoginSystem(MS_UserName.Text, MSPassword.Text))
            {
                MessageBox.Show("Successfful login.", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //_ReadPermissions();
                //Permissions Show = new Permissions(this);
                //Show.ShowDialog();
                MoveToProductsForm();
                return;
            }
            else
            {
                MessageBox.Show("Lofin failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}






