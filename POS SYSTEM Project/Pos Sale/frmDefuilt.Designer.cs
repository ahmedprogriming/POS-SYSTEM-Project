namespace POS_SYSTEM_Project
{
    partial class frmDefuilt
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
            this.ucDashboard1 = new clrResultSales.ucDashboard();
            this.SuspendLayout();
            // 
            // ucDashboard1
            // 
            this.ucDashboard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ucDashboard1.Location = new System.Drawing.Point(2, 12);
            this.ucDashboard1.Name = "ucDashboard1";
            this.ucDashboard1.Size = new System.Drawing.Size(698, 383);
            this.ucDashboard1.TabIndex = 0;
            this.ucDashboard1.ResultsSalesToday += new System.EventHandler<clrResultSales.ucDashboard.ResultsSalesTodayEventArgs>(this.ucDashboard1_ResultsSalesToday);
            // 
            // frmDefuilt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(699, 381);
            this.Controls.Add(this.ucDashboard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDefuilt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDefuilt";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDefuilt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private clrResultSales.ucDashboard ucDashboard1;
    }
}