namespace POS_SYSTEM_Project
{
    partial class frmManagerUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panTop = new System.Windows.Forms.Panel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.lblRoleName = new Guna.UI.WinForms.GunaLabel();
            this.lblNameUser = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.lblRecordes = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.dgvUsersList = new System.Windows.Forms.DataGridView();
            this.cobFilter = new System.Windows.Forms.ComboBox();
            this.txbFilter = new System.Windows.Forms.TextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.btnClose = new Guna.UI.WinForms.GunaButton();
            this.btnEdit = new Guna.UI.WinForms.GunaButton();
            this.btnDelete = new Guna.UI.WinForms.GunaButton();
            this.panTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).BeginInit();
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
            this.panTop.Location = new System.Drawing.Point(2, 12);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(1015, 82);
            this.panTop.TabIndex = 2;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(914, 8);
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
            this.gunaLabel1.Location = new System.Drawing.Point(734, 8);
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
            this.lblRoleName.Location = new System.Drawing.Point(936, 15);
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
            this.lblNameUser.Location = new System.Drawing.Point(839, 15);
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
            this.gunaLabel7.Location = new System.Drawing.Point(20, 8);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(346, 59);
            this.gunaLabel7.TabIndex = 12;
            this.gunaLabel7.Text = "Users Magament";
            // 
            // lblRecordes
            // 
            this.lblRecordes.AutoSize = true;
            this.lblRecordes.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblRecordes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordes.ForeColor = System.Drawing.Color.Black;
            this.lblRecordes.Location = new System.Drawing.Point(129, 612);
            this.lblRecordes.Name = "lblRecordes";
            this.lblRecordes.Size = new System.Drawing.Size(48, 28);
            this.lblRecordes.TabIndex = 52;
            this.lblRecordes.Text = "????";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel4.Location = new System.Drawing.Point(27, 610);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(105, 28);
            this.gunaLabel4.TabIndex = 51;
            this.gunaLabel4.Text = "Recordes :";
            // 
            // dgvUsersList
            // 
            this.dgvUsersList.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsersList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsersList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersList.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvUsersList.Location = new System.Drawing.Point(28, 174);
            this.dgvUsersList.Name = "dgvUsersList";
            this.dgvUsersList.RowHeadersWidth = 51;
            this.dgvUsersList.RowTemplate.Height = 30;
            this.dgvUsersList.Size = new System.Drawing.Size(963, 433);
            this.dgvUsersList.TabIndex = 50;
            // 
            // cobFilter
            // 
            this.cobFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobFilter.FormattingEnabled = true;
            this.cobFilter.Items.AddRange(new object[] {
            "None",
            "User ID",
            "User Name",
            "Role"});
            this.cobFilter.Location = new System.Drawing.Point(134, 140);
            this.cobFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cobFilter.Name = "cobFilter";
            this.cobFilter.Size = new System.Drawing.Size(153, 24);
            this.cobFilter.TabIndex = 49;
            this.cobFilter.SelectedIndexChanged += new System.EventHandler(this.cobFilter_SelectedIndexChanged);
            // 
            // txbFilter
            // 
            this.txbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFilter.Location = new System.Drawing.Point(293, 140);
            this.txbFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbFilter.Name = "txbFilter";
            this.txbFilter.Size = new System.Drawing.Size(162, 27);
            this.txbFilter.TabIndex = 48;
            this.txbFilter.TextChanged += new System.EventHandler(this.txbFilter_TextChanged);
            this.txbFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbFilter_KeyPress);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel3.Location = new System.Drawing.Point(27, 133);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(110, 28);
            this.gunaLabel3.TabIndex = 47;
            this.gunaLabel3.Text = "Search By:";
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.BackColor = System.Drawing.Color.White;
            this.btnAddNewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewUser.Image = global::POS_SYSTEM_Project.Properties.Resources.Add_New_User_72;
            this.btnAddNewUser.Location = new System.Drawing.Point(913, 101);
            this.btnAddNewUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(78, 69);
            this.btnAddNewUser.TabIndex = 82;
            this.btnAddNewUser.UseVisualStyleBackColor = false;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
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
            this.btnClose.Location = new System.Drawing.Point(868, 616);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Radius = 10;
            this.btnClose.Size = new System.Drawing.Size(120, 40);
            this.btnClose.TabIndex = 56;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnEdit.Image = global::POS_SYSTEM_Project.Properties.Resources.edit_32;
            this.btnEdit.ImageSize = new System.Drawing.Size(18, 18);
            this.btnEdit.Location = new System.Drawing.Point(609, 616);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnEdit.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnEdit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEdit.OnHoverImage = null;
            this.btnEdit.OnPressedColor = System.Drawing.Color.Black;
            this.btnEdit.Radius = 10;
            this.btnEdit.Size = new System.Drawing.Size(110, 40);
            this.btnEdit.TabIndex = 54;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.btnDelete.Image = global::POS_SYSTEM_Project.Properties.Resources.Delete_32;
            this.btnDelete.ImageSize = new System.Drawing.Size(18, 18);
            this.btnDelete.Location = new System.Drawing.Point(725, 616);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelete.OnHoverImage = null;
            this.btnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelete.Radius = 10;
            this.btnDelete.Size = new System.Drawing.Size(110, 40);
            this.btnDelete.TabIndex = 53;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmManagerUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1022, 668);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblRecordes);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.dgvUsersList);
            this.Controls.Add(this.cobFilter);
            this.Controls.Add(this.txbFilter);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.panTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManagerUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManagerUsers";
            this.Load += new System.EventHandler(this.frmManagerUsers_Load);
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panTop;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel lblRoleName;
        private Guna.UI.WinForms.GunaLabel lblNameUser;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaButton btnClose;
        private Guna.UI.WinForms.GunaButton btnEdit;
        private Guna.UI.WinForms.GunaButton btnDelete;
        private Guna.UI.WinForms.GunaLabel lblRecordes;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private System.Windows.Forms.DataGridView dgvUsersList;
        private System.Windows.Forms.ComboBox cobFilter;
        private System.Windows.Forms.TextBox txbFilter;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private System.Windows.Forms.Button btnAddNewUser;
    }
}