using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcsses_Layer;

namespace Busisns_Layer
{
    public class clsSaleItems
    {
   
         public   int ProductID { get; set; }
           public int Quantity { get; set; }
          public  decimal UnitPrice { get; set; }

        public clsSaleItems()
        {
            //this.SaleItemID=-1;
            //this.SaleID = -1;
            //this.ProductID = -1;
            //this.Quantity = -1;
            //this.UnitPrice = 0m;

            //modeIten = enMode.addNewItem;
        }

        public clsSaleItems(int saleItemID, int saleID,int productID,int quantity,decimal price)
        {
            //this.SaleItemID=saleItemID;
            //this.SaleID=saleID;
            this.ProductID=productID;
            this.Quantity=quantity;
            this.UnitPrice=price;

           // modeIten = enMode.updateItem;
        }

        //private bool _addNewItem()
        //{
        //   // this.SaleItemID=clsSaleItemsData.AddNewItemSale(this.SaleID,this.ProductID,this.Quantity,this.UnitPrice);

        //    //return (this.SaleItemID != -1);
        //}

        private bool _udateItem()
        {
        //    return clsSaleItemsData.UpdateItemSales(this.SaleItemID, this.SaleID, this.ProductID, this.Quantity, this.UnitPrice);
        //}

        //public bool Save()
        //{
        //    switch(modeIten)
        //    {
        //        case enMode.addNewItem:
        //          if(_addNewItem())
        //            {
        //                modeIten = enMode.updateItem;
        //                return true;
        //            }
        //            else
        //            {
        //                return false;
        //            }
        //          case enMode.updateItem:

        //            return _udateItem();
        //    }

            return false;
        }
    }
}
