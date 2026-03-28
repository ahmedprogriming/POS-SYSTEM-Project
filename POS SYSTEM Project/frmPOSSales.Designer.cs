namespace POS_SYSTEM_Project
{
    partial class frmPOSSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPOSSales));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.lblDateToday = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.lblTopTime = new Guna.UI.WinForms.GunaLabel();
            this.ibiUser = new Guna.UI.WinForms.GunaLabel();
            this.lblRole = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaLabel13 = new Guna.UI.WinForms.GunaLabel();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddItem = new Guna.UI.WinForms.GunaButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.btnCleaar = new Guna.UI.WinForms.GunaButton();
            this.btnSearch = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.txtNameProduct = new Guna.UI.WinForms.GunaTextBox();
            this.txtBarcode = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRemoveItem = new Guna.UI.WinForms.GunaButton();
            this.btnClearCart = new Guna.UI.WinForms.GunaButton();
            this.btnConfirmSale = new Guna.UI.WinForms.GunaButton();
            this.btnCancel = new Guna.UI.WinForms.GunaButton();
            this.comPayment = new System.Windows.Forms.ComboBox();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.lblDisCount = new Guna.UI.WinForms.GunaLabel();
            this.lblTax = new Guna.UI.WinForms.GunaLabel();
            this.lblTotal = new Guna.UI.WinForms.GunaLabel();
            this.lblsubtotal = new Guna.UI.WinForms.GunaLabel();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.gunaLabel12 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel11 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.lbl = new Guna.UI.WinForms.GunaLabel();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.errorSearchProduct = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSearchProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.gunaLabel7);
            this.panel1.Controls.Add(this.lblDateToday);
            this.panel1.Controls.Add(this.gunaLabel2);
            this.panel1.Controls.Add(this.lblTopTime);
            this.panel1.Controls.Add(this.ibiUser);
            this.panel1.Controls.Add(this.lblRole);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.panel1.Size = new System.Drawing.Size(1200, 80);
            this.panel1.TabIndex = 0;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.gunaLabel7.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel7.Location = new System.Drawing.Point(978, 28);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(56, 23);
            this.gunaLabel7.TabIndex = 20;
            this.gunaLabel7.Text = "Time :";
            // 
            // lblDateToday
            // 
            this.lblDateToday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateToday.AutoSize = true;
            this.lblDateToday.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblDateToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblDateToday.Location = new System.Drawing.Point(820, 28);
            this.lblDateToday.Name = "lblDateToday";
            this.lblDateToday.Size = new System.Drawing.Size(106, 23);
            this.lblDateToday.TabIndex = 19;
            this.lblDateToday.Text = "12/02/2026";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel2.Location = new System.Drawing.Point(759, 28);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(55, 23);
            this.gunaLabel2.TabIndex = 18;
            this.gunaLabel2.Text = "Date :";
            // 
            // lblTopTime
            // 
            this.lblTopTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTopTime.AutoSize = true;
            this.lblTopTime.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblTopTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTopTime.Location = new System.Drawing.Point(1038, 28);
            this.lblTopTime.Name = "lblTopTime";
            this.lblTopTime.Size = new System.Drawing.Size(88, 23);
            this.lblTopTime.TabIndex = 17;
            this.lblTopTime.Text = "06:22 AM";
            // 
            // ibiUser
            // 
            this.ibiUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibiUser.AutoSize = true;
            this.ibiUser.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.ibiUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ibiUser.Location = new System.Drawing.Point(635, 28);
            this.ibiUser.Name = "ibiUser";
            this.ibiUser.Size = new System.Drawing.Size(68, 23);
            this.ibiUser.TabIndex = 16;
            this.ibiUser.Text = "Ahmed";
            // 
            // lblRole
            // 
            this.lblRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblRole.ForeColor = System.Drawing.Color.DimGray;
            this.lblRole.Location = new System.Drawing.Point(559, 28);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(69, 23);
            this.lblRole.TabIndex = 15;
            this.lblRole.Text = "Admin :";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.gunaLabel1.Location = new System.Drawing.Point(12, 19);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(155, 41);
            this.gunaLabel1.TabIndex = 3;
            this.gunaLabel1.Text = "POS Sales";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.gunaLabel13);
            this.panel2.Controls.Add(this.numQuantity);
            this.panel2.Controls.Add(this.btnAddItem);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.dgvProductList);
            this.panel2.Controls.Add(this.btnCleaar);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.gunaLabel6);
            this.panel2.Controls.Add(this.txtNameProduct);
            this.panel2.Controls.Add(this.txtBarcode);
            this.panel2.Controls.Add(this.gunaLabel5);
            this.panel2.Controls.Add(this.gunaLabel4);
            this.panel2.Location = new System.Drawing.Point(12, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 682);
            this.panel2.TabIndex = 1;
            // 
            // gunaLabel13
            // 
            this.gunaLabel13.AutoSize = true;
            this.gunaLabel13.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.gunaLabel13.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel13.Location = new System.Drawing.Point(18, 163);
            this.gunaLabel13.Name = "gunaLabel13";
            this.gunaLabel13.Size = new System.Drawing.Size(85, 23);
            this.gunaLabel13.TabIndex = 33;
            this.gunaLabel13.Text = "Quantity :";
            // 
            // numQuantity
            // 
            this.numQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQuantity.Location = new System.Drawing.Point(112, 164);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(87, 27);
            this.numQuantity.TabIndex = 32;
            // 
            // btnAddItem
            // 
            this.btnAddItem.AnimationHoverSpeed = 0.07F;
            this.btnAddItem.AnimationSpeed = 0.03F;
            this.btnAddItem.BackColor = System.Drawing.Color.Transparent;
            this.btnAddItem.BaseColor = System.Drawing.Color.White;
            this.btnAddItem.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddItem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddItem.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Image = ((System.Drawing.Image)(resources.GetObject("btnAddItem.Image")));
            this.btnAddItem.ImageSize = new System.Drawing.Size(50, 50);
            this.btnAddItem.Location = new System.Drawing.Point(310, 198);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.OnHoverBaseColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddItem.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnAddItem.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddItem.OnHoverImage = null;
            this.btnAddItem.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddItem.Radius = 10;
            this.btnAddItem.Size = new System.Drawing.Size(71, 42);
            this.btnAddItem.TabIndex = 31;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.gunaLabel8);
            this.panel5.Location = new System.Drawing.Point(12, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 56);
            this.panel5.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::POS_SYSTEM_Project.Properties.Resources.zoom;
            this.pictureBox2.Location = new System.Drawing.Point(10, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.gunaLabel8.Location = new System.Drawing.Point(50, 15);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(155, 28);
            this.gunaLabel8.TabIndex = 17;
            this.gunaLabel8.Text = "Search Product";
            // 
            // dgvProductList
            // 
            this.dgvProductList.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvProductList.Location = new System.Drawing.Point(12, 279);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.RowHeadersWidth = 51;
            this.dgvProductList.RowTemplate.Height = 30;
            this.dgvProductList.Size = new System.Drawing.Size(366, 389);
            this.dgvProductList.TabIndex = 2;
            // 
            // btnCleaar
            // 
            this.btnCleaar.AnimationHoverSpeed = 0.07F;
            this.btnCleaar.AnimationSpeed = 0.03F;
            this.btnCleaar.BackColor = System.Drawing.Color.Transparent;
            this.btnCleaar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnCleaar.BorderColor = System.Drawing.Color.Transparent;
            this.btnCleaar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCleaar.FocusedColor = System.Drawing.Color.Empty;
            this.btnCleaar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCleaar.ForeColor = System.Drawing.Color.White;
            this.btnCleaar.Image = ((System.Drawing.Image)(resources.GetObject("btnCleaar.Image")));
            this.btnCleaar.ImageSize = new System.Drawing.Size(18, 18);
            this.btnCleaar.Location = new System.Drawing.Point(169, 198);
            this.btnCleaar.Name = "btnCleaar";
            this.btnCleaar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnCleaar.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnCleaar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCleaar.OnHoverImage = null;
            this.btnCleaar.OnPressedColor = System.Drawing.Color.Black;
            this.btnCleaar.Radius = 10;
            this.btnCleaar.Size = new System.Drawing.Size(122, 38);
            this.btnCleaar.TabIndex = 23;
            this.btnCleaar.Text = "Clear";
            this.btnCleaar.Click += new System.EventHandler(this.btnCleaar_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AnimationHoverSpeed = 0.07F;
            this.btnSearch.AnimationSpeed = 0.03F;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSearch.BorderColor = System.Drawing.Color.Transparent;
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearch.FocusedColor = System.Drawing.Color.Empty;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageSize = new System.Drawing.Size(18, 18);
            this.btnSearch.Location = new System.Drawing.Point(27, 198);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSearch.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnSearch.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSearch.OnHoverImage = null;
            this.btnSearch.OnPressedColor = System.Drawing.Color.Black;
            this.btnSearch.Radius = 10;
            this.btnSearch.Size = new System.Drawing.Size(122, 38);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
            this.gunaLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.gunaLabel6.Location = new System.Drawing.Point(7, 248);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(134, 28);
            this.gunaLabel6.TabIndex = 21;
            this.gunaLabel6.Text = "Products List";
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.BackColor = System.Drawing.Color.Transparent;
            this.txtNameProduct.BaseColor = System.Drawing.Color.White;
            this.txtNameProduct.BorderColor = System.Drawing.Color.Silver;
            this.txtNameProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameProduct.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNameProduct.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtNameProduct.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNameProduct.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtNameProduct.Location = new System.Drawing.Point(112, 118);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.PasswordChar = '\0';
            this.txtNameProduct.Radius = 8;
            this.txtNameProduct.SelectedText = "";
            this.txtNameProduct.Size = new System.Drawing.Size(250, 36);
            this.txtNameProduct.TabIndex = 20;
            this.txtNameProduct.Validating += new System.ComponentModel.CancelEventHandler(this.txtNameProduct_Validating);
            // 
            // txtBarcode
            // 
            this.txtBarcode.BackColor = System.Drawing.Color.Transparent;
            this.txtBarcode.BaseColor = System.Drawing.Color.White;
            this.txtBarcode.BorderColor = System.Drawing.Color.Silver;
            this.txtBarcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBarcode.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBarcode.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtBarcode.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBarcode.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtBarcode.Location = new System.Drawing.Point(112, 76);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.PasswordChar = '\0';
            this.txtBarcode.Radius = 8;
            this.txtBarcode.SelectedText = "";
            this.txtBarcode.Size = new System.Drawing.Size(250, 36);
            this.txtBarcode.TabIndex = 19;
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcode_KeyPress);
            this.txtBarcode.Validating += new System.ComponentModel.CancelEventHandler(this.txtBarcode_Validating);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.gunaLabel5.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel5.Location = new System.Drawing.Point(23, 131);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(65, 23);
            this.gunaLabel5.TabIndex = 18;
            this.gunaLabel5.Text = "Name :";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.gunaLabel4.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel4.Location = new System.Drawing.Point(18, 89);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(81, 23);
            this.gunaLabel4.TabIndex = 17;
            this.gunaLabel4.Text = "Barcode :";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.btnRemoveItem);
            this.panel4.Controls.Add(this.btnClearCart);
            this.panel4.Controls.Add(this.btnConfirmSale);
            this.panel4.Controls.Add(this.btnCancel);
            this.panel4.Controls.Add(this.comPayment);
            this.panel4.Controls.Add(this.gunaLabel9);
            this.panel4.Controls.Add(this.lblDisCount);
            this.panel4.Controls.Add(this.lblTax);
            this.panel4.Controls.Add(this.lblTotal);
            this.panel4.Controls.Add(this.lblsubtotal);
            this.panel4.Controls.Add(this.gunaLinePanel1);
            this.panel4.Controls.Add(this.gunaLabel12);
            this.panel4.Controls.Add(this.gunaLabel11);
            this.panel4.Controls.Add(this.gunaLabel10);
            this.panel4.Controls.Add(this.lbl);
            this.panel4.Controls.Add(this.dgvCart);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Location = new System.Drawing.Point(414, 92);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(774, 682);
            this.panel4.TabIndex = 2;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.AnimationHoverSpeed = 0.07F;
            this.btnRemoveItem.AnimationSpeed = 0.03F;
            this.btnRemoveItem.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveItem.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnRemoveItem.BorderColor = System.Drawing.Color.Transparent;
            this.btnRemoveItem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRemoveItem.FocusedColor = System.Drawing.Color.Empty;
            this.btnRemoveItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRemoveItem.ForeColor = System.Drawing.Color.White;
            this.btnRemoveItem.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveItem.Image")));
            this.btnRemoveItem.ImageSize = new System.Drawing.Size(18, 18);
            this.btnRemoveItem.Location = new System.Drawing.Point(14, 626);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnRemoveItem.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnRemoveItem.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRemoveItem.OnHoverImage = null;
            this.btnRemoveItem.OnPressedColor = System.Drawing.Color.Black;
            this.btnRemoveItem.Radius = 10;
            this.btnRemoveItem.Size = new System.Drawing.Size(170, 40);
            this.btnRemoveItem.TabIndex = 32;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnClearCart
            // 
            this.btnClearCart.AnimationHoverSpeed = 0.07F;
            this.btnClearCart.AnimationSpeed = 0.03F;
            this.btnClearCart.BackColor = System.Drawing.Color.Transparent;
            this.btnClearCart.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnClearCart.BorderColor = System.Drawing.Color.Transparent;
            this.btnClearCart.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClearCart.FocusedColor = System.Drawing.Color.Empty;
            this.btnClearCart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClearCart.ForeColor = System.Drawing.Color.White;
            this.btnClearCart.Image = ((System.Drawing.Image)(resources.GetObject("btnClearCart.Image")));
            this.btnClearCart.ImageSize = new System.Drawing.Size(18, 18);
            this.btnClearCart.Location = new System.Drawing.Point(191, 626);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnClearCart.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnClearCart.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClearCart.OnHoverImage = null;
            this.btnClearCart.OnPressedColor = System.Drawing.Color.Black;
            this.btnClearCart.Radius = 10;
            this.btnClearCart.Size = new System.Drawing.Size(140, 40);
            this.btnClearCart.TabIndex = 31;
            this.btnClearCart.Text = "Clear Cart";
            // 
            // btnConfirmSale
            // 
            this.btnConfirmSale.AnimationHoverSpeed = 0.07F;
            this.btnConfirmSale.AnimationSpeed = 0.03F;
            this.btnConfirmSale.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmSale.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnConfirmSale.BorderColor = System.Drawing.Color.Transparent;
            this.btnConfirmSale.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnConfirmSale.FocusedColor = System.Drawing.Color.Empty;
            this.btnConfirmSale.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnConfirmSale.ForeColor = System.Drawing.Color.White;
            this.btnConfirmSale.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmSale.Image")));
            this.btnConfirmSale.ImageSize = new System.Drawing.Size(18, 18);
            this.btnConfirmSale.Location = new System.Drawing.Point(339, 626);
            this.btnConfirmSale.Name = "btnConfirmSale";
            this.btnConfirmSale.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnConfirmSale.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnConfirmSale.OnHoverForeColor = System.Drawing.Color.White;
            this.btnConfirmSale.OnHoverImage = null;
            this.btnConfirmSale.OnPressedColor = System.Drawing.Color.Black;
            this.btnConfirmSale.Radius = 10;
            this.btnConfirmSale.Size = new System.Drawing.Size(185, 40);
            this.btnConfirmSale.TabIndex = 30;
            this.btnConfirmSale.Text = "Confirm Sale";
            // 
            // btnCancel
            // 
            this.btnCancel.AnimationHoverSpeed = 0.07F;
            this.btnCancel.AnimationSpeed = 0.03F;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnCancel.BorderColor = System.Drawing.Color.Transparent;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancel.FocusedColor = System.Drawing.Color.Empty;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageSize = new System.Drawing.Size(18, 18);
            this.btnCancel.Location = new System.Drawing.Point(532, 626);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnCancel.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnCancel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCancel.OnHoverImage = null;
            this.btnCancel.OnPressedColor = System.Drawing.Color.Black;
            this.btnCancel.Radius = 10;
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel";
            // 
            // comPayment
            // 
            this.comPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comPayment.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.comPayment.FormattingEnabled = true;
            this.comPayment.Items.AddRange(new object[] {
            "Cash",
            "Card"});
            this.comPayment.Location = new System.Drawing.Point(196, 577);
            this.comPayment.Name = "comPayment";
            this.comPayment.Size = new System.Drawing.Size(176, 31);
            this.comPayment.TabIndex = 28;
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
            this.gunaLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.gunaLabel9.Location = new System.Drawing.Point(14, 578);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(186, 28);
            this.gunaLabel9.TabIndex = 27;
            this.gunaLabel9.Text = "Payment Method :";
            // 
            // lblDisCount
            // 
            this.lblDisCount.AutoSize = true;
            this.lblDisCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDisCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblDisCount.Location = new System.Drawing.Point(627, 458);
            this.lblDisCount.Name = "lblDisCount";
            this.lblDisCount.Size = new System.Drawing.Size(71, 28);
            this.lblDisCount.TabIndex = 26;
            this.lblDisCount.Text = "0.00 $";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTax.Location = new System.Drawing.Point(627, 493);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(71, 28);
            this.lblTax.TabIndex = 25;
            this.lblTax.Text = "0.00 $";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblTotal.Location = new System.Drawing.Point(623, 537);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(95, 37);
            this.lblTotal.TabIndex = 24;
            this.lblTotal.Text = "0.00 $";
            // 
            // lblsubtotal
            // 
            this.lblsubtotal.AutoSize = true;
            this.lblsubtotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblsubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblsubtotal.Location = new System.Drawing.Point(627, 423);
            this.lblsubtotal.Name = "lblsubtotal";
            this.lblsubtotal.Size = new System.Drawing.Size(71, 28);
            this.lblsubtotal.TabIndex = 23;
            this.lblsubtotal.Text = "0.00 $";
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(19, 530);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(687, 2);
            this.gunaLinePanel1.TabIndex = 22;
            // 
            // gunaLabel12
            // 
            this.gunaLabel12.AutoSize = true;
            this.gunaLabel12.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel12.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel12.Location = new System.Drawing.Point(14, 458);
            this.gunaLabel12.Name = "gunaLabel12";
            this.gunaLabel12.Size = new System.Drawing.Size(95, 25);
            this.gunaLabel12.TabIndex = 21;
            this.gunaLabel12.Text = "Discount :";
            // 
            // gunaLabel11
            // 
            this.gunaLabel11.AutoSize = true;
            this.gunaLabel11.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel11.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel11.Location = new System.Drawing.Point(14, 493);
            this.gunaLabel11.Name = "gunaLabel11";
            this.gunaLabel11.Size = new System.Drawing.Size(48, 25);
            this.gunaLabel11.TabIndex = 20;
            this.gunaLabel11.Text = "Tax :";
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.gunaLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.gunaLabel10.Location = new System.Drawing.Point(14, 541);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(76, 30);
            this.gunaLabel10.TabIndex = 19;
            this.gunaLabel10.Text = "Total :";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbl.ForeColor = System.Drawing.Color.DimGray;
            this.lbl.Location = new System.Drawing.Point(14, 423);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(93, 25);
            this.lbl.TabIndex = 18;
            this.lbl.Text = "SubTotal :";
            // 
            // dgvCart
            // 
            this.dgvCart.BackgroundColor = System.Drawing.Color.White;
            this.dgvCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.ColQty,
            this.ColPrice,
            this.ColTotal});
            this.dgvCart.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvCart.Location = new System.Drawing.Point(14, 76);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.RowTemplate.Height = 30;
            this.dgvCart.Size = new System.Drawing.Size(742, 328);
            this.dgvCart.TabIndex = 5;
            // 
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.MinimumWidth = 6;
            this.Product.Name = "Product";
            this.Product.Width = 200;
            // 
            // ColQty
            // 
            this.ColQty.HeaderText = "Qty";
            this.ColQty.MinimumWidth = 6;
            this.ColQty.Name = "ColQty";
            this.ColQty.Width = 125;
            // 
            // ColPrice
            // 
            this.ColPrice.HeaderText = "Price";
            this.ColPrice.MinimumWidth = 6;
            this.ColPrice.Name = "ColPrice";
            this.ColPrice.Width = 125;
            // 
            // ColTotal
            // 
            this.ColTotal.HeaderText = "Total";
            this.ColTotal.MinimumWidth = 6;
            this.ColTotal.Name = "ColTotal";
            this.ColTotal.Width = 125;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.gunaLabel3);
            this.panel3.Location = new System.Drawing.Point(14, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 56);
            this.panel3.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POS_SYSTEM_Project.Properties.Resources.invoice;
            this.pictureBox1.Location = new System.Drawing.Point(10, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.gunaLabel3.Location = new System.Drawing.Point(50, 15);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(157, 28);
            this.gunaLabel3.TabIndex = 17;
            this.gunaLabel3.Text = "Current Invoice";
            // 
            // errorSearchProduct
            // 
            this.errorSearchProduct.ContainerControl = this;
            // 
            // frmPOSSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1200, 786);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPOSSales";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Screen";
            this.Load += new System.EventHandler(this.frmPOSSales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSearchProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel lblTopTime;
        private Guna.UI.WinForms.GunaLabel ibiUser;
        private Guna.UI.WinForms.GunaLabel lblRole;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel lblDateToday;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaButton btnSearch;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaTextBox txtNameProduct;
        private Guna.UI.WinForms.GunaTextBox txtBarcode;
        private Guna.UI.WinForms.GunaButton btnCleaar;
        private System.Windows.Forms.DataGridView dgvProductList;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private System.Windows.Forms.DataGridView dgvCart;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel12;
        private Guna.UI.WinForms.GunaLabel gunaLabel11;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaLabel lbl;
        private Guna.UI.WinForms.GunaLabel lblDisCount;
        private Guna.UI.WinForms.GunaLabel lblTax;
        private Guna.UI.WinForms.GunaLabel lblTotal;
        private Guna.UI.WinForms.GunaLabel lblsubtotal;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaButton btnRemoveItem;
        private Guna.UI.WinForms.GunaButton btnClearCart;
        private Guna.UI.WinForms.GunaButton btnConfirmSale;
        private Guna.UI.WinForms.GunaButton btnCancel;
        private System.Windows.Forms.ComboBox comPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotal;
        private Guna.UI.WinForms.GunaButton btnAddItem;
        private System.Windows.Forms.ErrorProvider errorSearchProduct;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private Guna.UI.WinForms.GunaLabel gunaLabel13;
    }
}