namespace PharmacyDesktop
{
    partial class BuyForm
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
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.Price = new System.Windows.Forms.NumericUpDown();
            this.UserBalance = new System.Windows.Forms.NumericUpDown();
            this.btn_ContinueToBuy = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.guna2Button1.BorderRadius = 9;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Blue;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(768, 653);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(267, 87);
            this.guna2Button1.TabIndex = 3;
            this.guna2Button1.Text = "Buy";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderColor = System.Drawing.Color.DimGray;
            this.guna2Button2.BorderRadius = 38;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Gray;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(453, 801);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(273, 88);
            this.guna2Button2.TabIndex = 4;
            this.guna2Button2.Text = "Show FRMProducts Average";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // Price
            // 
            this.Price.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(496, 443);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(160, 30);
            this.Price.TabIndex = 6;
            this.Price.ValueChanged += new System.EventHandler(this.Price_ValueChanged);
            // 
            // UserBalance
            // 
            this.UserBalance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserBalance.Location = new System.Drawing.Point(800, 443);
            this.UserBalance.Name = "UserBalance";
            this.UserBalance.Size = new System.Drawing.Size(174, 30);
            this.UserBalance.TabIndex = 7;
            this.UserBalance.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btn_ContinueToBuy
            // 
            this.btn_ContinueToBuy.Animated = true;
            this.btn_ContinueToBuy.BorderRadius = 9;
            this.btn_ContinueToBuy.Checked = true;
            this.btn_ContinueToBuy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ContinueToBuy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ContinueToBuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ContinueToBuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ContinueToBuy.FillColor = System.Drawing.Color.Blue;
            this.btn_ContinueToBuy.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_ContinueToBuy.ForeColor = System.Drawing.Color.White;
            this.btn_ContinueToBuy.Location = new System.Drawing.Point(211, 653);
            this.btn_ContinueToBuy.Name = "btn_ContinueToBuy";
            this.btn_ContinueToBuy.Size = new System.Drawing.Size(252, 60);
            this.btn_ContinueToBuy.TabIndex = 8;
            this.btn_ContinueToBuy.Text = "Continue to delivery";
            this.btn_ContinueToBuy.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(491, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Current Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(815, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Current User Balance:";
            // 
            // BuyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PharmacyDesktop.Properties.Resources.shopping;
            this.ClientSize = new System.Drawing.Size(1786, 898);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ContinueToBuy);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.UserBalance);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "BuyForm";
            this.Text = "frmBuy";
            this.Load += new System.EventHandler(this.BuyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserBalance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.NumericUpDown Price;
        private System.Windows.Forms.NumericUpDown UserBalance;
        private Guna.UI2.WinForms.Guna2Button btn_ContinueToBuy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}