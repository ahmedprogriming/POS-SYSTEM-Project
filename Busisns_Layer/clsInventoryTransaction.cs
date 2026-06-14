using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcsses_Layer;

namespace Busisns_Layer
{
    public class clsInventoryTransaction
    {
        public int TransactionID { get; set; }
        public int ProductID { get; set; }
        public string TransactionType { get; set; }

        public int QuantityChanged { get; set; }
        public DateTime TransactionDate { get; set; }
        public int ReferenceID { get; set; }
        public int CreatedByUserID { get; set; }
        public string ReferenceTable { get; set; }
        public clsProduct objProduct { get; set; }
        public string Notes { get; set; }

        public clsInventoryTransaction(int transactionID, int productID, string transactionType, int quantityChanged, DateTime transactionDate,string referenceTable, int referenceID, int createdByUserID, string notes)
        {
            TransactionID = transactionID;
            ProductID = productID;
            TransactionType = transactionType;
            QuantityChanged = quantityChanged;
            TransactionDate = transactionDate;
            ReferenceID = referenceID;
            CreatedByUserID = createdByUserID;
            ReferenceTable = referenceTable;
            Notes = notes;
            objProduct = clsProduct.GetProductByID(productID);
        }

        public clsInventoryTransaction()
        {
            this.TransactionID = -1;
            this.ProductID = -1;
            this.TransactionType = "";
            this.QuantityChanged = 0;
            this.TransactionDate = DateTime.MinValue;
            this.ReferenceID = -1;
            this.CreatedByUserID = -1;
            this.Notes = "";

        }

        public static DataTable GetAllProccesSales()
        {
            return clsInventoryTransactionData.GetAllTransaction();
        }

        public static clsInventoryTransaction GetAllProccesTransactionByID(int transactionID)
        {
            int productID = -1,
     ReferenceID = -1,
     CreatedByUserID = -1,
     QuantityChanged = -1;

            string TransactionType="", Notes="" , ReferenceTable1 = "";

            DateTime TransactionDate = DateTime.MinValue;

            if(clsInventoryTransactionData.GetTransactionByID(transactionID, ref productID, ref  TransactionType,
            ref  QuantityChanged, ref  TransactionDate,
            ref ReferenceTable1, ref  ReferenceID, ref  CreatedByUserID, ref  Notes))
            {
                return new clsInventoryTransaction(transactionID, productID, TransactionType,
             QuantityChanged, TransactionDate,
             ReferenceTable1, ReferenceID, CreatedByUserID, Notes);
            }
            return null;

        } 


    }
}
