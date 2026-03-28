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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace POS_SYSTEM_Project
{
    public partial class frmPOSSales : Form
    {
       private string Barcode="";
        private int Qyt = -1;
        public frmPOSSales()
        {
            InitializeComponent();
        }

        private void frmPOSSales_Load(object sender, EventArgs e)
        {
            DataTable dtListPoduct = new DataTable();
            dtListPoduct = clsProduct.GetPartProduct();

            dgvProductList.DataSource = dtListPoduct;
            if (dgvProductList.Rows.Count > 0)
            {
                dgvProductList.Columns[0].HeaderText = "Product";
                dgvProductList.Columns[0].Width = 150;

                dgvProductList.Columns[1].Width = 60;
                dgvProductList.Columns[2].HeaderText = "Price";
                dgvProductList.Columns[2].Width = 50;
         
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
          

            if (!clsProduct.IsProductAvailable(txtNameProduct.Text.Trim(), txtBarcode.Text.Trim()))
            {
              MessageBox.Show("This product is not Found.","Not Fond",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtNameProduct_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtNameProduct.Text.Trim()))
            {
                //e.Cancel = true;
                errorSearchProduct.SetError(txtNameProduct, "This filed is rquired!");
                return;
            }
            else
            {
                //e.Cancel = false ;
                errorSearchProduct.SetError(txtNameProduct, null);
            }
        }

        private void txtBarcode_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBarcode.Text.Trim()))
            {
               // e.Cancel = true;
                errorSearchProduct.SetError(txtBarcode, "This filed is rquired!");
                return;
            }
            else
            {
               // e.Cancel = false;
                errorSearchProduct.SetError(txtBarcode, null);
            }
        }

        private void btnCleaar_Click(object sender, EventArgs e)
        {
            txtBarcode.Text = "";
            txtNameProduct.Text = "";
            numQuantity.Minimum = 0;
            numQuantity.Value = 0;
        }

         private void CalculateInvoice()
        {
            decimal SubTotal = 0m;
            decimal DisCount = 0m;
            decimal Tax = 0m;
            decimal FinalTotal = 0m;

            foreach(DataGridViewRow row in dgvCart.Rows)
            {
                if (row.IsNewRow)
                    continue;

                if (row.Cells[0].Value != null)
                {
                    SubTotal += Convert.ToDecimal(row.Cells[3].Value);
                }
                // مثال ضريبة 15%
                Tax = (SubTotal - DisCount) * 0.15m;
                FinalTotal = (SubTotal - DisCount) + Tax;

                lblsubtotal.Text = SubTotal.ToString("0.00") + " $";
                lblDisCount.Text = DisCount.ToString("0.00") + " $";
                lblTax.Text = Tax.ToString("0.00") + " $";
                lblTotal.Text = FinalTotal.ToString("0.00") + " $";

            }
        }

        private void AddItemToInvice()
        {
            clsProduct addProduct= new clsProduct();
            Qyt =Convert.ToInt32( numQuantity.Value);
            Barcode = txtBarcode.Text.Trim();

            addProduct=clsProduct.GetProductByBarcode(Barcode);

            if (addProduct == null)
            {
                MessageBox.Show("This object is null!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvCart.Rows.Add
                (
                addProduct.ProductName,
                Qyt,
                addProduct.SellingPrice,
                Qyt * addProduct.SellingPrice

                );

            CalculateInvoice();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddItemToInvice();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvCart.CurrentRow != null && dgvCart.CurrentRow.IsNewRow)
            {

                dgvCart.Rows.RemoveAt(dgvCart.CurrentRow.Index);
            }
            else
            {
                MessageBox.Show("Select row the correct first!");
            }
        }
    }
}