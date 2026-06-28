using Busisns_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Busisns_Layer.clsUsers;

namespace POS_SYSTEM_Project
{
    public partial class frmEdit_AddUsers : Form
    {
        clsUsers _Userobj;

        int _UserID = -1;

        private enum _enMode { Addnew = 1, Update = 2 };

        _enMode Mode = _enMode.Addnew;
        public frmEdit_AddUsers()
        {
            InitializeComponent();
            Mode = _enMode.Addnew;
        }

        public frmEdit_AddUsers(int id)
        {
            InitializeComponent();
            _UserID = id;
            Mode = _enMode.Update;
        }

        private void _ReasultDefult()
        {

            if (Mode == _enMode.Addnew)
            {
                lblTitle.Text = "Add New User";
                _Userobj = new clsUsers();
            }

            else
            {
                lblTitle.Text = "Updte User";
            }

            lblUserID.Text = "[????]";
            txtUserName.Text = "";
            txtFullName.Text = "";
            cobRole.SelectedIndex = 0;
            txtPassWord.Text = "";
            txtConfirmPassword.Text = "";

        }

        private static string _GetNameRole(int role)
        {
            switch (role)
            {
                case 1:
                    return "Admin";

                case 2:
                    return "Manager";

                case 3:
                    return "Cashier";
                default:
                    return "Null";
            }
        }

        private void LoadData()
        {

            _Userobj = clsUsers.GetUserByID(_UserID);

            if (_Userobj == null)
            {
                MessageBox.Show("Error", "This User is Null!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblUserID.Text = _UserID.ToString();
            txtUserName.Text = _Userobj.Username;
            txtFullName.Text = _Userobj.FullName;
            cobRole.Text = _GetNameRole(_Userobj.RoleID);
            txtPassWord.Text = _Userobj.Password;
            txtConfirmPassword.Text = _Userobj.Password;


        }
        private void frmEdit_AddUsers_Load(object sender, EventArgs e)
        {
            _ReasultDefult();

            if (Mode == _enMode.Update)
            {
                LoadData();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you sure of save this user?", "Confirm Opition", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (!this.ValidateChildren())
                {
                    MessageBox.Show("Some fields are not valid, put the mouse over the red icon", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _Userobj.UserID = _UserID;
                _Userobj.Username = txtUserName.Text;
                _Userobj.FullName = txtFullName.Text;
                _Userobj.RoleID = clsUsers.GetIDRole(cobRole.Text);
                _Userobj.Password = txtPassWord.Text;



                if (!_Userobj.Save())
                {
                  
                    MessageBox.Show("Not Saved..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("User save successfuly", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblUserID.Text = _Userobj.UserID.ToString();
            }
        }

        private void HandelTxtbox(TextBox textBox, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox, "This filed is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(textBox, null);
            }
        }

        private void txtFullName_Validating(object sender, CancelEventArgs e)
        {
            HandelTxtbox(txtFullName, e);
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            HandelTxtbox(txtUserName, e);
        }

        private void txtPassWord_Validating(object sender, CancelEventArgs e)
        {
            HandelTxtbox(txtPassWord, e);
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            HandelTxtbox(txtConfirmPassword, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
