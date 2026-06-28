namespace POS_SYSTEM_Project
{
    partial class frmProductList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductList));
            this.panTop = new System.Windows.Forms.Panel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.lblRoleName = new Guna.UI.WinForms.GunaLabel();
            this.lblNameUser = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txbFilter = new System.Windows.Forms.TextBox();
            this.cobFilter = new System.Windows.Forms.ComboBox();
            this.btnAddProduct = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnViewDetailes = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnClose = new Guna.UI.WinForms.GunaButton();
            this.btnDelete = new Guna.UI.WinForms.GunaButton();
            this.btnEdit = new Guna.UI.WinForms.GunaButton();
            this.cobCategory = new System.Windows.Forms.ComboBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.lblRecordes = new Guna.UI.WinForms.GunaLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.panTop.Location = new System.Drawing.Point(2, 1);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(1338, 82);
            this.panTop.TabIndex = 0;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(1231, 16);
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
            this.gunaLabel1.Location = new System.Drawing.Point(1051, 16);
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
            this.lblRoleName.Location = new System.Drawing.Point(1253, 23);
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
            this.lblNameUser.Location = new System.Drawing.Point(1156, 23);
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
            this.gunaLabel7.Size = new System.Drawing.Size(409, 59);
            this.gunaLabel7.TabIndex = 12;
            this.gunaLabel7.Text = "Products Magament";
            // 
            // dgvProductList
            // 
            this.dgvProductList.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvProductList.Location = new System.Drawing.Point(12, 150);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.RowHeadersWidth = 51;
            this.dgvProductList.RowTemplate.Height = 30;
            this.dgvProductList.Size = new System.Drawing.Size(1311, 491);
            this.dgvProductList.TabIndex = 3;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel3.Location = new System.Drawing.Point(3, 29);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(110, 28);
            this.gunaLabel3.TabIndex = 15;
            this.gunaLabel3.Text = "Search By:";
            // 
            // txbFilter
            // 
            this.txbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFilter.Location = new System.Drawing.Point(310, 30);
            this.txbFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbFilter.Name = "txbFilter";
            this.txbFilter.Size = new System.Drawing.Size(190, 27);
            this.txbFilter.TabIndex = 17;
            this.txbFilter.TextChanged += new System.EventHandler(this.txbFilter_TextChanged);
            this.txbFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbFilter_KeyPress);
            // 
            // cobFilter
            // 
            this.cobFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobFilter.FormattingEnabled = true;
            this.cobFilter.Items.AddRange(new object[] {
            "None",
            "ProductID",
            "ProductName",
            "Category"});
            this.cobFilter.Location = new System.Drawing.Point(113, 119);
            this.cobFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cobFilter.Name = "cobFilter";
            this.cobFilter.Size = new System.Drawing.Size(194, 24);
            this.cobFilter.TabIndex = 16;
            this.cobFilter.SelectedIndexChanged += new System.EventHandler(this.cobFilter_SelectedIndexChanged);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.AnimationHoverSpeed = 0.07F;
            this.btnAddProduct.AnimationSpeed = 0.03F;
            this.btnAddProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnAddProduct.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddProduct.BorderColor = System.Drawing.Color.Black;
            this.btnAddProduct.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAddProduct.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAddProduct.CheckedForeColor = System.Drawing.Color.White;
            this.btnAddProduct.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.CheckedImage")));
            this.btnAddProduct.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAddProduct.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddProduct.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.Black;
            this.btnAddProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.Image")));
            this.btnAddProduct.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddProduct.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddProduct.Location = new System.Drawing.Point(1140, 8);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAddProduct.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddProduct.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddProduct.OnHoverImage = null;
            this.btnAddProduct.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddProduct.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddProduct.Radius = 10;
            this.btnAddProduct.Size = new System.Drawing.Size(180, 42);
            this.btnAddProduct.TabIndex = 18;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnViewDetailes
            // 
            this.btnViewDetailes.AnimationHoverSpeed = 0.07F;
            this.btnViewDetailes.AnimationSpeed = 0.03F;
            this.btnViewDetailes.BackColor = System.Drawing.Color.Transparent;
            this.btnViewDetailes.BaseColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnViewDetailes.BorderColor = System.Drawing.Color.Black;
            this.btnViewDetailes.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnViewDetailes.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnViewDetailes.CheckedForeColor = System.Drawing.Color.White;
            this.btnViewDetailes.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnViewDetailes.CheckedImage")));
            this.btnViewDetailes.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnViewDetailes.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnViewDetailes.FocusedColor = System.Drawing.Color.Empty;
            this.btnViewDetailes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDetailes.ForeColor = System.Drawing.Color.Black;
            this.btnViewDetailes.Image = ((System.Drawing.Image)(resources.GetObject("btnViewDetailes.Image")));
            this.btnViewDetailes.ImageSize = new System.Drawing.Size(20, 20);
            this.btnViewDetailes.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnViewDetailes.Location = new System.Drawing.Point(992, 571);
            this.btnViewDetailes.Name = "btnViewDetailes";
            this.btnViewDetailes.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnViewDetailes.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnViewDetailes.OnHoverForeColor = System.Drawing.Color.White;
            this.btnViewDetailes.OnHoverImage = null;
            this.btnViewDetailes.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnViewDetailes.OnPressedColor = System.Drawing.Color.Black;
            this.btnViewDetailes.Radius = 10;
            this.btnViewDetailes.Size = new System.Drawing.Size(164, 40);
            this.btnViewDetailes.TabIndex = 21;
            this.btnViewDetailes.Text = "View Detailes";
            this.btnViewDetailes.Click += new System.EventHandler(this.btnViewDetailes_Click);
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
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageSize = new System.Drawing.Size(18, 18);
            this.btnClose.Location = new System.Drawing.Point(1195, 569);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Radius = 10;
            this.btnClose.Size = new System.Drawing.Size(120, 40);
            this.btnClose.TabIndex = 30;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AnimationHoverSpeed = 0.07F;
            this.btnDelete.AnimationSpeed = 0.03F;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDelete.BorderColor = System.Drawing.Color.Transparent;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete.FocusedColor = System.Drawing.Color.Empty;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageSize = new System.Drawing.Size(18, 18);
            this.btnDelete.Location = new System.Drawing.Point(796, 571);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelete.OnHoverImage = null;
            this.btnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelete.Radius = 10;
            this.btnDelete.Size = new System.Drawing.Size(152, 40);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AnimationHoverSpeed = 0.07F;
            this.btnEdit.AnimationSpeed = 0.03F;
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnEdit.BorderColor = System.Drawing.Color.Transparent;
            this.btnEdit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEdit.FocusedColor = System.Drawing.Color.Empty;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageSize = new System.Drawing.Size(18, 18);
            this.btnEdit.Location = new System.Drawing.Point(602, 569);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnEdit.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnEdit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEdit.OnHoverImage = null;
            this.btnEdit.OnPressedColor = System.Drawing.Color.Black;
            this.btnEdit.Radius = 10;
            this.btnEdit.Size = new System.Drawing.Size(140, 40);
            this.btnEdit.TabIndex = 34;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cobCategory
            // 
            this.cobCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobCategory.FormattingEnabled = true;
            this.cobCategory.Items.AddRange(new object[] {
            "All",
            "Beverages",
            "Snacks",
            "Cleaning"});
            this.cobCategory.Location = new System.Drawing.Point(310, 29);
            this.cobCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cobCategory.Name = "cobCategory";
            this.cobCategory.Size = new System.Drawing.Size(173, 24);
            this.cobCategory.TabIndex = 35;
            this.cobCategory.TextChanged += new System.EventHandler(this.cobCategory_TextChanged);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel4.Location = new System.Drawing.Point(7, 567);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(105, 28);
            this.gunaLabel4.TabIndex = 36;
            this.gunaLabel4.Text = "Recordes :";
            // 
            // lblRecordes
            // 
            this.lblRecordes.AutoSize = true;
            this.lblRecordes.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblRecordes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordes.ForeColor = System.Drawing.Color.Black;
            this.lblRecordes.Location = new System.Drawing.Point(109, 569);
            this.lblRecordes.Name = "lblRecordes";
            this.lblRecordes.Size = new System.Drawing.Size(48, 28);
            this.lblRecordes.TabIndex = 37;
            this.lblRecordes.Text = "????";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cobCategory);
            this.panel1.Controls.Add(this.lblRecordes);
            this.panel1.Controls.Add(this.txbFilter);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.gunaLabel3);
            this.panel1.Controls.Add(this.btnAddProduct);
            this.panel1.Controls.Add(this.btnViewDetailes);
            this.panel1.Controls.Add(this.gunaLabel4);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(2, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1338, 622);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // frmProductList
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1340, 711);
            this.Controls.Add(this.cobFilter);
            this.Controls.Add(this.dgvProductList);
            this.Controls.Add(this.panTop);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmProductList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProductList_Load);
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panTop;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel lblRoleName;
        private Guna.UI.WinForms.GunaLabel lblNameUser;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.DataGridView dgvProductList;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private System.Windows.Forms.TextBox txbFilter;
        private System.Windows.Forms.ComboBox cobFilter;
        private Guna.UI.WinForms.GunaAdvenceButton btnAddProduct;
        private Guna.UI.WinForms.GunaAdvenceButton btnViewDetailes;
        private Guna.UI.WinForms.GunaButton btnClose;
        private Guna.UI.WinForms.GunaButton btnDelete;
        private Guna.UI.WinForms.GunaButton btnEdit;
        private System.Windows.Forms.ComboBox cobCategory;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel lblRecordes;
        private System.Windows.Forms.Panel panel1;
    }
}