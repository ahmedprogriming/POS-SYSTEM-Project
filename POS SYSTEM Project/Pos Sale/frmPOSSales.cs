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
        decimal SubTotal = 0m;
        decimal DisCount = 0m;
        decimal Tax = 0m;
        decimal FinalTotal = 0m;

        frmMain _frmMainAgain;
        public frmPOSSales(frmMain frmMainAgain)
        {
            InitializeComponent();
            _frmMainAgain = frmMainAgain;
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
                //e.Cancel = true;
                errorSearchProduct.SetError(txtBarcode, "This filed is rquired!");
                return;
            }
            else
            {
                //e.Cancel = false ;
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
                addProduct.ProductID,
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
            if (dgvCart.CurrentRow != null && !dgvCart.CurrentRow.IsNewRow)
            {

                dgvCart.Rows.RemoveAt( dgvCart.CurrentRow.Index);
            }
            else
            {
                MessageBox.Show("Select row the correct first!");
            }
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            dgvCart.Rows.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            _frmMainAgain.DefultShaw();
        }

        private void btnConfirmSale_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You sure of this operation sale ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                List<clsSaleItems> listItems = new List<clsSaleItems>();
                clsSales sales = new clsSales();

                foreach (DataGridViewRow row in dgvCart.Rows)
                {
                    if (row.IsNewRow)
                        continue;

                    listItems.Add(new clsSaleItems
                    {
                        ProductID = Convert.ToInt32(row.Cells["ProductID"].Value),
                        Quantity = Convert.ToInt32(row.Cells["Qty"].Value),
                        UnitPrice = Convert.ToDecimal(row.Cells["Price"].Value)

                    });
                }

                sales.Total = FinalTotal;
                sales.SubTotal = SubTotal;
                sales.Discount = DisCount;
                sales.Tax = Tax;
                sales.PaymentStatus = "Paid";
                sales.InvoiceNumber = "INV-" + DateTime.Now.ToString("yyyyMMddHHmmss");
                sales.payMethod = comPayment.Text;
                sales.SaleDate = DateTime.Now;
                sales.UserID = clsGlobal.Currentuser.UserID;
                sales.Items= listItems;

                if (sales.Save())
                {
                    MessageBox.Show("Successfully Opration!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvCart.Rows.Clear();
                    frmPOSSales_Load(null, null);
                    return;
                }
                else
                {
                    MessageBox.Show("Not Successfully Opration!", "Not Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            return;
        }
    }
}