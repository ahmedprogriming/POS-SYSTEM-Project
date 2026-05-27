namespace POS_SYSTEM_Project
{
    partial class frmAddEditProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditProduct));
            this.lblTitle = new Guna.UI.WinForms.GunaLabel();
            this.txtNameProduct = new Guna.UI.WinForms.GunaTextBox();
            this.txtBarcode = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtCostPrice = new Guna.UI.WinForms.GunaTextBox();
            this.txtSupplier = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtStock = new Guna.UI.WinForms.GunaTextBox();
            this.txtSellingPrice = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.cobCategory = new System.Windows.Forms.ComboBox();
            this.lblProductID = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.btnClose = new Guna.UI.WinForms.GunaButton();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(263, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(263, 59);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Add Product";
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
            this.txtNameProduct.Location = new System.Drawing.Point(161, 189);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.PasswordChar = '\0';
            this.txtNameProduct.Radius = 8;
            this.txtNameProduct.SelectedText = "";
            this.txtNameProduct.Size = new System.Drawing.Size(167, 33);
            this.txtNameProduct.TabIndex = 24;
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
            this.txtBarcode.Location = new System.Drawing.Point(161, 150);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.PasswordChar = '\0';
            this.txtBarcode.Radius = 8;
            this.txtBarcode.SelectedText = "";
            this.txtBarcode.Size = new System.Drawing.Size(167, 33);
            this.txtBarcode.TabIndex = 23;
            this.txtBarcode.Validating += new System.ComponentModel.CancelEventHandler(this.txtBarcode_Validating);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.gunaLabel5.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel5.Location = new System.Drawing.Point(13, 189);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(72, 25);
            this.gunaLabel5.TabIndex = 22;
            this.gunaLabel5.Text = "Name :";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.gunaLabel4.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel4.Location = new System.Drawing.Point(13, 149);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(92, 25);
            this.gunaLabel4.TabIndex = 21;
            this.gunaLabel4.Text = "Barcode :";
            // 
            // txtCostPrice
            // 
            this.txtCostPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtCostPrice.BaseColor = System.Drawing.Color.White;
            this.txtCostPrice.BorderColor = System.Drawing.Color.Silver;
            this.txtCostPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCostPrice.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCostPrice.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtCostPrice.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCostPrice.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtCostPrice.Location = new System.Drawing.Point(586, 188);
            this.txtCostPrice.Name = "txtCostPrice";
            this.txtCostPrice.PasswordChar = '\0';
            this.txtCostPrice.Radius = 8;
            this.txtCostPrice.SelectedText = "";
            this.txtCostPrice.Size = new System.Drawing.Size(167, 33);
            this.txtCostPrice.TabIndex = 28;
            this.txtCostPrice.Validating += new System.ComponentModel.CancelEventHandler(this.txtCostPrice_Validating);
            // 
            // txtSupplier
            // 
            this.txtSupplier.BackColor = System.Drawing.Color.Transparent;
            this.txtSupplier.BaseColor = System.Drawing.Color.White;
            this.txtSupplier.BorderColor = System.Drawing.Color.Silver;
            this.txtSupplier.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSupplier.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSupplier.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtSupplier.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSupplier.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtSupplier.Location = new System.Drawing.Point(586, 149);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.PasswordChar = '\0';
            this.txtSupplier.Radius = 8;
            this.txtSupplier.SelectedText = "";
            this.txtSupplier.Size = new System.Drawing.Size(167, 33);
            this.txtSupplier.TabIndex = 27;
            this.txtSupplier.Validating += new System.ComponentModel.CancelEventHandler(this.txtSupplier_Validating);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(420, 189);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(106, 25);
            this.gunaLabel1.TabIndex = 26;
            this.gunaLabel1.Text = "Cost Price :";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(420, 150);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(92, 25);
            this.gunaLabel2.TabIndex = 25;
            this.gunaLabel2.Text = "Supplier :";
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.Color.Transparent;
            this.txtStock.BaseColor = System.Drawing.Color.White;
            this.txtStock.BorderColor = System.Drawing.Color.Silver;
            this.txtStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStock.FocusedBaseColor = System.Drawing.Color.White;
            this.txtStock.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtStock.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtStock.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtStock.Location = new System.Drawing.Point(586, 274);
            this.txtStock.Name = "txtStock";
            this.txtStock.PasswordChar = '\0';
            this.txtStock.Radius = 8;
            this.txtStock.SelectedText = "";
            this.txtStock.Size = new System.Drawing.Size(167, 33);
            this.txtStock.TabIndex = 32;
            this.txtStock.Validating += new System.ComponentModel.CancelEventHandler(this.txtStock_Validating);
            // 
            // txtSellingPrice
            // 
            this.txtSellingPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtSellingPrice.BaseColor = System.Drawing.Color.White;
            this.txtSellingPrice.BorderColor = System.Drawing.Color.Silver;
            this.txtSellingPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSellingPrice.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSellingPrice.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtSellingPrice.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSellingPrice.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtSellingPrice.Location = new System.Drawing.Point(586, 235);
            this.txtSellingPrice.Name = "txtSellingPrice";
            this.txtSellingPrice.PasswordChar = '\0';
            this.txtSellingPrice.Radius = 8;
            this.txtSellingPrice.SelectedText = "";
            this.txtSellingPrice.Size = new System.Drawing.Size(167, 33);
            this.txtSellingPrice.TabIndex = 31;
            this.txtSellingPrice.Validating += new System.ComponentModel.CancelEventHandler(this.txtSellingPrice_Validating);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel3.Location = new System.Drawing.Point(420, 275);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(69, 25);
            this.gunaLabel3.TabIndex = 30;
            this.gunaLabel3.Text = "Stock :";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.gunaLabel6.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel6.Location = new System.Drawing.Point(420, 236);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(126, 25);
            this.gunaLabel6.TabIndex = 29;
            this.gunaLabel6.Text = "Selling Price :";
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.gunaLabel9.Location = new System.Drawing.Point(13, 235);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(100, 25);
            this.gunaLabel9.TabIndex = 33;
            this.gunaLabel9.Text = "Category :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.cobCategory);
            this.panel1.Controls.Add(this.lblProductID);
            this.panel1.Controls.Add(this.gunaLabel8);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(12, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 225);
            this.panel1.TabIndex = 44;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::POS_SYSTEM_Project.Properties.Resources.barcode;
            this.pictureBox8.Location = new System.Drawing.Point(99, 55);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(30, 30);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 37;
            this.pictureBox8.TabStop = false;
            // 
            // cobCategory
            // 
            this.cobCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cobCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobCategory.FormattingEnabled = true;
            this.cobCategory.Items.AddRange(new object[] {
            "Beverages",
            "Snacks",
            "Cleaning"});
            this.cobCategory.Location = new System.Drawing.Point(149, 150);
            this.cobCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cobCategory.Name = "cobCategory";
            this.cobCategory.Size = new System.Drawing.Size(167, 24);
            this.cobCategory.TabIndex = 36;
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductID.ForeColor = System.Drawing.Color.Black;
            this.lblProductID.Location = new System.Drawing.Point(167, 11);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(48, 28);
            this.lblProductID.TabIndex = 27;
            this.lblProductID.Text = "????";
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.gunaLabel8.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel8.Location = new System.Drawing.Point(9, 9);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(113, 25);
            this.gunaLabel8.TabIndex = 26;
            this.gunaLabel8.Text = "Product ID :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::POS_SYSTEM_Project.Properties.Resources.Number_32;
            this.pictureBox2.Location = new System.Drawing.Point(128, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.AnimationHoverSpeed = 0.07F;
            this.btnSave.AnimationSpeed = 0.03F;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSave.BorderColor = System.Drawing.Color.Transparent;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.FocusedColor = System.Drawing.Color.Empty;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageSize = new System.Drawing.Size(18, 18);
            this.btnSave.Location = new System.Drawing.Point(504, 340);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Radius = 10;
            this.btnSave.Size = new System.Drawing.Size(115, 40);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnClose.Location = new System.Drawing.Point(643, 340);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Radius = 10;
            this.btnClose.Size = new System.Drawing.Size(120, 40);
            this.btnClose.TabIndex = 42;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::POS_SYSTEM_Project.Properties.Resources.stock_market;
            this.pictureBox7.Location = new System.Drawing.Point(533, 277);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(30, 30);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 41;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::POS_SYSTEM_Project.Properties.Resources.truck;
            this.pictureBox6.Location = new System.Drawing.Point(533, 153);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 30);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 40;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::POS_SYSTEM_Project.Properties.Resources.bag_money_handbag_sack;
            this.pictureBox5.Location = new System.Drawing.Point(532, 192);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 39;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::POS_SYSTEM_Project.Properties.Resources.money_32;
            this.pictureBox4.Location = new System.Drawing.Point(533, 236);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 38;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::POS_SYSTEM_Project.Properties.Resources.user1;
            this.pictureBox3.Location = new System.Drawing.Point(111, 192);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 37;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POS_SYSTEM_Project.Properties.Resources.inventory;
            this.pictureBox1.Location = new System.Drawing.Point(111, 238);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 387);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gunaLabel9);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtSellingPrice);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.txtCostPrice);
            this.Controls.Add(this.txtSupplier);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.txtNameProduct);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddEditProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.frmAddEditProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lblTitle;
        private Guna.UI.WinForms.GunaTextBox txtNameProduct;
        private Guna.UI.WinForms.GunaTextBox txtBarcode;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox txtCostPrice;
        private Guna.UI.WinForms.GunaTextBox txtSupplier;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txtStock;
        private Guna.UI.WinForms.GunaTextBox txtSellingPrice;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private Guna.UI.WinForms.GunaButton btnSave;
        private Guna.UI.WinForms.GunaButton btnClose;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLabel lblProductID;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private System.Windows.Forms.ComboBox cobCategory;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}