using DataAccess_Layer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAcsses_Layer
{
    public class clsSalesData
    {
        public static int AddNewSales(string InvoiceNumber, DateTime SaleDate, int UserID,
            decimal SubTotal,decimal Discount,decimal Tax,string PaymentStatus,string pamentMethod,decimal amountpaid,List<clsSaleItemsData> items)
        {
            int saleID = -1;
            
            string ConnectionString = ConfigurationManager.ConnectionStrings["MyDataBaseConnection"].ConnectionString;


            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                
                    using (SqlTransaction transaction = connection.BeginTransaction()) 
                    {
                        try
                        {
                            string SalesQuary = @"INSERT INTO Sales
                   (InvoiceNumber, SaleDate, UserID, SubTotal, Discount, Tax, PaymentStatus)
                                 VALUES
                                 (@InvoiceNumber, @SaleDate, @UserID, @SubTotal, @Discount, @Tax, @PaymentStatus);
                                 SELECT SCOPE_IDENTITY();";

                            using (SqlCommand command = new SqlCommand(SalesQuary, connection,transaction))
                            {
                                command.Parameters.AddWithValue("@InvoiceNumber", InvoiceNumber);
                                command.Parameters.AddWithValue("@SaleDate", SaleDate);
                                command.Parameters.AddWithValue("@UserID", UserID);
                                command.Parameters.AddWithValue("@SubTotal", SubTotal);
                                command.Parameters.AddWithValue("@Discount", Discount);
                                command.Parameters.AddWithValue("@Tax", Tax);
                                command.Parameters.AddWithValue("@PaymentStatus", PaymentStatus);

                                object reasult = command.ExecuteScalar();

                                if (reasult != null && int.TryParse(reasult.ToString(), out int autoID))
                                {
                                    saleID = autoID;
                                }

                                

                            }

                            if (saleID == -1)

                                throw new Exception("Filed to create sales recode.");

                            foreach(clsSaleItemsData Itemsale in items)
                            {
                                string itemQuery = @"INSERT INTO SaleItems (SaleID, ProductID, Quantity, UnitPrice)
                                     VALUES (@SaleID, @ProductID, @Quantity, @UnitPrice)";

                                using (SqlCommand command = new SqlCommand(itemQuery, connection, transaction))
                                {
                                    command.Parameters.AddWithValue("@SaleID", saleID);
                                    command.Parameters.AddWithValue("@ProductID", Itemsale.ProductID);
                                    command.Parameters.AddWithValue("@Quantity", Itemsale.Quantity);
                                    command.Parameters.AddWithValue("@UnitPrice", Itemsale.UnitPrice);
                                    command.ExecuteNonQuery();
                                }

                                string updateProduct = @" UPDATE Products
                       SET QuantityInStock = QuantityInStock - @Quantity
                                      WHERE ProductID = @ProductID";

                                using (SqlCommand command = new SqlCommand(updateProduct, connection, transaction))
                                {
                              
                                    command.Parameters.AddWithValue("@ProductID", Itemsale.ProductID);
                                    command.Parameters.AddWithValue("@Quantity", Itemsale.Quantity);
                                   
                                    command.ExecuteNonQuery();
                                }

                                string inventoryQuery = @"
                            INSERT INTO InventoryTransactions
                            (ProductID, TransactionType, QuantityChanged, TransactionDate, ReferenceTable, ReferenceID, CreatedByUserID, Notes)
                            VALUES
                            (@ProductID, @TransactionType, @QuantityChanged, @TransactionDate, @ReferenceTable, @ReferenceID, @CreatedByUserID, @Notes);";

                                using (SqlCommand command = new SqlCommand(inventoryQuery, connection, transaction))
                                {
                                    command.Parameters.AddWithValue("@ProductID", Itemsale.ProductID);
                                    command.Parameters.AddWithValue("@TransactionType", "Sale");
                                    command.Parameters.AddWithValue("@QuantityChanged", -Itemsale.Quantity);
                                    command.Parameters.AddWithValue("@TransactionDate", DateTime.Now);
                                    command.Parameters.AddWithValue("@ReferenceTable", "Sales");
                                    command.Parameters.AddWithValue("@ReferenceID", saleID);
                                    command.Parameters.AddWithValue("@CreatedByUserID", UserID);
                                    command.Parameters.AddWithValue("@Notes", "Sold from POS");
                                    command.ExecuteNonQuery();
                                }
                            }

                            string paymentQuaru = @"INSERT INTO Payments (SaleID, PaymentMethod, AmountPaid, PaymentDate)
                                    VALUES (@SaleID, @PaymentMethod, @AmountPaid, @PaymentDate)";

                            using (SqlCommand command = new SqlCommand(paymentQuaru, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@SaleID", saleID);
                                command.Parameters.AddWithValue("@PaymentMethod", pamentMethod);
                                command.Parameters.AddWithValue("@AmountPaid", amountpaid);
                                command.Parameters.AddWithValue("@PaymentDate", DateTime.Now);
                                command.ExecuteNonQuery();
                            }

                            transaction.Commit();
                        }
                        catch (SqlException ex)
                        {
                            transaction.Rollback();

                            clsEventLog.EventLogExsiption(ex);
                        }
                   
                    
                    }
                   


                }
            }
            catch (SqlException ex)
            {
                clsEventLog.EventLogExsiption(ex);

            }
            return saleID;
        }

        public static bool UpdateSales(int SaleID, string InvoiceNumber, DateTime SaleDate, int UserID,
            decimal SubTotal, decimal Discount, decimal Tax, string PaymentStatus)
        {
            int rowafected = -1;

            string ConnectionString = ConfigurationManager.ConnectionStrings["MyDataBaseConnection"].ConnectionString;


            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string Query = @"UPDATE [dbo].[Sales]
   SET [InvoiceNumber] = @InvoiceNumber
      ,[SaleDate] = @SaleDate
      ,[UserID] = @UserID
      ,[SubTotal] = @SubTotal
      ,[Discount] = @Discount
      ,[Tax] = @Tax
      ,[PaymentStatus] = @PaymentStatus
 WHERE SaleID=@SaleID";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                      
                        command.Parameters.AddWithValue("@SaleID", SaleID);
                        command.Parameters.AddWithValue("@InvoiceNumber", InvoiceNumber);
                        command.Parameters.AddWithValue("@SaleDate", SaleDate);
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@SubTotal", SubTotal);
                        command.Parameters.AddWithValue("@Discount", Discount);
                        command.Parameters.AddWithValue("@Tax", Tax);
                        command.Parameters.AddWithValue("@PaymentStatus", PaymentStatus);

                        rowafected = command.ExecuteNonQuery();



                    }


                }
            }
            catch (SqlException ex)
            {
                clsEventLog.EventLogExsiption(ex);

            }
            return (rowafected > 0);

        }

        public static int CountInvoice()
        {
            int CountNum = -1;

            string ConnectionString = ConfigurationManager.ConnectionStrings["MyDataBaseConnection"].ConnectionString;


            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string Query = @"Select Count(SaleID) As CountInvoice From Sales
Where SaleDate >= CAST(GETDATE() As DATE)
And SaleDate < DATEADD(DAY, 1, CAST(GETDATE() AS DATE));";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        object reasult=command.ExecuteScalar();

                        if (reasult != null && reasult != DBNull.Value)
                        {
                            CountNum =Convert.ToInt32(reasult);
                        }

                    }


                }
            }
            catch (SqlException ex)
            {
                clsEventLog.EventLogExsiption(ex);

            }
            return CountNum;
        }

        public static decimal TotalAmountSales()
        {
            decimal TotalAmount = 0m;

            string ConnectionString = ConfigurationManager.ConnectionStrings["MyDataBaseConnection"].ConnectionString;


            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string Query = @"Select Sum(TotalAmount) As CountInvoice From Sales
Where SaleDate >= CAST(GETDATE() As DATE)
And SaleDate < DATEADD(DAY, 1, CAST(GETDATE() AS DATE));;";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        object reasult = command.ExecuteScalar();

                        if (reasult != null && decimal.TryParse(reasult.ToString(), out decimal returnValue))
                        {
                            TotalAmount = returnValue;
                        }

                    }


                }
            }
            catch (SqlException ex)
            {
                clsEventLog.EventLogExsiption(ex);

            }
            return TotalAmount;
        }
    }
}
