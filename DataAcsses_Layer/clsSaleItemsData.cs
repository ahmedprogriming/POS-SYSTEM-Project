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
    public class clsSaleItemsData
    {
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public static int AddNewItemSale(int SaleID,int ProductID,int Quantity,decimal UnitPrice)
        {
            int ItemID = -1;

            string ConnectionString = ConfigurationManager.ConnectionStrings["MyDataBaseConnection"].ConnectionString;
          

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string Query = @"INSERT INTO [dbo].[SaleItems]
           ([SaleID]
           ,[ProductID]
           ,[Quantity]
           ,[UnitPrice])
     VALUES
           (@SaleID
           ,@ProductID
           ,@Quantity
           ,@UnitPrice)
SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@SaleID", SaleID);
                        command.Parameters.AddWithValue("@ProductID", ProductID);
                        command.Parameters.AddWithValue("@Quantity", Quantity);
                        command.Parameters.AddWithValue("@UnitPrice", UnitPrice);

                        object reasult = command.ExecuteScalar();
                        
                        if(reasult != null&&int.TryParse(reasult.ToString(),out int autoID))
                        {
                            ItemID = autoID;
                        }
                           
                        

                    }


                }
            }
            catch (SqlException ex)
            {
                clsEventLog.EventLogExsiption(ex);

            }
            return ItemID;
        }

        public static bool UpdateItemSales(int SaleItemID, int SaleID, int ProductID, int Quantity, decimal UnitPrice)
        {
            int rowafected = -1;

            string ConnectionString = ConfigurationManager.ConnectionStrings["MyDataBaseConnection"].ConnectionString;


            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string Query = @"UPDATE [dbo].[SaleItems]
   SET [SaleID] = @SaleID
      ,[ProductID] = @ProductID
      ,[Quantity] = @Quantity
      ,[UnitPrice] = @UnitPrice
 WHERE SaleItemID=@SaleItemID";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@SaleItemID", SaleItemID);
                        command.Parameters.AddWithValue("@SaleID", SaleID);
                        command.Parameters.AddWithValue("@ProductID", ProductID);
                        command.Parameters.AddWithValue("@Quantity", Quantity);
                        command.Parameters.AddWithValue("@UnitPrice", UnitPrice);

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
    }
}
