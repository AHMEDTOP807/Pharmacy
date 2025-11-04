namespace PharmacyDesktop
{
    partial class AddBatches
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
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.BatchIDLabel = new System.Windows.Forms.Label();
            this.CountryIDLabel = new System.Windows.Forms.Label();
            this.CountryIDMSK = new System.Windows.Forms.MaskedTextBox();
            this.ProductIDMSK = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblBatchID = new System.Windows.Forms.Label();
            this.CBcountries = new System.Windows.Forms.ComboBox();
            this.ProductIDlbl = new System.Windows.Forms.Label();
            this.lCaption = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(308, 657);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(145, 54);
            this.btn_Close.TabIndex = 15;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click_1);
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(598, 657);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(145, 54);
            this.btn_Save.TabIndex = 16;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click_1);
            // 
            // BatchIDLabel
            // 
            this.BatchIDLabel.AutoSize = true;
            this.BatchIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatchIDLabel.Location = new System.Drawing.Point(45, 30);
            this.BatchIDLabel.Name = "BatchIDLabel";
            this.BatchIDLabel.Size = new System.Drawing.Size(92, 22);
            this.BatchIDLabel.TabIndex = 0;
            this.BatchIDLabel.Text = "Batch ID:";
            // 
            // CountryIDLabel
            // 
            this.CountryIDLabel.AutoSize = true;
            this.CountryIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountryIDLabel.Location = new System.Drawing.Point(45, 98);
            this.CountryIDLabel.Name = "CountryIDLabel";
            this.CountryIDLabel.Size = new System.Drawing.Size(105, 22);
            this.CountryIDLabel.TabIndex = 1;
            this.CountryIDLabel.Text = "CountryID:";
            // 
            // CountryIDMSK
            // 
            this.CountryIDMSK.Location = new System.Drawing.Point(227, 98);
            this.CountryIDMSK.Name = "CountryIDMSK";
            this.CountryIDMSK.Size = new System.Drawing.Size(192, 22);
            this.CountryIDMSK.TabIndex = 8;
            // 
            // ProductIDMSK
            // 
            this.ProductIDMSK.Location = new System.Drawing.Point(227, 168);
            this.ProductIDMSK.Name = "ProductIDMSK";
            this.ProductIDMSK.Size = new System.Drawing.Size(192, 22);
            this.ProductIDMSK.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblBatchID);
            this.panel1.Controls.Add(this.CBcountries);
            this.panel1.Controls.Add(this.ProductIDMSK);
            this.panel1.Controls.Add(this.CountryIDMSK);
            this.panel1.Controls.Add(this.ProductIDlbl);
            this.panel1.Controls.Add(this.CountryIDLabel);
            this.panel1.Controls.Add(this.BatchIDLabel);
            this.panel1.Location = new System.Drawing.Point(79, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 496);
            this.panel1.TabIndex = 1;
            // 
            // LblBatchID
            // 
            this.LblBatchID.AutoSize = true;
            this.LblBatchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBatchID.Location = new System.Drawing.Point(278, 30);
            this.LblBatchID.Name = "LblBatchID";
            this.LblBatchID.Size = new System.Drawing.Size(43, 22);
            this.LblBatchID.TabIndex = 17;
            this.LblBatchID.Text = "???";
            // 
            // CBcountries
            // 
            this.CBcountries.FormattingEnabled = true;
            this.CBcountries.Location = new System.Drawing.Point(73, 286);
            this.CBcountries.Name = "CBcountries";
            this.CBcountries.Size = new System.Drawing.Size(301, 24);
            this.CBcountries.TabIndex = 12;
            // 
            // ProductIDlbl
            // 
            this.ProductIDlbl.AutoSize = true;
            this.ProductIDlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIDlbl.Location = new System.Drawing.Point(45, 166);
            this.ProductIDlbl.Name = "ProductIDlbl";
            this.ProductIDlbl.Size = new System.Drawing.Size(104, 22);
            this.ProductIDlbl.TabIndex = 2;
            this.ProductIDlbl.Text = "Product ID";
            // 
            // lCaption
            // 
            this.lCaption.AutoSize = true;
            this.lCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCaption.Location = new System.Drawing.Point(484, 43);
            this.lCaption.Name = "lCaption";
            this.lCaption.Size = new System.Drawing.Size(30, 22);
            this.lCaption.TabIndex = 17;
            this.lCaption.Text = " C";
            // 
            // AddBatches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 792);
            this.Controls.Add(this.lCaption);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.panel1);
            this.Name = "AddBatches";
            this.Text = "AddBatches";
            this.Load += new System.EventHandler(this.AddBatches_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label BatchIDLabel;
        private System.Windows.Forms.Label CountryIDLabel;
        private System.Windows.Forms.MaskedTextBox CountryIDMSK;
        private System.Windows.Forms.MaskedTextBox ProductIDMSK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ProductIDlbl;
        private System.Windows.Forms.Label lCaption;
        private System.Windows.Forms.ComboBox CBcountries;
        private System.Windows.Forms.Label LblBatchID;
    }
}