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
    public partial class ucProductDetails : UserControl
    {
        private clsProduct _ProductCurrent;
     
       private int _ProductID = -1;

        public int ProductID
        {
            get => _ProductID;
        }

        public clsProduct ProductCurrentInfo { get => _ProductCurrent; }

        public ucProductDetails()
        {
            InitializeComponent();
           
        }

        public void LoadData(int ID)
        {
            _ProductCurrent=clsProduct.GetProductByID(ID);
            if( _ProductCurrent == null )
            {
                MessageBox.Show("Not fond this product!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

                _ResultDefulte();
                return;
            }
            _ProductID=ID;

            FillDetailesProduct();
        }

        private void FillDetailesProduct()
        {
            lblID.Text = _ProductID.ToString();
            lblProductName.Text = _ProductCurrent.ProductName;
            lblBarcode.Text = _ProductCurrent.Barcode;
            lblCategory.Text = _ProductCurrent.CategoryID.ToString();
            lblCostPrice.Text = _ProductCurrent.CostPrice.ToString("0.00") + "$";
            lblSelling.Text = _ProductCurrent.SellingPrice.ToString("0.00") + "$";
            lblStock.Text = _ProductCurrent.QuantityInStock.ToString();
            lblSupplier.Text = _ProductCurrent.SupplierID.ToString();
        }

        private void _ResultDefulte()
        {
            lblID.Text = "[????]";
            lblProductName.Text = "[????]";
            lblBarcode.Text = "[????]";
            lblCategory.Text = "[????]";
            lblCostPrice.Text = "[????]";
            lblSelling.Text = "[????]";
            lblStock.Text = "[????]";
            lblSupplier.Text = "[????]";

        }
    }
}
