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
    public partial class frmManagerUsers : Form
    {
        private DataTable Usersdt;
        private frmMain _frmMain;
        public frmManagerUsers(frmMain frm)
        {
            InitializeComponent();
            _frmMain = frm;
        }

        private void frmManagerUsers_Load(object sender, EventArgs e)
        {
            lblNameUser.Text = clsGlobal.Currentuser.FullName;
            lblRoleName.Text = clsGlobal.ReturnNameRole();

            Usersdt = clsUsers.GetAllUsers();
            dgvUsersList.DataSource = Usersdt;
            cobFilter.SelectedIndex = 0;
            lblRecordes.Text = dgvUsersList.Rows.Count.ToString();

            if (dgvUsersList.Rows.Count > 0)
            {
                dgvUsersList.Columns[0].HeaderText = "ID";
                dgvUsersList.Columns[0].Width = 90;

                dgvUsersList.Columns[1].HeaderText = "Full Name";
                dgvUsersList.Columns[1].Width = 200;

                dgvUsersList.Columns[2].HeaderText = "UserName";
                dgvUsersList.Columns[2].Width = 120;

                dgvUsersList.Columns[3].HeaderText = "Role";
                dgvUsersList.Columns[3].Width = 100;

                dgvUsersList.Columns[4].HeaderText = "IsActive";
                dgvUsersList.Columns[4].Width = 90;

                dgvUsersList.Columns[5].HeaderText = "Created At";
                dgvUsersList.Columns[5].Width = 150;

              

            }

            dgvUsersList.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
            dgvUsersList.EnableHeadersVisualStyles = false;

            dgvUsersList.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);
        }

        private void txbFilter_TextChanged(object sender, EventArgs e)
        {
            string filtering = "";

            switch (cobFilter.Text)
            {
                case "User ID":
                    filtering = "UserID";
                    break;
                case "User Name":
                    filtering = "UserName";
                    break;
                case "Role":
                     filtering = "RoleName";
                    break;
                default:
                    filtering = "None";
                    break;

            }

            if (txbFilter.Text == "" || filtering == "None")
            {
                Usersdt.DefaultView.RowFilter = "";
                lblRecordes.Text = dgvUsersList.Rows.Count.ToString();

                return;
            }

            if (filtering == "UserID")

                Usersdt.DefaultView.RowFilter = string.Format("[{0}] = {1}", filtering, txbFilter.Text.Trim());
            else
                Usersdt.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", filtering, txbFilter.Text.Trim());

            lblRecordes.Text = dgvUsersList.Rows.Count.ToString();
        }

        private void txbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cobFilter.Text == "User ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cobFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbFilter.Visible = (cobFilter.Text != "None");

            if (txbFilter.Visible)
            {
                txbFilter.Text = "";
                txbFilter.Focus();
            }

         
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            frmEdit_AddUsers frm = new frmEdit_AddUsers();
            frm.ShowDialog();
            frmManagerUsers_Load(null, null);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmEdit_AddUsers frm = new frmEdit_AddUsers((int)dgvUsersList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmManagerUsers_Load(null, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you sure of DeActive this User?", "Confirm Opition", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                if (!clsUsers.Deleted((int)dgvUsersList.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Not deActive User..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("DeActive User successsfuly!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            frmManagerUsers_Load(null, null);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

            _frmMain.DefultShaw();
        }
    }
}
