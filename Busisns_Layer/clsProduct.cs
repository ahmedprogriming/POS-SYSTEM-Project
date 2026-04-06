using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcsses_Layer;

namespace Busisns_Layer
{
    public class clsProduct
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Barcode { get; set; }
        public int CategoryID { get; set; }
        public int SupplierID { get; set; }

        public float CostPrice { get; set; }
        public float SellingPrice { get; set; }
        public int QuantityInStock { get; set; }
        public int MinimumStockLevel { get; set; }
        public bool IsActive { get; set; }

        public clsProduct ()
        {
            this.ProductID = -1;
            this.ProductName = "";
            this.Barcode = "";
            this.CategoryID = -1;
            this.SupplierID = -1;
            this.CostPrice = 0;
            this.SellingPrice = 0;
            this.QuantityInStock = -1;
            this.MinimumStockLevel = -1;
            this.IsActive = false;
        }

        public clsProduct(int productID,string productName,string barcode,int categoryID,
            int supplierID,float costprice,float sellingprice,int quantityinstock,int minimumstocklevel,bool isactive)
        {
            this.ProductID = productID;
            this.ProductName = productName;
            this.Barcode = barcode;
            this.CategoryID = categoryID;
            this.SupplierID = supplierID;
            this.CostPrice = costprice;
            this.SellingPrice = sellingprice;
            this.QuantityInStock= quantityinstock;
            this.MinimumStockLevel = minimumstocklevel;
            this.IsActive = isactive;
        }

        public static DataTable GetPartProduct()
        {
            return clsProductData.GetPartProducts();
        }

        public static bool IsProductAvailable(string productName, string barcode)
        {
            return clsProductData.IsProductExsites( productName, barcode);
        }

        public static clsProduct GetProductByID(int productID)
        {
            int categoryID = -1, quantityinstock = -1, minimumstocklevel = -1, supplierID = -1;
            string productName = "" , barcode="";
            float costprice = 0, sellingprice = 0;
            bool isactive = false;

            if (clsProductData.GetProductByID( productID,ref barcode, ref productName, ref categoryID, ref supplierID,
                ref costprice, ref sellingprice, ref quantityinstock, ref minimumstocklevel, ref isactive))
            {
                return new clsProduct(productID, productName, barcode, categoryID, supplierID,
                 costprice, sellingprice, quantityinstock, minimumstocklevel, isactive);
            }
            else
            {
                return null;
            }
        }

        public static clsProduct GetProductByBarcode(string barcode)
        {
            int productID = -1 , categoryID=-1 , quantityinstock=-1 , minimumstocklevel=-1 , supplierID=-1;
            string productName = "";
            float costprice = 0, sellingprice = 0;
            bool isactive=false;

            if(clsProductData.GetProductByBarcode(barcode,ref productID,ref productName,ref categoryID,ref supplierID,
                ref costprice, ref sellingprice, ref quantityinstock,ref minimumstocklevel,ref isactive))
            {
                return new clsProduct(productID,productName,barcode,categoryID,  supplierID,
                 costprice,  sellingprice,  quantityinstock,  minimumstocklevel,  isactive);
            }
            else
            {
                return null;
            }
        }

        public static int TopProductSalesToday()
        {
            int ProductID = clsProductData.TopProduct();

            if (ProductID !=-1)
            {
                return ProductID;
            }

           return -1;
        }

        public static int ProductLowQuantity()
        {
            int ProductID = clsProductData.ProductLowStock();

            if (ProductID != -1)
            {
                return ProductID;
            }

            return -1;
           
        }
    }
}
