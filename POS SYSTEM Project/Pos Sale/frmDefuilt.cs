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
    public partial class frmDefuilt : Form
    {
        public frmDefuilt()
        {
            InitializeComponent();
        }

        private void frmDefuilt_Load(object sender, EventArgs e)
        {
            int numberInv = clsSales.InvoiceNumberToDay();
            decimal salesTod = clsSales.totalSalesToday();

            clsProduct productLowStock = clsProduct.GetProductByID(clsProduct.ProductLowQuantity());
            clsProduct productTop = clsProduct.GetProductByID(clsProduct.TopProductSalesToday());

            string lowStockText = "No product";
            string productTopToday = "No today";
            int lowStock = 0;

            if (productLowStock != null)
            {
                lowStock = productLowStock.QuantityInStock;
                lowStockText = $"{productLowStock.ProductName} Item";
            }

            if (productTop != null)
            {
                productTopToday = productTop.ProductName;
            }

            ucDashboard1.SetDashboardData(numberInv, salesTod, productTopToday, lowStockText, lowStock);
        }

        private void ucDashboard1_ResultsSalesToday(object sender, clrResultSales.ucDashboard.ResultsSalesTodayEventArgs e)
        {
            if (e.LowStock > 0)
            {
                MessageBox.Show($"This Product is running Low stock,It has {e.LowStock} Items.Please replenish your stock !", "Waring",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
