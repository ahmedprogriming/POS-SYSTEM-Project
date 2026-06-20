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
    public class clsReportsData
    {
        public static DataTable GetAllDailySales()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["MyDataBaseConnection"].ConnectionString;
            DataTable result = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string Query = @"Select Sales.InvoiceNumber,Sales.SaleDate,
Products.ProductName,SaleItems.LineTotal,Sales.PaymentStatus
from Sales
Inner Join SaleItems On Sales.SaleID=SaleItems.SaleID
Inner Join Products On Products.ProductID = SaleItems.ProductID
WHERE SaleDate >= CAST(GETDATE() AS DATE)
AND SaleDate < DATEADD(DAY,1,CAST(GETDATE() AS DATE));";
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

        public static DataTable GetAllMonthlyAndYearSales(DateTime StartDate,DateTime EndDate)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["MyDataBaseConnection"].ConnectionString;
            DataTable result = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string Query = @"SELECT
    Sales.InvoiceNumber,
    Sales.SaleDate,
    Products.ProductName,
    SaleItems.LineTotal,
    Sales.PaymentStatus
FROM Sales
INNER JOIN SaleItems
    ON Sales.SaleID = SaleItems.SaleID
INNER JOIN Products
    ON Products.ProductID = SaleItems.ProductID
WHERE SaleDate >= @StartDate
AND SaleDate < @EndDate;";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@StartDate", StartDate);
                        command.Parameters.AddWithValue("@EndDate", EndDate);
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
    }
}
