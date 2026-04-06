using System;
using System.Windows.Forms;
using Busisns_Layer;


namespace clrResultSales
{
    public partial class ucDashboard : UserControl
    {
      
        public ucDashboard()
        {
            InitializeComponent();
        }

        public class ResultsSalesTodayEventArgs : EventArgs
        {
            public int NumberInv { get; }
            public decimal TodaySales { get; }
            public string TopProduct { get; }
            public int LowStock { get; }

            public ResultsSalesTodayEventArgs(int numberInv, decimal todaySales, string topProduct, int lowStock)
            {
                NumberInv = numberInv;
                TodaySales = todaySales;
                TopProduct = topProduct;
                LowStock = lowStock;
            }
        }

        public event EventHandler<ResultsSalesTodayEventArgs> ResultsSalesToday;

        protected virtual void RaiseResultsSalesToday(ResultsSalesTodayEventArgs e)
        {
            ResultsSalesToday?.Invoke(this, e);
        }

        public void RaiseResultsSalesToday(int numberInv, decimal todaySales, string topProduct, int lowStock)
        {
            RaiseResultsSalesToday(new ResultsSalesTodayEventArgs(numberInv, todaySales, topProduct, lowStock));
        }

        public void SetDashboardData(int numberInv, decimal todaySales, string topProduct,string ProdLow, int lowStock)
        {
            

            lblInvoicesCount.Text = numberInv.ToString();
            lblLowStock.Text = ProdLow;
            lblTodaySales.Text = todaySales.ToString();
            lblTopProduct.Text = topProduct;

            RaiseResultsSalesToday(numberInv, todaySales, topProduct, lowStock);

        }


     
    }
}