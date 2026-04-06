using DataAccess_Layer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsses_Layer
{
    public class clsProductData
    {
        public static DataTable GetPartProducts()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["MyDataBaseConnection"].ConnectionString;
            DataTable result = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string Query = "EXEC SP_GetPartProducts";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                result.Load(reader);
                            }

                        }

                    }


                }
            }
            catch (SqlException ex)
            {
                clsEventLog.EventLogExsiption(ex);

            }
            return result;


        }

        public static bool IsProductExsites( string productName ,string barcode)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["MyDataBaseConnection"].ConnectionString;
            bool IsFond = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string Query = "Select Fond=1 from Products Where ProductName=@ProductName And Barcode =@Barcode";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@ProductName", productName.Trim());
                        command.Parameters.AddWithValue("@Barcode", barcode.Trim());
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                           IsFond= reader.HasRows;
                        }

                    }


                }
            }
            catch (SqlException ex)
            {
                clsEventLog.EventLogExsiption(ex);

            }
            return IsFond;
        }

        public static bool GetProductByID( int productID,ref string Barcode , ref string productName, ref int categoryID,
          ref int supplierID, ref float costprice, ref float sellingprice, ref int quantityinstock, ref int minimumstocklevel, ref bool isactive)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["MyDataBaseConnection"].ConnectionString;
            bool IsFond = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string Query = @"Select * From Products Where productID=@productID";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {

                        command.Parameters.AddWithValue("@productID", productID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFond = true;

                                Barcode = (string)reader["Barcode"];
                                productName = (string)reader["productName"];
                                categoryID = (int)reader["categoryID"];
                                supplierID = (int)reader["supplierID"];
                                costprice = Convert.ToSingle(reader["costprice"]);
                                sellingprice = Convert.ToSingle(reader["sellingprice"]);
                                quantityinstock = (int)reader["quantityinstock"];
                                minimumstocklevel = (int)reader["minimumstocklevel"];
                                isactive = (bool)reader["IsActive"];

                            }

                        }

                    }


                }
            }
            catch (SqlException ex)
            {
                clsEventLog.EventLogExsiption(ex);

            }
            return IsFond;

        }

        public static bool GetProductByBarcode(string Barcode,ref int productID,ref string productName,ref int categoryID,
          ref  int supplierID,ref float costprice,ref float sellingprice,ref int quantityinstock,ref int minimumstocklevel,ref bool isactive)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["MyDataBaseConnection"].ConnectionString;
            bool IsFond = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string Query = @"EXEC SP_GetProductByBarcode
                                              @Barcode=@Barcode";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                     
                        command.Parameters.AddWithValue("@Barcode", Barcode);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                IsFond = true;

                                productID = (int)reader["productID"];
                                productName = (string)reader["productName"];
                                categoryID = (int)reader["categoryID"];
                                supplierID = (int)reader["supplierID"];
                                costprice = Convert.ToSingle(reader["costprice"]);
                                sellingprice = Convert.ToSingle(reader["sellingprice"]);
                                quantityinstock = (int)reader["quantityinstock"];
                                minimumstocklevel = (int)reader["minimumstocklevel"];
                                isactive = (bool)reader["IsActive"];

                            }
                        
                        }

                    }


                }
            }
            catch (SqlException ex)
            {
                clsEventLog.EventLogExsiption(ex);

            }
            return IsFond;
        }

        public static int TopProduct()
        {
            int ProductID = -1;

            string ConnectionString = ConfigurationManager.ConnectionStrings["MyDataBaseConnection"].ConnectionString;
   

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string Query = @"Select Top 1 SaleItems.ProductID From SaleItems
                              Inner Join Sales 
                                    On Sales.SaleID = SaleItems.SaleID
                              Where SaleDate >= CAST(GETDATE() As DATE)
                                                 And SaleDate < DATEADD(DAY, 1, CAST(GETDATE() AS DATE))
                                       Group by ProductID
                                        Order By SUM(LineTotal) DESC;";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                      
                        object reasult= command.ExecuteScalar();

                        if (reasult != null && int.TryParse(reasult.ToString(),out int autoID)) 
                        {
                        
                            ProductID = autoID;
                        }

                    }


                }
            }
            catch (SqlException ex)
            {
                clsEventLog.EventLogExsiption(ex);

            }
            return ProductID;

        }

        public static int ProductLowStock()
        {
            int ProductID = -1;

            string ConnectionString = ConfigurationManager.ConnectionStrings["MyDataBaseConnection"].ConnectionString;


            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string Query = @"Select ProductID From Products
                                           Where QuantityInStock=MinimumStockLevel;";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {

                        object reasult = command.ExecuteScalar();

                        if (reasult != null && int.TryParse(reasult.ToString(), out int autoID))
                        {

                            ProductID = autoID;
                        }

                    }


                }
            }
            catch (SqlException ex)
            {
                clsEventLog.EventLogExsiption(ex);

            }
            return ProductID;
        }
    }
}
