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

namespace POS_SYSTEM_Project
{
    public partial class frmLogin : Form
    {
       private string _UserName = "", _Passward = "";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtPassward.UseSystemPasswordChar = true;

            if (clsGlobal.GetStoredCredential(ref  _UserName, ref _Passward))
            {
                txtUserName.Text = _UserName;
                txtPassward.Text = _Passward;

                chebRemember.Checked=true;
            }
            else
            {
                chebRemember.Checked= false;
            }
        }

        private void btnSignIN_Click(object sender, EventArgs e)
        {
            clsUsers User=clsUsers.FindUserByUserNameAndPassord(txtUserName.Text.Trim(),txtPassward.Text.Trim());

            if (User != null)
            {
                if(chebRemember.Checked)
                {
                    clsGlobal.RememberUsernameAndPassword(txtUserName.Text.Trim(),txtPassward.Text.Trim());
                }
                else
                {
                    clsGlobal.RememberUsernameAndPassword("", "");
                }
                if (!User.IsActive)
                {
                    txtUserName.Focus();

                    MessageBox.Show("Your accountant is not active!","In Active accountant",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                clsGlobal.Currentuser = User;

                frmMain frm = new frmMain();
                frm.ShowDialog();
                this.Close();
               
            }
            else
            {
                txtUserName.Focus();

                lblMessageError.Visible = true;
                return;
            }

            
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Activated(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            txtPassward.UseSystemPasswordChar = !txtPassward.UseSystemPasswordChar;
        }
    }
}
