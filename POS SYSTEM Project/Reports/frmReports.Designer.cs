namespace POS_SYSTEM_Project
{
    partial class frmReports
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReports));
            this.panTop = new System.Windows.Forms.Panel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.lblRoleName = new Guna.UI.WinForms.GunaLabel();
            this.lblNameUser = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.cobReports = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtToDate = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.dgvReportList = new System.Windows.Forms.DataGridView();
            this.btnGenerateReport = new Guna.UI.WinForms.GunaButton();
            this.btnExportPdf = new Guna.UI.WinForms.GunaButton();
            this.btnExportExcel = new Guna.UI.WinForms.GunaButton();
            this.btnClose = new Guna.UI.WinForms.GunaButton();
            this.panTop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportList)).BeginInit();
            this.SuspendLayout();
            // 
            // panTop
            // 
            this.panTop.BackColor = System.Drawing.Color.White;
            this.panTop.Controls.Add(this.gunaLabel2);
            this.panTop.Controls.Add(this.gunaLabel1);
            this.panTop.Controls.Add(this.lblRoleName);
            this.panTop.Controls.Add(this.lblNameUser);
            this.panTop.Controls.Add(this.gunaLabel7);
            this.panTop.Location = new System.Drawing.Point(2, 3);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(1099, 82);
            this.panTop.TabIndex = 2;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(998, 8);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(26, 38);
            this.gunaLabel2.TabIndex = 16;
            this.gunaLabel2.Text = "|";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gunaLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(818, 8);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(99, 38);
            this.gunaLabel1.TabIndex = 15;
            this.gunaLabel1.Text = " User :";
            // 
            // lblRoleName
            // 
            this.lblRoleName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRoleName.AutoSize = true;
            this.lblRoleName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblRoleName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleName.ForeColor = System.Drawing.Color.Black;
            this.lblRoleName.Location = new System.Drawing.Point(1020, 15);
            this.lblRoleName.Name = "lblRoleName";
            this.lblRoleName.Size = new System.Drawing.Size(74, 28);
            this.lblRoleName.TabIndex = 15;
            this.lblRoleName.Text = "Admin";
            // 
            // lblNameUser
            // 
            this.lblNameUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNameUser.AutoSize = true;
            this.lblNameUser.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNameUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameUser.ForeColor = System.Drawing.Color.Black;
            this.lblNameUser.Location = new System.Drawing.Point(923, 15);
            this.lblNameUser.Name = "lblNameUser";
            this.lblNameUser.Size = new System.Drawing.Size(79, 28);
            this.lblNameUser.TabIndex = 14;
            this.lblNameUser.Text = "Ahmed";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gunaLabel7.Cursor = System.Windows.Forms.Cursors.Default;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel7.Location = new System.Drawing.Point(3, 8);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(626, 59);
            this.gunaLabel7.TabIndex = 12;
            this.gunaLabel7.Text = "Reports && Analytics  Magament";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel3.Location = new System.Drawing.Point(44, 122);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(129, 38);
            this.gunaLabel3.TabIndex = 64;
            this.gunaLabel3.Text = "To Date :";
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel8.Location = new System.Drawing.Point(10, 84);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(166, 38);
            this.gunaLabel8.TabIndex = 62;
            this.gunaLabel8.Text = "From Date :";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel4.Location = new System.Drawing.Point(10, 34);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(186, 38);
            this.gunaLabel4.TabIndex = 67;
            this.gunaLabel4.Text = "Report Type :";
            // 
            // cobReports
            // 
            this.cobReports.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cobReports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobReports.FormattingEnabled = true;
            this.cobReports.Items.AddRange(new object[] {
            "Daily Sales",
            "Monthly Sales",
            "Yearly Sales"});
            this.cobReports.Location = new System.Drawing.Point(201, 48);
            this.cobReports.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cobReports.Name = "cobReports";
            this.cobReports.Size = new System.Drawing.Size(172, 24);
            this.cobReports.TabIndex = 68;
            this.cobReports.SelectedIndexChanged += new System.EventHandler(this.cobReports_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.dtToDate);
            this.panel1.Controls.Add(this.dtFrom);
            this.panel1.Controls.Add(this.gunaLabel5);
            this.panel1.Controls.Add(this.gunaLabel4);
            this.panel1.Controls.Add(this.cobReports);
            this.panel1.Controls.Add(this.gunaLabel8);
            this.panel1.Controls.Add(this.gunaLabel3);
            this.panel1.Location = new System.Drawing.Point(15, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 169);
            this.panel1.TabIndex = 69;
            // 
            // dtToDate
            // 
            this.dtToDate.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dtToDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtToDate.Location = new System.Drawing.Point(182, 133);
            this.dtToDate.MinDate = new System.DateTime(2025, 1, 12, 0, 0, 0, 0);
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.Size = new System.Drawing.Size(166, 27);
            this.dtToDate.TabIndex = 72;
            // 
            // dtFrom
            // 
            this.dtFrom.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dtFrom.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(182, 100);
            this.dtFrom.MinDate = new System.DateTime(2025, 1, 12, 0, 0, 0, 0);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(166, 27);
            this.dtFrom.TabIndex = 71;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel5.Location = new System.Drawing.Point(13, 0);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(132, 22);
            this.gunaLabel5.TabIndex = 70;
            this.gunaLabel5.Text = "Filters Report";
            // 
            // dgvReportList
            // 
            this.dgvReportList.BackgroundColor = System.Drawing.Color.White;
            this.dgvReportList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReportList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReportList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportList.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvReportList.Location = new System.Drawing.Point(12, 298);
            this.dgvReportList.Name = "dgvReportList";
            this.dgvReportList.RowHeadersWidth = 51;
            this.dgvReportList.RowTemplate.Height = 30;
            this.dgvReportList.Size = new System.Drawing.Size(1084, 423);
            this.dgvReportList.TabIndex = 70;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.AnimationHoverSpeed = 0.07F;
            this.btnGenerateReport.AnimationSpeed = 0.03F;
            this.btnGenerateReport.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerateReport.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnGenerateReport.BorderColor = System.Drawing.Color.Transparent;
            this.btnGenerateReport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGenerateReport.FocusedColor = System.Drawing.Color.Empty;
            this.btnGenerateReport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGenerateReport.ForeColor = System.Drawing.Color.White;
            this.btnGenerateReport.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerateReport.Image")));
            this.btnGenerateReport.ImageSize = new System.Drawing.Size(18, 18);
            this.btnGenerateReport.Location = new System.Drawing.Point(464, 252);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnGenerateReport.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnGenerateReport.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGenerateReport.OnHoverImage = null;
            this.btnGenerateReport.OnPressedColor = System.Drawing.Color.Black;
            this.btnGenerateReport.Radius = 10;
            this.btnGenerateReport.Size = new System.Drawing.Size(196, 40);
            this.btnGenerateReport.TabIndex = 71;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // btnExportPdf
            // 
            this.btnExportPdf.AnimationHoverSpeed = 0.07F;
            this.btnExportPdf.AnimationSpeed = 0.03F;
            this.btnExportPdf.BackColor = System.Drawing.Color.Transparent;
            this.btnExportPdf.BaseColor = System.Drawing.Color.Red;
            this.btnExportPdf.BorderColor = System.Drawing.Color.Transparent;
            this.btnExportPdf.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExportPdf.FocusedColor = System.Drawing.Color.Empty;
            this.btnExportPdf.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExportPdf.ForeColor = System.Drawing.Color.White;
            this.btnExportPdf.Image = ((System.Drawing.Image)(resources.GetObject("btnExportPdf.Image")));
            this.btnExportPdf.ImageSize = new System.Drawing.Size(18, 18);
            this.btnExportPdf.Location = new System.Drawing.Point(766, 252);
            this.btnExportPdf.Name = "btnExportPdf";
            this.btnExportPdf.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnExportPdf.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnExportPdf.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExportPdf.OnHoverImage = null;
            this.btnExportPdf.OnPressedColor = System.Drawing.Color.Black;
            this.btnExportPdf.Radius = 10;
            this.btnExportPdf.Size = new System.Drawing.Size(153, 40);
            this.btnExportPdf.TabIndex = 73;
            this.btnExportPdf.Text = "Export PDF";
            this.btnExportPdf.Click += new System.EventHandler(this.btnExportPdf_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.AnimationHoverSpeed = 0.07F;
            this.btnExportExcel.AnimationSpeed = 0.03F;
            this.btnExportExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnExportExcel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnExportExcel.BorderColor = System.Drawing.Color.Transparent;
            this.btnExportExcel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExportExcel.FocusedColor = System.Drawing.Color.Empty;
            this.btnExportExcel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExportExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportExcel.Image")));
            this.btnExportExcel.ImageSize = new System.Drawing.Size(18, 18);
            this.btnExportExcel.Location = new System.Drawing.Point(941, 252);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnExportExcel.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnExportExcel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExportExcel.OnHoverImage = null;
            this.btnExportExcel.OnPressedColor = System.Drawing.Color.Black;
            this.btnExportExcel.Radius = 10;
            this.btnExportExcel.Size = new System.Drawing.Size(151, 40);
            this.btnExportExcel.TabIndex = 72;
            this.btnExportExcel.Text = "Export Excel";
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnClose
            // 
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnClose.BorderColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.FocusedColor = System.Drawing.Color.Empty;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::POS_SYSTEM_Project.Properties.Resources.Close_64;
            this.btnClose.ImageSize = new System.Drawing.Size(18, 18);
            this.btnClose.Location = new System.Drawing.Point(979, 727);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Radius = 10;
            this.btnClose.Size = new System.Drawing.Size(117, 40);
            this.btnClose.TabIndex = 74;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1104, 773);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnExportPdf);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.dgvReportList);
            this.Controls.Add(this.panTop);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReports";
            this.Load += new System.EventHandler(this.frmReports_Load);
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panTop;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel lblRoleName;
        private Guna.UI.WinForms.GunaLabel lblNameUser;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private System.Windows.Forms.ComboBox cobReports;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private System.Windows.Forms.DataGridView dgvReportList;
        private Guna.UI.WinForms.GunaButton btnGenerateReport;
        private Guna.UI.WinForms.GunaButton btnExportPdf;
        private Guna.UI.WinForms.GunaButton btnExportExcel;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.DateTimePicker dtToDate;
        private Guna.UI.WinForms.GunaButton btnClose;
    }
}