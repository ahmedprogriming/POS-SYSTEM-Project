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
    public partial class frmProductList : Form
    {
        private DataTable Productdt;
        private frmMain _frmMain;
        public frmProductList(frmMain defultForm)
        {
            InitializeComponent();
            _frmMain= defultForm;
        }

        private void frmProductList_Load(object sender, EventArgs e)
        {
            lblNameUser.Text = clsGlobal.Currentuser.FullName;
            lblRoleName.Text = clsGlobal.ReturnNameRole();

            Productdt= clsProduct.GetAllProduct();
            dgvProductList.DataSource = Productdt;
            cobFilter.SelectedIndex = 0;
            lblRecordes.Text=dgvProductList.Rows.Count.ToString();

            if (dgvProductList.Rows.Count > 0)
            {
                dgvProductList.Columns[0].HeaderText = "ID";
                dgvProductList.Columns[0].Width = 90;

                dgvProductList.Columns[1].HeaderText = "Product Name";
                dgvProductList.Columns[1].Width = 200;

                dgvProductList.Columns[2].HeaderText = "Barcode";
                dgvProductList.Columns[2].Width = 120;

                dgvProductList.Columns[3].HeaderText = "Categories";
                dgvProductList.Columns[3].Width = 100;

                dgvProductList.Columns[4].HeaderText = "Suppliers";
                dgvProductList.Columns[4].Width = 90;

                dgvProductList.Columns[5].HeaderText = "Cost Price";
                dgvProductList.Columns[5].Width = 100;

                dgvProductList.Columns[6].HeaderText = "Sell Price";
                dgvProductList.Columns[6].Width = 100;

                dgvProductList.Columns[7].HeaderText = "Quantity";
                dgvProductList.Columns[7].Width = 90;

                dgvProductList.Columns[8].HeaderText = "Min Stock";
                dgvProductList.Columns[8].Width = 90;

                dgvProductList.Columns[9].HeaderText = "IsActive";
                dgvProductList.Columns[9].Width = 100;


            }

            dgvProductList.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
            dgvProductList.EnableHeadersVisualStyles = false;

            dgvProductList.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);
        }


        private void txbFilter_TextChanged(object sender, EventArgs e)
        {
            string filtering = "";

            switch (cobFilter.Text)
            {
                case "ProductID":
                    filtering = "ProductID";
                    break;
                case "ProductName":
                    filtering = "ProductName";
                    break;
                default:
                    filtering = "None";
                    break;

            }

            if (txbFilter.Text == "" || filtering == "None")
            {
                Productdt.DefaultView.RowFilter = "";
                lblRecordes.Text = dgvProductList.Rows.Count.ToString();

                return;
            }

            if (filtering == "ProductID")

                Productdt.DefaultView.RowFilter = string.Format("[{0}] = {1}", filtering, txbFilter.Text.Trim());
            else
                Productdt.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", filtering, txbFilter.Text.Trim());

            lblRecordes.Text = dgvProductList.Rows.Count.ToString();
        }

        private void cobCategory_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "CategoryName";
            string Faltervalue = "";

            switch (cobCategory.Text)
            {
                case "Beverages":
                    Faltervalue = "Beverages";
                    break;
                case "Snacks":
                    Faltervalue = "Snacks";
                    break;
                case "Cleaning":
                    Faltervalue = "Cleaning";
                    break;
                default:
                    Faltervalue = "All";
                    break;

            }


            if ( Faltervalue == "All")
            
                Productdt.DefaultView.RowFilter = "";

            else

                Productdt.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FilterColumn, Faltervalue);
            lblRecordes.Text = dgvProductList.Rows.Count.ToString();

        }

        private void txbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( cobFilter.Text == "Product ID" )
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cobFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbFilter.Visible = (cobFilter.Text != "None" && cobFilter.Text != "Category");
            
            if(txbFilter.Visible)
            {
                txbFilter.Text = "";
                txbFilter.Focus();
            }

            cobCategory.Visible = (cobFilter.Text == "Category");

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmAddEditProduct frm=new frmAddEditProduct();
            frm.ShowDialog();
            frmProductList_Load(null, null);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmAddEditProduct frm = new frmAddEditProduct((int)dgvProductList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmProductList_Load(null, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you sure of Delete this product?", "Confirm Opition", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                if (!clsProduct.DeleteProduct((int)dgvProductList.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Not Deleted Product..","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Delete product successsfuly!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            frmProductList_Load(null, null);
        }

        private void btnViewDetailes_Click(object sender, EventArgs e)
        {
            frmDetailesProduct frm = new frmDetailesProduct((int)dgvProductList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

            _frmMain.DefultShaw();
        }

       
    }
}
