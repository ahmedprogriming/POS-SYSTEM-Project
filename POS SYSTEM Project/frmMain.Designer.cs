namespace POS_SYSTEM_Project
{
    partial class frmMain
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
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.panLeft = new System.Windows.Forms.Panel();
            this.btnDashMenu = new Guna.UI.WinForms.GunaTileButton();
            this.panSaidMenu = new System.Windows.Forms.Panel();
            this.btnReport = new Guna.UI.WinForms.GunaGradientButton();
            this.btnUsers = new Guna.UI.WinForms.GunaGradientButton();
            this.btnLogout = new Guna.UI.WinForms.GunaGradientButton();
            this.btnProducts = new Guna.UI.WinForms.GunaGradientButton();
            this.btnCategories = new Guna.UI.WinForms.GunaGradientButton();
            this.btnSuppliers = new Guna.UI.WinForms.GunaGradientButton();
            this.btnInventory = new Guna.UI.WinForms.GunaGradientButton();
            this.brnSales = new Guna.UI.WinForms.GunaGradientButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTime = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.lblDateToday = new Guna.UI.WinForms.GunaLabel();
            this.lblNamerole = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.lblNameuser = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.lblNameWelcome = new Guna.UI.WinForms.GunaLabel();
            this.PanMain = new System.Windows.Forms.Panel();
            this.TimerDateToDay = new System.Windows.Forms.Timer(this.components);
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.ibiRoleName2 = new Guna.UI.WinForms.GunaLabel();
            this.lblTopTime = new Guna.UI.WinForms.GunaLabel();
            this.panLeft.SuspendLayout();
            this.panSaidMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(251, 59);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "POS System";
            // 
            // panLeft
            // 
            this.panLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.panLeft.Controls.Add(this.btnDashMenu);
            this.panLeft.Controls.Add(this.panSaidMenu);
            this.panLeft.Controls.Add(this.gunaLabel1);
            this.panLeft.Location = new System.Drawing.Point(1, -2);
            this.panLeft.Name = "panLeft";
            this.panLeft.Size = new System.Drawing.Size(336, 848);
            this.panLeft.TabIndex = 2;
            // 
            // btnDashMenu
            // 
            this.btnDashMenu.AnimationHoverSpeed = 0.07F;
            this.btnDashMenu.AnimationSpeed = 0.03F;
            this.btnDashMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(199)))), ((int)(((byte)(58)))));
            this.btnDashMenu.BaseColor = System.Drawing.Color.ForestGreen;
            this.btnDashMenu.BorderColor = System.Drawing.Color.Black;
            this.btnDashMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashMenu.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDashMenu.FocusedColor = System.Drawing.Color.Empty;
            this.btnDashMenu.Font = new System.Drawing.Font("Segoe UI Historic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashMenu.ForeColor = System.Drawing.Color.White;
            this.btnDashMenu.Image = global::POS_SYSTEM_Project.Properties.Resources.home;
            this.btnDashMenu.ImageSize = new System.Drawing.Size(52, 52);
            this.btnDashMenu.Location = new System.Drawing.Point(-3, 94);
            this.btnDashMenu.Name = "btnDashMenu";
            this.btnDashMenu.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDashMenu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDashMenu.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDashMenu.OnHoverImage = null;
            this.btnDashMenu.OnPressedColor = System.Drawing.Color.Black;
            this.btnDashMenu.Size = new System.Drawing.Size(336, 100);
            this.btnDashMenu.TabIndex = 4;
            this.btnDashMenu.Text = "Dashboard Menu";
            this.btnDashMenu.Click += new System.EventHandler(this.btnDashMenu_Click);
            // 
            // panSaidMenu
            // 
            this.panSaidMenu.Controls.Add(this.btnReport);
            this.panSaidMenu.Controls.Add(this.btnUsers);
            this.panSaidMenu.Controls.Add(this.btnLogout);
            this.panSaidMenu.Controls.Add(this.btnProducts);
            this.panSaidMenu.Controls.Add(this.btnCategories);
            this.panSaidMenu.Controls.Add(this.btnSuppliers);
            this.panSaidMenu.Controls.Add(this.btnInventory);
            this.panSaidMenu.Controls.Add(this.brnSales);
            this.panSaidMenu.Location = new System.Drawing.Point(3, 200);
            this.panSaidMenu.Name = "panSaidMenu";
            this.panSaidMenu.Size = new System.Drawing.Size(331, 633);
            this.panSaidMenu.TabIndex = 4;
            // 
            // btnReport
            // 
            this.btnReport.AnimationHoverSpeed = 0.07F;
            this.btnReport.AnimationSpeed = 0.03F;
            this.btnReport.BackColor = System.Drawing.Color.Transparent;
            this.btnReport.BaseColor1 = System.Drawing.Color.SpringGreen;
            this.btnReport.BaseColor2 = System.Drawing.Color.Green;
            this.btnReport.BorderColor = System.Drawing.Color.Black;
            this.btnReport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReport.FocusedColor = System.Drawing.Color.Empty;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Image = global::POS_SYSTEM_Project.Properties.Resources.report__1_;
            this.btnReport.ImageSize = new System.Drawing.Size(45, 45);
            this.btnReport.Location = new System.Drawing.Point(0, 387);
            this.btnReport.Name = "btnReport";
            this.btnReport.OnHoverBaseColor1 = System.Drawing.Color.Lime;
            this.btnReport.OnHoverBaseColor2 = System.Drawing.Color.DarkOliveGreen;
            this.btnReport.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReport.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReport.OnHoverImage = null;
            this.btnReport.OnPressedColor = System.Drawing.Color.Black;
            this.btnReport.Radius = 20;
            this.btnReport.Size = new System.Drawing.Size(296, 59);
            this.btnReport.TabIndex = 11;
            this.btnReport.Text = "Reports";
            // 
            // btnUsers
            // 
            this.btnUsers.AnimationHoverSpeed = 0.07F;
            this.btnUsers.AnimationSpeed = 0.03F;
            this.btnUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnUsers.BaseColor1 = System.Drawing.Color.SpringGreen;
            this.btnUsers.BaseColor2 = System.Drawing.Color.Green;
            this.btnUsers.BorderColor = System.Drawing.Color.Black;
            this.btnUsers.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUsers.FocusedColor = System.Drawing.Color.Empty;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Image = global::POS_SYSTEM_Project.Properties.Resources.multiple_users;
            this.btnUsers.ImageSize = new System.Drawing.Size(45, 45);
            this.btnUsers.Location = new System.Drawing.Point(0, 464);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.OnHoverBaseColor1 = System.Drawing.Color.Lime;
            this.btnUsers.OnHoverBaseColor2 = System.Drawing.Color.DarkOliveGreen;
            this.btnUsers.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUsers.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUsers.OnHoverImage = null;
            this.btnUsers.OnPressedColor = System.Drawing.Color.Black;
            this.btnUsers.Radius = 20;
            this.btnUsers.Size = new System.Drawing.Size(296, 59);
            this.btnUsers.TabIndex = 10;
            this.btnUsers.Text = "Users";
            // 
            // btnLogout
            // 
            this.btnLogout.AnimationHoverSpeed = 0.07F;
            this.btnLogout.AnimationSpeed = 0.03F;
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BaseColor1 = System.Drawing.Color.SpringGreen;
            this.btnLogout.BaseColor2 = System.Drawing.Color.Green;
            this.btnLogout.BorderColor = System.Drawing.Color.Black;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogout.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::POS_SYSTEM_Project.Properties.Resources.sign_in2;
            this.btnLogout.ImageSize = new System.Drawing.Size(45, 45);
            this.btnLogout.Location = new System.Drawing.Point(3, 564);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.OnHoverBaseColor1 = System.Drawing.Color.Lime;
            this.btnLogout.OnHoverBaseColor2 = System.Drawing.Color.DarkOliveGreen;
            this.btnLogout.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogout.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogout.OnHoverImage = null;
            this.btnLogout.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogout.Radius = 20;
            this.btnLogout.Size = new System.Drawing.Size(296, 59);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            // 
            // btnProducts
            // 
            this.btnProducts.AnimationHoverSpeed = 0.07F;
            this.btnProducts.AnimationSpeed = 0.03F;
            this.btnProducts.BackColor = System.Drawing.Color.Transparent;
            this.btnProducts.BaseColor1 = System.Drawing.Color.SpringGreen;
            this.btnProducts.BaseColor2 = System.Drawing.Color.Green;
            this.btnProducts.BorderColor = System.Drawing.Color.Black;
            this.btnProducts.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnProducts.FocusedColor = System.Drawing.Color.Empty;
            this.btnProducts.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.Color.White;
            this.btnProducts.Image = global::POS_SYSTEM_Project.Properties.Resources.market_segmentation2__1_;
            this.btnProducts.ImageSize = new System.Drawing.Size(45, 45);
            this.btnProducts.Location = new System.Drawing.Point(0, 89);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.OnHoverBaseColor1 = System.Drawing.Color.Lime;
            this.btnProducts.OnHoverBaseColor2 = System.Drawing.Color.DarkOliveGreen;
            this.btnProducts.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnProducts.OnHoverForeColor = System.Drawing.Color.White;
            this.btnProducts.OnHoverImage = null;
            this.btnProducts.OnPressedColor = System.Drawing.Color.Black;
            this.btnProducts.Radius = 20;
            this.btnProducts.Size = new System.Drawing.Size(296, 59);
            this.btnProducts.TabIndex = 8;
            this.btnProducts.Text = "Products";
            // 
            // btnCategories
            // 
            this.btnCategories.AnimationHoverSpeed = 0.07F;
            this.btnCategories.AnimationSpeed = 0.03F;
            this.btnCategories.BackColor = System.Drawing.Color.Transparent;
            this.btnCategories.BaseColor1 = System.Drawing.Color.SpringGreen;
            this.btnCategories.BaseColor2 = System.Drawing.Color.Green;
            this.btnCategories.BorderColor = System.Drawing.Color.Black;
            this.btnCategories.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCategories.FocusedColor = System.Drawing.Color.Empty;
            this.btnCategories.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategories.ForeColor = System.Drawing.Color.White;
            this.btnCategories.Image = global::POS_SYSTEM_Project.Properties.Resources.inventory_category2__1_;
            this.btnCategories.ImageSize = new System.Drawing.Size(45, 45);
            this.btnCategories.Location = new System.Drawing.Point(0, 164);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.OnHoverBaseColor1 = System.Drawing.Color.Lime;
            this.btnCategories.OnHoverBaseColor2 = System.Drawing.Color.DarkOliveGreen;
            this.btnCategories.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCategories.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCategories.OnHoverImage = null;
            this.btnCategories.OnPressedColor = System.Drawing.Color.Black;
            this.btnCategories.Radius = 20;
            this.btnCategories.Size = new System.Drawing.Size(296, 59);
            this.btnCategories.TabIndex = 7;
            this.btnCategories.Text = "Categories";
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.AnimationHoverSpeed = 0.07F;
            this.btnSuppliers.AnimationSpeed = 0.03F;
            this.btnSuppliers.BackColor = System.Drawing.Color.Transparent;
            this.btnSuppliers.BaseColor1 = System.Drawing.Color.SpringGreen;
            this.btnSuppliers.BaseColor2 = System.Drawing.Color.Green;
            this.btnSuppliers.BorderColor = System.Drawing.Color.Black;
            this.btnSuppliers.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSuppliers.FocusedColor = System.Drawing.Color.Empty;
            this.btnSuppliers.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppliers.ForeColor = System.Drawing.Color.White;
            this.btnSuppliers.Image = global::POS_SYSTEM_Project.Properties.Resources.truck__1_;
            this.btnSuppliers.ImageSize = new System.Drawing.Size(45, 45);
            this.btnSuppliers.Location = new System.Drawing.Point(0, 238);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.OnHoverBaseColor1 = System.Drawing.Color.Lime;
            this.btnSuppliers.OnHoverBaseColor2 = System.Drawing.Color.DarkOliveGreen;
            this.btnSuppliers.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSuppliers.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSuppliers.OnHoverImage = null;
            this.btnSuppliers.OnPressedColor = System.Drawing.Color.Black;
            this.btnSuppliers.Radius = 20;
            this.btnSuppliers.Size = new System.Drawing.Size(296, 59);
            this.btnSuppliers.TabIndex = 6;
            this.btnSuppliers.Text = "Suppliers";
            // 
            // btnInventory
            // 
            this.btnInventory.AnimationHoverSpeed = 0.07F;
            this.btnInventory.AnimationSpeed = 0.03F;
            this.btnInventory.BackColor = System.Drawing.Color.Transparent;
            this.btnInventory.BaseColor1 = System.Drawing.Color.SpringGreen;
            this.btnInventory.BaseColor2 = System.Drawing.Color.Green;
            this.btnInventory.BorderColor = System.Drawing.Color.Black;
            this.btnInventory.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnInventory.FocusedColor = System.Drawing.Color.Empty;
            this.btnInventory.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Image = global::POS_SYSTEM_Project.Properties.Resources.project_server;
            this.btnInventory.ImageSize = new System.Drawing.Size(45, 45);
            this.btnInventory.Location = new System.Drawing.Point(0, 312);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.OnHoverBaseColor1 = System.Drawing.Color.Lime;
            this.btnInventory.OnHoverBaseColor2 = System.Drawing.Color.DarkOliveGreen;
            this.btnInventory.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnInventory.OnHoverForeColor = System.Drawing.Color.White;
            this.btnInventory.OnHoverImage = null;
            this.btnInventory.OnPressedColor = System.Drawing.Color.Black;
            this.btnInventory.Radius = 20;
            this.btnInventory.Size = new System.Drawing.Size(296, 59);
            this.btnInventory.TabIndex = 5;
            this.btnInventory.Text = "Inventory";
            // 
            // brnSales
            // 
            this.brnSales.AnimationHoverSpeed = 0.07F;
            this.brnSales.AnimationSpeed = 0.03F;
            this.brnSales.BackColor = System.Drawing.Color.Transparent;
            this.brnSales.BaseColor1 = System.Drawing.Color.SpringGreen;
            this.brnSales.BaseColor2 = System.Drawing.Color.Green;
            this.brnSales.BorderColor = System.Drawing.Color.Black;
            this.brnSales.DialogResult = System.Windows.Forms.DialogResult.None;
            this.brnSales.FocusedColor = System.Drawing.Color.Empty;
            this.brnSales.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnSales.ForeColor = System.Drawing.Color.White;
            this.brnSales.Image = global::POS_SYSTEM_Project.Properties.Resources.market_segmentation2;
            this.brnSales.ImageSize = new System.Drawing.Size(45, 45);
            this.brnSales.Location = new System.Drawing.Point(0, 13);
            this.brnSales.Name = "brnSales";
            this.brnSales.OnHoverBaseColor1 = System.Drawing.Color.Lime;
            this.brnSales.OnHoverBaseColor2 = System.Drawing.Color.DarkOliveGreen;
            this.brnSales.OnHoverBorderColor = System.Drawing.Color.Black;
            this.brnSales.OnHoverForeColor = System.Drawing.Color.White;
            this.brnSales.OnHoverImage = null;
            this.brnSales.OnPressedColor = System.Drawing.Color.Black;
            this.brnSales.Radius = 20;
            this.brnSales.Size = new System.Drawing.Size(296, 59);
            this.brnSales.TabIndex = 4;
            this.brnSales.Text = "Salse";
            this.brnSales.Click += new System.EventHandler(this.brnSales_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblTime);
            this.panel2.Controls.Add(this.gunaLabel6);
            this.panel2.Controls.Add(this.gunaLabel5);
            this.panel2.Controls.Add(this.lblDateToday);
            this.panel2.Controls.Add(this.lblNamerole);
            this.panel2.Controls.Add(this.gunaLabel3);
            this.panel2.Controls.Add(this.lblNameuser);
            this.panel2.Controls.Add(this.gunaLabel2);
            this.panel2.Location = new System.Drawing.Point(340, 807);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1013, 39);
            this.panel2.TabIndex = 5;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Black;
            this.lblTime.Location = new System.Drawing.Point(682, 4);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(61, 28);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "00:00";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel6.Location = new System.Drawing.Point(614, -1);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(98, 38);
            this.gunaLabel6.TabIndex = 10;
            this.gunaLabel6.Text = "Time :";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel5.Location = new System.Drawing.Point(793, 4);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(95, 38);
            this.gunaLabel5.TabIndex = 7;
            this.gunaLabel5.Text = "Date :";
            // 
            // lblDateToday
            // 
            this.lblDateToday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateToday.AutoSize = true;
            this.lblDateToday.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDateToday.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateToday.ForeColor = System.Drawing.Color.Black;
            this.lblDateToday.Location = new System.Drawing.Point(866, 11);
            this.lblDateToday.Name = "lblDateToday";
            this.lblDateToday.Size = new System.Drawing.Size(102, 28);
            this.lblDateToday.TabIndex = 9;
            this.lblDateToday.Text = "12/2/2026";
            // 
            // lblNamerole
            // 
            this.lblNamerole.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNamerole.AutoSize = true;
            this.lblNamerole.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNamerole.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamerole.ForeColor = System.Drawing.Color.Black;
            this.lblNamerole.Location = new System.Drawing.Point(433, 3);
            this.lblNamerole.Name = "lblNamerole";
            this.lblNamerole.Size = new System.Drawing.Size(92, 28);
            this.lblNamerole.TabIndex = 8;
            this.lblNamerole.Text = "manager";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel3.Location = new System.Drawing.Point(351, -1);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(98, 38);
            this.gunaLabel3.TabIndex = 7;
            this.gunaLabel3.Text = "Role : ";
            // 
            // lblNameuser
            // 
            this.lblNameuser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNameuser.AutoSize = true;
            this.lblNameuser.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNameuser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameuser.ForeColor = System.Drawing.Color.Black;
            this.lblNameuser.Location = new System.Drawing.Point(84, 6);
            this.lblNameuser.Name = "lblNameuser";
            this.lblNameuser.Size = new System.Drawing.Size(78, 28);
            this.lblNameuser.TabIndex = 7;
            this.lblNameuser.Text = "Ahmed";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(6, -1);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(91, 38);
            this.gunaLabel2.TabIndex = 6;
            this.gunaLabel2.Text = "User :";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel4.Location = new System.Drawing.Point(1087, 9);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(144, 28);
            this.gunaLabel4.TabIndex = 8;
            this.gunaLabel4.Text = "Welcom back,";
            // 
            // lblNameWelcome
            // 
            this.lblNameWelcome.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNameWelcome.AutoSize = true;
            this.lblNameWelcome.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNameWelcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameWelcome.ForeColor = System.Drawing.Color.Black;
            this.lblNameWelcome.Location = new System.Drawing.Point(1206, 9);
            this.lblNameWelcome.Name = "lblNameWelcome";
            this.lblNameWelcome.Size = new System.Drawing.Size(79, 28);
            this.lblNameWelcome.TabIndex = 9;
            this.lblNameWelcome.Text = "Ahmed";
            // 
            // PanMain
            // 
            this.PanMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PanMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.PanMain.Location = new System.Drawing.Point(340, 71);
            this.PanMain.Name = "PanMain";
            this.PanMain.Size = new System.Drawing.Size(1011, 737);
            this.PanMain.TabIndex = 10;
            // 
            // TimerDateToDay
            // 
            this.TimerDateToDay.Interval = 1000;
            this.TimerDateToDay.Tick += new System.EventHandler(this.TimerDateToDay_Tick);
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Cursor = System.Windows.Forms.Cursors.Default;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel7.Location = new System.Drawing.Point(701, 9);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(352, 59);
            this.gunaLabel7.TabIndex = 11;
            this.gunaLabel7.Text = "Dashboard Menu";
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Cursor = System.Windows.Forms.Cursors.Default;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel8.Location = new System.Drawing.Point(1073, 40);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(59, 28);
            this.gunaLabel8.TabIndex = 12;
            this.gunaLabel8.Text = "Role:";
            // 
            // ibiRoleName2
            // 
            this.ibiRoleName2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ibiRoleName2.AutoSize = true;
            this.ibiRoleName2.Cursor = System.Windows.Forms.Cursors.Default;
            this.ibiRoleName2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibiRoleName2.ForeColor = System.Drawing.Color.Black;
            this.ibiRoleName2.Location = new System.Drawing.Point(1117, 40);
            this.ibiRoleName2.Name = "ibiRoleName2";
            this.ibiRoleName2.Size = new System.Drawing.Size(74, 28);
            this.ibiRoleName2.TabIndex = 13;
            this.ibiRoleName2.Text = "Admin";
            // 
            // lblTopTime
            // 
            this.lblTopTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTopTime.AutoSize = true;
            this.lblTopTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTopTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopTime.ForeColor = System.Drawing.Color.Black;
            this.lblTopTime.Location = new System.Drawing.Point(1226, 40);
            this.lblTopTime.Name = "lblTopTime";
            this.lblTopTime.Size = new System.Drawing.Size(104, 28);
            this.lblTopTime.TabIndex = 14;
            this.lblTopTime.Text = "06:22 AM";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1342, 843);
            this.Controls.Add(this.lblTopTime);
            this.Controls.Add(this.ibiRoleName2);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.PanMain);
            this.Controls.Add(this.lblNameWelcome);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panLeft);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmMain_Activated);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panLeft.ResumeLayout(false);
            this.panLeft.PerformLayout();
            this.panSaidMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PanMain.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panSalesToday.ResumeLayout(false);
            this.panSalesToday.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panSalesToday.ResumeLayout(false);
            this.panSalesToday.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panSalesToday.ResumeLayout(false);
            this.panSalesToday.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panSalesToday.ResumeLayout(false);
            this.panSalesToday.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panSalesToday.ResumeLayout(false);
            this.panSalesToday.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panSalesToday.ResumeLayout(false);
            this.panSalesToday.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panSalesToday.ResumeLayout(false);
            this.panSalesToday.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panSalesToday.ResumeLayout(false);
            this.panSalesToday.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panSalesToday.ResumeLayout(false);
            this.panSalesToday.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panSalesToday.ResumeLayout(false);
            this.panSalesToday.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panSalesToday.ResumeLayout(false);
            this.panSalesToday.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panSalesToday.ResumeLayout(false);
            this.panSalesToday.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Panel panLeft;
        private Guna.UI.WinForms.GunaTileButton btnDashMenu;
        private System.Windows.Forms.Panel panSaidMenu;
        private Guna.UI.WinForms.GunaGradientButton brnSales;
        private Guna.UI.WinForms.GunaGradientButton btnProducts;
        private Guna.UI.WinForms.GunaGradientButton btnCategories;
        private Guna.UI.WinForms.GunaGradientButton btnSuppliers;
        private Guna.UI.WinForms.GunaGradientButton btnInventory;
        private Guna.UI.WinForms.GunaGradientButton btnReport;
        private Guna.UI.WinForms.GunaGradientButton btnUsers;
        private Guna.UI.WinForms.GunaGradientButton btnLogout;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel lblNamerole;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel lblNameuser;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel lblDateToday;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel lblNameWelcome;
        private System.Windows.Forms.Panel PanMain;
        private Guna.UI.WinForms.GunaLabel lblTime;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private System.Windows.Forms.Timer TimerDateToDay;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel ibiRoleName2;
        private Guna.UI.WinForms.GunaLabel lblTopTime;
    }
}