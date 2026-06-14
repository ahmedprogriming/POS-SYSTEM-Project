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
    public class clsInventoryTransactionData
    {
        public static DataTable GetAllTransaction()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["MyDataBaseConnection"].ConnectionString;
            DataTable result = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string Query = @"Select * from Transaction_Process";
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

        public static bool GetTransactionByID(int TransactionID, ref int ProductID, ref string TransactionType,
            ref int QuantityChanged,ref DateTime TransactionDate,
            ref string ReferenceTable,ref int ReferenceID,ref int CreatedByUserID,ref string Notes)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["MyDataBaseConnection"].ConnectionString;
            bool IsFond = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string Query = @"Select * From InventoryTransactions Where TransactionID=@TransactionID";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {

                        command.Parameters.AddWithValue("@TransactionID", TransactionID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFond = true;

                                ProductID = (int)reader["ProductID"];
                                TransactionType = (string)reader["TransactionType"];
                                QuantityChanged = (int)reader["QuantityChanged"];
                                TransactionDate = (DateTime)reader["TransactionDate"];
                                ReferenceTable = (string)reader["ReferenceTable"];
                                ReferenceID = (int)reader["ReferenceID"];
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                                Notes = (string)reader["Notes"];

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

    }
}
