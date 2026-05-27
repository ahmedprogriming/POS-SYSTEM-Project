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
    public partial class frmAddEditProduct : Form
    {
        private clsProduct _Productobj;

        private int _Productid = -1;

        private enum _enMode { Addnew = 1, Update = 2 };

        _enMode Mode= _enMode.Addnew;
        public frmAddEditProduct()
        {
            InitializeComponent();
            Mode = _enMode.Addnew;
        }

        public frmAddEditProduct(int ID)
        {
            InitializeComponent();
            Mode = _enMode.Update;
            _Productid=ID;
        }

        private void _FillCategoryName()
        {
            DataTable table = clsCategory.GetAllCategries();

            foreach (DataRow dr in table.Rows)
            {
                cobCategory.Items.Add(dr["CategoryName"]);
            }
        }

        private void _ReasultDefult()
        {
            _FillCategoryName();
            if (Mode == _enMode.Addnew)
            {
                lblTitle.Text = "Add Product";
                _Productobj=new clsProduct();
            }

            else
            {
                lblTitle.Text = "Updte Product";
            }

            lblProductID.Text = "[????]";
            txtNameProduct.Text = "";
            txtBarcode.Text = "";
          cobCategory.SelectedIndex= 0;
            txtCostPrice.Text = "";
            txtSellingPrice.Text = "";
            txtStock.Text = "";
            txtSupplier.Text = "";
        }

        private void frmAddEditProduct_Load(object sender, EventArgs e)
        {
            _ReasultDefult();

            if (Mode == _enMode.Update) 
            {
                LoadData();
            }

           
        }

        private void LoadData()
        {
          
                _Productobj = clsProduct.GetProductByID(_Productid);

                if (_Productobj == null)
                {
                    MessageBox.Show("Error", "This product is Null!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                lblProductID.Text = _Productid.ToString();
                txtNameProduct.Text = _Productobj.ProductName;
                txtBarcode.Text = _Productobj.Barcode;
                cobCategory.Text = _Productobj.CategoryType.CategoryName;
                txtCostPrice.Text = _Productobj.CostPrice.ToString();
                txtSellingPrice.Text = _Productobj.SellingPrice.ToString();
                txtStock.Text = _Productobj.QuantityInStock.ToString();
                txtSupplier.Text = _Productobj.SupplierID.ToString();

             

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you sure of save this product?", "Confirm Opition", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid, put the mouse over the red icon", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

             _Productobj.ProductID = _Productid;
            _Productobj.ProductName = txtNameProduct.Text;
            _Productobj.Barcode = txtBarcode.Text;
            _Productobj.CategoryID = clsCategory.GetAllCategoriesByName(cobCategory.Text).CategoryID;
            _Productobj.SupplierID = txtSupplier.Text == "1" ? 1 : 2;
            _Productobj.CostPrice = Convert.ToSingle(txtCostPrice.Text);
            _Productobj.SellingPrice=Convert.ToSingle(txtSellingPrice.Text);
            _Productobj.IsActive= true;
            _Productobj.QuantityInStock =Convert.ToInt32( txtStock.Text);
            _Productobj.MinimumStockLevel = 15;


            if (!_Productobj.Save())
            {
                MessageBox.Show("Not Saved..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Product save successfuly", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            lblProductID.Text = _Productobj.ProductID.ToString();

        }
        }

        private void txtBarcode_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtBarcode.Text))
            {
                e.Cancel= true;
                errorProvider1.SetError(txtBarcode, "This filed is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtBarcode, null);
            }
        }

        private void txtNameProduct_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNameProduct.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNameProduct, "This filed is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtNameProduct, null);
            }
        }

        private void txtSupplier_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSupplier.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSupplier, "This filed is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtSupplier, null);
            }
        }

        private void txtCostPrice_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCostPrice.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCostPrice, "This filed is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCostPrice, null);
            }
        }

        private void txtSellingPrice_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSellingPrice.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSellingPrice, "This filed is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtSellingPrice, null);
            }
        }

        private void txtStock_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtStock.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtStock, "This filed is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtStock, null);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
