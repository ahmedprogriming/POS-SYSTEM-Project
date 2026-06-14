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
    public partial class SuppliersList : Form
    {
        DataTable dtsupplier;
        private frmMain _frmMain;
        public SuppliersList(frmMain frmMain)
        {
            InitializeComponent();
            _frmMain = frmMain;
        }

        private void SuppliersList_Load(object sender, EventArgs e)
        {
            lblNameUser.Text = clsGlobal.Currentuser.FullName;
            lblRoleName.Text = clsGlobal.ReturnNameRole();

            dtsupplier = clsSupplier.GetAllSupplier();
            dgvSuppliersList.DataSource = dtsupplier;
            cobFilter.SelectedIndex = 0;
            lblRecordes.Text = dtsupplier.Rows.Count.ToString();

            if (dgvSuppliersList.Rows.Count > 0)
            {
                dgvSuppliersList.Columns[0].HeaderText = "ID";
                dgvSuppliersList.Columns[0].Width = 90;

                dgvSuppliersList.Columns[1].HeaderText = "Supplier Name";
                dgvSuppliersList.Columns[1].Width = 150;

                dgvSuppliersList.Columns[2].HeaderText = "Phone";
                dgvSuppliersList.Columns[2].Width = 150;

                dgvSuppliersList.Columns[3].HeaderText = "Email";
                dgvSuppliersList.Columns[3].Width = 150;

                dgvSuppliersList.Columns[4].HeaderText = "Address";
                dgvSuppliersList.Columns[4].Width = 200;



            }

            dgvSuppliersList.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
            dgvSuppliersList.EnableHeadersVisualStyles = false;

            dgvSuppliersList.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);
        }

        private void txbFilter_TextChanged(object sender, EventArgs e)
        {
            string filtering = "";

            switch (cobFilter.Text)
            {
                case "Supplier ID":
                    filtering = "SupplierID";
                    break;
                case "Supplier Name":
                    filtering = "SupplierName";
                    break;
                case "Email":
                    filtering = "Email";
                    break; 
                default:
                    filtering = "None";
                    break;

            }

            if (txbFilter.Text == "" || filtering == "None")
            {
                dtsupplier.DefaultView.RowFilter = "";
                lblRecordes.Text = dtsupplier.Rows.Count.ToString();

                return;
            }

            if (filtering == "SupplierID")

                dtsupplier.DefaultView.RowFilter = string.Format("[{0}] = {1}", filtering, txbFilter.Text.Trim());
            else
                dtsupplier.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", filtering, txbFilter.Text.Trim());

            lblRecordes.Text = dtsupplier.Rows.Count.ToString();
        }

        private void txbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cobFilter.Text == "Supplier ID")
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmAddNewSuppliers frm=new frmAddNewSuppliers((int)dgvSuppliersList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            SuppliersList_Load(null, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
             if (MessageBox.Show("Do you sure of Delete this Supplier?", "Confirm Opition", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                if (!clsProduct.DeleteProduct((int)dgvSuppliersList.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Not Deleted Supplier..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Delete Supplier successsfuly!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            SuppliersList_Load(null, null);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            _frmMain.DefultShaw();
        }
    }
}
