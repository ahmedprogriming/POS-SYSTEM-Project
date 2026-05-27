namespace POS_SYSTEM_Project
{
    partial class frmDetailesProduct
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
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.ucProductDetails1 = new POS_SYSTEM_Project.ucProductDetails();
            this.SuspendLayout();
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.BackColor = System.Drawing.Color.White;
            this.gunaLabel7.Cursor = System.Windows.Forms.Cursors.Default;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.ForeColor = System.Drawing.Color.Red;
            this.gunaLabel7.Location = new System.Drawing.Point(240, 21);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(312, 59);
            this.gunaLabel7.TabIndex = 14;
            this.gunaLabel7.Text = "Details Product";
            // 
            // ucProductDetails1
            // 
            this.ucProductDetails1.BackColor = System.Drawing.Color.White;
            this.ucProductDetails1.Location = new System.Drawing.Point(27, 83);
            this.ucProductDetails1.Name = "ucProductDetails1";
            this.ucProductDetails1.Size = new System.Drawing.Size(658, 344);
            this.ucProductDetails1.TabIndex = 15;
            // 
            // frmDetailesProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(737, 450);
            this.Controls.Add(this.ucProductDetails1);
            this.Controls.Add(this.gunaLabel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmDetailesProduct";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Details Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private ucProductDetails ucProductDetails1;
    }
}