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
    public partial class frmCategoryList : Form
    {
        private DataTable Categorydt;
        private frmMain _frmMain;
        public frmCategoryList(frmMain frm)
        {
            InitializeComponent();

            _frmMain = frm;
        }

        private void CategoryList_Load(object sender, EventArgs e)
        {
            lblNameUser.Text = clsGlobal.Currentuser.FullName;
            lblRoleName.Text = clsGlobal.ReturnNameRole();

            Categorydt =clsCategory.GetAllCategries();
            dgvCategoryList.DataSource = Categorydt;
            cobFilter.SelectedIndex = 0;
            lblRecordes.Text = dgvCategoryList.Rows.Count.ToString();

            if (dgvCategoryList.Rows.Count > 0)
            {
                dgvCategoryList.Columns[0].HeaderText = "ID";
                dgvCategoryList.Columns[0].Width = 150;

                dgvCategoryList.Columns[1].HeaderText = "Category Name";
                dgvCategoryList.Columns[1].Width = 200;

                dgvCategoryList.Columns[2].HeaderText = "Description";
                dgvCategoryList.Columns[2].Width = 200;

              

            }

            dgvCategoryList.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
            dgvCategoryList.EnableHeadersVisualStyles = false;

            dgvCategoryList.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);
        }

        private void txbFilter_TextChanged(object sender, EventArgs e)
        {
            string filtering = "";

            switch (cobFilter.Text)
            {
                case "Category ID":
                    filtering = "CategoryID";
                    break;
                case "Category Name":
                    filtering = "CategoryName";
                    break;
                default:
                    filtering = "None";
                    break;

            }

            if (txbFilter.Text == "" || filtering == "None")
            {
                Categorydt.DefaultView.RowFilter = "";
                lblRecordes.Text = dgvCategoryList.Rows.Count.ToString();

                return;
            }

            if (filtering == "CategoryID")

                Categorydt.DefaultView.RowFilter = string.Format("[{0}] = {1}", filtering, txbFilter.Text.Trim());
            else
                Categorydt.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", filtering, txbFilter.Text.Trim());

            lblRecordes.Text = dgvCategoryList.Rows.Count.ToString();
        }

        private void txbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cobFilter.Text == "Category ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cobFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbFilter.Visible = (cobFilter.Text != "None");

            if(txbFilter.Visible)
            {
                txbFilter.Text = "";
                txbFilter.Focus();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AddEditCategory frm= new AddEditCategory((int)dgvCategoryList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            CategoryList_Load(null, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you sure of Delete this Categroies?", "Confirm Opition", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                if (!clsProduct.DeleteProduct((int)dgvCategoryList.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Not Deleted Categroies..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Delete Categroies successsfuly!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            CategoryList_Load(null, null);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

            _frmMain.DefultShaw();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            AddEditCategory frm = new AddEditCategory();
            frm.ShowDialog();
            CategoryList_Load(null, null);

        }
    }
}
