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
    public partial class frmInventory : Form
    {
        DataTable dtTracaction;
        private frmMain _frmMain;
        public frmInventory( frmMain frmMain)
        {
            InitializeComponent();
          
            _frmMain = frmMain;
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            lblNameUser.Text = clsGlobal.Currentuser.FullName;
            lblRoleName.Text = clsGlobal.ReturnNameRole();

            dtTracaction = clsInventoryTransaction.GetAllProccesSales();
            dgvInventoryList.DataSource = dtTracaction;
            cobFilter.SelectedIndex = 0;
            lblRecordes.Text = dtTracaction.Rows.Count.ToString();

            if (dgvInventoryList.Rows.Count > 0)
            {
                dgvInventoryList.Columns[0].HeaderText = "Product ID";
                dgvInventoryList.Columns[0].Width = 90;

                dgvInventoryList.Columns[1].HeaderText = "Product Name";
                dgvInventoryList.Columns[1].Width = 150;

                dgvInventoryList.Columns[2].HeaderText = "Category Name";
                dgvInventoryList.Columns[2].Width = 150;

                dgvInventoryList.Columns[3].HeaderText = "Current Stock";
                dgvInventoryList.Columns[3].Width = 150;

                dgvInventoryList.Columns[4].HeaderText = "MinimumStockLevel";
                dgvInventoryList.Columns[4].Width = 200;

                dgvInventoryList.Columns[5].HeaderText = "Stause";
                dgvInventoryList.Columns[5].Width = 100;



            }

            dgvInventoryList.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
            dgvInventoryList.EnableHeadersVisualStyles = false;

            dgvInventoryList.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);
        }

        private void txbFilter_TextChanged(object sender, EventArgs e)
        {
            string filtering = "";

            switch (cobFilter.Text)
            {
                case "Product ID":
                    filtering = "ProductID";
                    break;
                case "Stause":
                    filtering = "Stause";
                    break;
              
                default:
                    filtering = "None";
                    break;

            }

            if (txbFilter.Text == "" || filtering == "None")
            {
                dtTracaction.DefaultView.RowFilter = "";
                lblRecordes.Text = dtTracaction.Rows.Count.ToString();

                return;
            }

            if (filtering == "ProductID")

                dtTracaction.DefaultView.RowFilter = string.Format("[{0}] = {1}", filtering, txbFilter.Text.Trim());
            else
                dtTracaction.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", filtering, txbFilter.Text.Trim());

            lblRecordes.Text = dtTracaction.Rows.Count.ToString();
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

        private void txbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cobFilter.Text == "Product ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnhistory_Click(object sender, EventArgs e)
        {
            frmHistory frm =new frmHistory((int)dgvInventoryList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            _frmMain.DefultShaw();
        }
    }
}
