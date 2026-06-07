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
    public class clsSuppliersData
    {
        public static DataTable GetAllSupplier()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["MyDataBaseConnection"].ConnectionString;
            DataTable result = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string Query = @"EXEC [dbo].[SP_GetAllSuppliers]";
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

        public static bool GetSupplierByID(int SupplierID, ref string SupplierName, ref string Phone,ref string Email,ref string Address)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["MyDataBaseConnection"].ConnectionString;
            bool IsFond = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string Query = @"EXEC SP_GetSupplierByID
                                     @SupplierID=@SupplierID";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {

                        command.Parameters.AddWithValue("@SupplierID", SupplierID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFond = true;

                                SupplierName = (string)reader["SupplierIDName"];
                                Phone = (string)reader["Phone"];
                                Email = (string)reader["Email"];
                                Address = (string)reader["Address"];

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

        public static int AddNewSupplier(string SupplierName,  string Phone,  string Email,string Address)
        {
            int SupplierID = -1;

            string ConnectionString = ConfigurationManager.ConnectionStrings["MyDataBaseConnection"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string Query = @"EXEC [dbo].[SP_GetAddNewSuppliers]
		                 @SupplierName =@SupplierName,
		                 @Phone =@Phone,
		                 @Email =@Email,
		                 @Address =@Address";

                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@SupplierName", SupplierName);
                        command.Parameters.AddWithValue("@Phone", Phone);
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@Address", Address);


                        object reder = command.ExecuteScalar();

                        if (reder != null && int.TryParse(reder.ToString(), out int autoID))
                        {
                            SupplierID = autoID;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                clsEventLog.EventLogExsiption(ex);
            }
            return SupplierID;
        }

        public static bool UpdateSupplier(int SupplierID, string SupplierName, string Phone, string Email, string Address)
        {
            int rowAfeted = -1;

            string ConnectionString = ConfigurationManager.ConnectionStrings["MyDataBaseConnection"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string Query = @" UEXEC	@return_value = [dbo].[SP_GetUpdateSuppliers]
		                            @SupplierID =@SupplierID,
		                            @SupplierName =@SupplierName,
		                            @Phone =@Phone,
		                            @Email =@Email,
		                            @Address =@Address";

                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@SupplierID", SupplierID);
                        command.Parameters.AddWithValue("@SupplierName", SupplierName);
                        command.Parameters.AddWithValue("@Phone", Phone);
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@Address", Address);

                        rowAfeted = command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                clsEventLog.EventLogExsiption(ex);
            }
            return (rowAfeted > 0);
        }

        public static bool DeleteSupplier(int Id)

        {
            int rowafected = -1;

            string ConnectionString = ConfigurationManager.ConnectionStrings["MyDataBaseConnection"].ConnectionString;


            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string Query = @"Delete Suppliers where SupplierID=@SupplierID";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {

                        command.Parameters.AddWithValue("@SupplierID", Id);

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
