namespace PharmacyDesktop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_ResetInfo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LUserName = new System.Windows.Forms.Label();
            this.MSPassword = new System.Windows.Forms.MaskedTextBox();
            this.MS_UserName = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.Lock_Counter = new System.Windows.Forms.Timer(this.components);
            this.Lbl_Attention = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.btn_ResetInfo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.LUserName);
            this.panel1.Controls.Add(this.MSPassword);
            this.panel1.Controls.Add(this.MS_UserName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Login);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 870);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(348, 560);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(94, 20);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // btn_ResetInfo
            // 
            this.btn_ResetInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ResetInfo.Location = new System.Drawing.Point(84, 599);
            this.btn_ResetInfo.Name = "btn_ResetInfo";
            this.btn_ResetInfo.Size = new System.Drawing.Size(445, 68);
            this.btn_ResetInfo.TabIndex = 2;
            this.btn_ResetInfo.Text = "ShowNone info";
            this.btn_ResetInfo.UseVisualStyleBackColor = true;
            this.btn_ResetInfo.Click += new System.EventHandler(this.btn_ResetInfo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password";
            // 
            // LUserName
            // 
            this.LUserName.AutoSize = true;
            this.LUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUserName.Location = new System.Drawing.Point(46, 96);
            this.LUserName.Name = "LUserName";
            this.LUserName.Size = new System.Drawing.Size(97, 20);
            this.LUserName.TabIndex = 9;
            this.LUserName.Text = "UserName";
            // 
            // MSPassword
            // 
            this.MSPassword.Location = new System.Drawing.Point(40, 209);
            this.MSPassword.Name = "MSPassword";
            this.MSPassword.Size = new System.Drawing.Size(186, 27);
            this.MSPassword.TabIndex = 8;
            // 
            // MS_UserName
            // 
            this.MS_UserName.Location = new System.Drawing.Point(40, 128);
            this.MS_UserName.Name = "MS_UserName";
            this.MS_UserName.Size = new System.Drawing.Size(186, 27);
            this.MS_UserName.TabIndex = 7;
            this.MS_UserName.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MS_UserName_MaskInputRejected);
            this.MS_UserName.Validating += new System.ComponentModel.CancelEventHandler(this.MS_UserName_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 689);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "You don\'t have an account?";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(84, 742);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(445, 61);
            this.button3.TabIndex = 5;
            this.button3.Text = "Create a new account";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 555);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Forgot your password?";
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(185, 351);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(303, 65);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PharmacyDesktop.Properties.Resources.monitor;
            this.pictureBox1.Location = new System.Drawing.Point(26, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(695, 493);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Lock_Counter
            // 
            this.Lock_Counter.Enabled = true;
            this.Lock_Counter.Interval = 1000;
            this.Lock_Counter.Tick += new System.EventHandler(this.Lock_Counter_Tick);
            // 
            // Lbl_Attention
            // 
            this.Lbl_Attention.AutoSize = true;
            this.Lbl_Attention.BackColor = System.Drawing.Color.Red;
            this.Lbl_Attention.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Attention.Location = new System.Drawing.Point(965, 220);
            this.Lbl_Attention.Name = "Lbl_Attention";
            this.Lbl_Attention.Size = new System.Drawing.Size(42, 25);
            this.Lbl_Attention.TabIndex = 2;
            this.Lbl_Attention.Text = "     ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PharmacyDesktop.Properties.Resources.photo_2025_10_14_23_47_51;
            this.ClientSize = new System.Drawing.Size(1781, 883);
            this.Controls.Add(this.Lbl_Attention);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "frm_Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MaskedTextBox MS_UserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LUserName;
        private System.Windows.Forms.MaskedTextBox MSPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btn_ResetInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Timer Lock_Counter;
        private System.Windows.Forms.Label Lbl_Attention;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

