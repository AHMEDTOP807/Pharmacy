namespace PharmacyDesktop
{
    partial class SmallPrWaiting
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
            this.Pr_Wait = new System.Windows.Forms.ProgressBar();
            this.lblPrWait = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Pr_Wait
            // 
            this.Pr_Wait.Location = new System.Drawing.Point(102, 75);
            this.Pr_Wait.Name = "Pr_Wait";
            this.Pr_Wait.Size = new System.Drawing.Size(515, 108);
            this.Pr_Wait.TabIndex = 0;
            // 
            // lblPrWait
            // 
            this.lblPrWait.AutoSize = true;
            this.lblPrWait.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrWait.Location = new System.Drawing.Point(300, 33);
            this.lblPrWait.Name = "lblPrWait";
            this.lblPrWait.Size = new System.Drawing.Size(30, 25);
            this.lblPrWait.TabIndex = 1;
            this.lblPrWait.Text = "   ";
            // 
            // SmallPrWaiting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 525);
            this.Controls.Add(this.lblPrWait);
            this.Controls.Add(this.Pr_Wait);
            this.Name = "SmallPrWaiting";
            this.Text = "SmallPrWaiting";
            this.Load += new System.EventHandler(this.SmallPrWiat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar Pr_Wait;
        private System.Windows.Forms.Label lblPrWait;
    }
}