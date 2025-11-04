using Business_Layer;
using System;
using System.Drawing;
//using System.Web.UI.WebControls;

//using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace PharmacyDesktop
{



    
    public partial class TEST : Form

    {
        public class SmallCtrl : UserControl
        {
            private  Button MyBTN = new Button();
            private PictureBox BCTX = new PictureBox();
             private Panel MyPanel = new Panel();
            private TextBox Txttest = new TextBox();
          private void InitilizeUserCtrls1()
          {
                MyPanel.BorderStyle = BorderStyle.None;
                MyPanel.BackColor = Color.White;
                MyBTN.ForeColor = Color.Red;
                MyBTN.Text = "Hello";
                MyBTN.Location = new Point(70, 11);
                MyBTN.Click += (s, e) => MessageBox.Show("Button inside UserControl!");
                MyPanel.Controls.Add(MyBTN);
                BCTX.Image = Image.FromFile(@"C:\Users\ahmed\Downloads\home.png");
                BCTX.SizeMode = PictureBoxSizeMode.Zoom;
                MyPanel.Controls.Add(BCTX);


                Txttest.Text = "Txt Hi";
                Txttest.BackColor = Color.Red;
                Txttest.ForeColor = Color.White;
                Txttest.Location = new Point(88, 12);
               

                MyPanel.Controls.Add(Txttest);
                Controls.Add(MyPanel);
                //Controls.Add(MyBTN);

            }
            public SmallCtrl()
            {
                InitilizeUserCtrls1();

               // Controls.Add(MyPanel);
            }
        }
        //    private const int MAX_LOGIN_ATTEMPTS = 3;
        //    int _LoginAttemps = 0;
        //    bool _IsAccountLocked = false;
        //    int LockedDuration = 30;
        //    int _CurrentLockedTime = 0;



        public TEST()
        {
            InitializeComponent();
            InitilizeUserCtrls();


        }
        private void InitilizeUserCtrls()
        {
            SmallCtrl S = new SmallCtrl();
            S.Location = new Point(6, 7);
            S.Size = new Size(800, 450);


            this.Controls.Add(S);
          //  this.Controls.Add(S1);

        }
        private void TEST_Load(object sender, EventArgs e)
        {

        }


        //    }
        //    private void InitilizeTimerComponent()
        //    {
        //        Lock_Counter.Interval = 1000;
        //        Lock_Counter.Stop();
        //        UpdateUI();
        //    }



        //    private void AccountLocked()
        //    {
        //        _IsAccountLocked = true;

        //        _CurrentLockedTime = 0;
        //        Lock_Counter.Start();
        //        btn_Login.Enabled = false;
        //        UpdateUI();
        //    }
        //    private void MoveToProductsForm()
        //    {
        //        FRMProducts productsForm = new FRMProducts();
        //        this.Hide();
        //        productsForm.ShowDialog();
        //        this.Show(); 
        //    }

        //    private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        //    {
        //        notifyIcon1.Icon = SystemIcons.Information;
        //        notifyIcon1.BalloonTipText = "Dear customer, a verification code has been sent to your phone number.\n";
        //        notifyIcon1.BalloonTipTitle = "System Message";
        //        notifyIcon1.ShowBalloonTip(3000);
        //    }

        //    private void btn_Login_Click_1(object sender, EventArgs e)
        //    {
        //        if(_IsAccountLocked)
        //        {
        //            MessageBox.Show("Your account is locked.");
        //            return;
        //        }



        //        if (string.IsNullOrWhiteSpace(MS_UserName.Text) || string.IsNullOrWhiteSpace(MSPassword.Text))
        //        {
        //            MessageBox.Show("Please enter both username and password", "Validation Error",
        //                          MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }
        //        clsFile login = new clsFile();


        //        if (login.LoginSystem(MS_UserName.Text, MSPassword.Text))
        //        {
        //            // Login successful
        //            MessageBox.Show("Login successful", "Success",
        //                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            ResetLoginSecurity();
        //            MoveToProductsForm();
        //        }


        //        else
        //        {
        //            // Login failed
        //            _LoginAttemps++;

        //            if (_LoginAttemps >= MAX_LOGIN_ATTEMPTS)
        //            {
        //                AccountLocked();
        //            }
        //            else
        //            {
        //                MessageBox.Show($"Invalid username or password. Attempts remaining: {MAX_LOGIN_ATTEMPTS - _LoginAttemps}",
        //                              "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            }

        //            UpdateUI();
        //        }
        //    }

        //    private void UpdateUI()
        //    {
        //        if (_IsAccountLocked)
        //        {
        //            btn_Login.Enabled = false;
        //            Lbl_Attention.Text = $"Account locked. Time remaining: {LockedDuration - _CurrentLockedTime } seconds";
        //            Lbl_Attention.ForeColor = Color.Red;
        //        }
        //        else
        //        {
        //            btn_Login.Enabled = true;
        //            Lbl_Attention.Text = $"Login attempts: {_LoginAttemps}/{MAX_LOGIN_ATTEMPTS}";
        //            Lbl_Attention.ForeColor = Color.Black;
        //        }
        //    }


        //    private void ResetLoginSecurity()
        //    {
        //        _LoginAttemps = 0;

        //        _IsAccountLocked = false;

        //        _CurrentLockedTime = 0;

        //        Lock_Counter.Stop();

        //        btn_Login.Enabled = true;
        //        UpdateUI();
        //    }
        //    private void Lock_Counter_Tick(object sender, EventArgs e)
        //    {
        //        _CurrentLockedTime++;

        //        if (_CurrentLockedTime >= LockedDuration)
        //        {
        //            Lock_Counter.Stop();
        //            ResetLoginSecurity();
        //            MessageBox.Show("Account unlocked. You can try logging in again.",
        //                          "Account Unlocked", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        else
        //        {
        //            UpdateUI();
        //        }
        //    }
        //}




    }

}