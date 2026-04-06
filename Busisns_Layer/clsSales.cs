using DataAcsses_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busisns_Layer
{
    public class clsSales
    {
        public enum enMode { addNewItem = 1, updateItem = 2 }

        public enMode modeItem = enMode.addNewItem;

       public int SaleID { get; set; }
        public  string InvoiceNumber { get; set; }
          public  DateTime SaleDate { get; set; }
           public int UserID { get; set; }
           public decimal SubTotal { get; set; }
             public   decimal Discount { get; set; }

        public decimal Total { get; set; }
          public decimal Tax { get; set; }
           public string PaymentStatus { get; set; }
         public string payMethod { get; set; }
        public List<clsSaleItems> Items { get; set; }

        public clsSales()
        {
            this.SaleID = -1;
            this.InvoiceNumber = "";
            this.SaleDate = DateTime.Now;
            this.UserID = -1;
            this.SubTotal = 0m;
            this.Discount = 0m;
            this.Tax = 0m;
            this.PaymentStatus = "";
            this.payMethod = "";

            modeItem= enMode.addNewItem;
        }

        public clsSales(int saleID, string invoiceNumber, DateTime saleDate, int userID,
            decimal subTotal, decimal discount, decimal tax, string paymentStatus,string payMethod,List<clsSaleItems> saleItems)
        {
            this.SaleID = saleID;
            this.InvoiceNumber = invoiceNumber;
            this.SaleDate = saleDate;
            this.UserID = userID;
            this.SubTotal = subTotal;
            this.Discount = discount;
            this.Tax = tax;
            this.PaymentStatus = paymentStatus;
            this.payMethod = payMethod;
            this.Items = saleItems;

            modeItem= enMode.updateItem;
        }

        private bool _addNewItem()
        {
            List<clsSaleItemsData> saleItemsDatas = new List<clsSaleItemsData>();

            foreach (var saleItem in this.Items)
            {
                saleItemsDatas.Add(new clsSaleItemsData
                {
                    ProductID = saleItem.ProductID,
                    Quantity = saleItem.Quantity,
                    UnitPrice = saleItem.UnitPrice,
                });

            }


            this.SaleID = clsSalesData.AddNewSales(this.InvoiceNumber, this.SaleDate, this.UserID,
                this.SubTotal, this.Discount, this.Tax, this.PaymentStatus, this.payMethod, this.Total, saleItemsDatas);

            return (this.SaleID != -1);
        }

        private bool _udateItem()
        {
            return clsSalesData.UpdateSales(this.SaleID,this.InvoiceNumber, this.SaleDate, this.UserID,
                this.SubTotal, this.Discount, this.Tax, this.PaymentStatus);
        }

        public static int InvoiceNumberToDay()
        {
            int InvNumber= clsSalesData.CountInvoice();

            if (InvNumber != -1)
            {
                return InvNumber;
            }


            return 0;
        }

        public static decimal totalSalesToday()
        {
            decimal MoneySales= clsSalesData.TotalAmountSales();

            if (MoneySales != 0)
            {
                return MoneySales;
            }

            return 0;
        }
        public bool Save()
        {
            switch (modeItem)
            {
                case enMode.addNewItem:
                    if (_addNewItem())
                    {
                        modeItem = enMode.updateItem;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.updateItem:
               
                   return _udateItem();
            }

            return false;
        }

    }
}
