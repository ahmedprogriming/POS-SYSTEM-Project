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
    public class clsCategoryData
    {
        public static DataTable GetAllCategory()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["MyDataBaseConnection"].ConnectionString;
            DataTable result = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string Query = @"  Select *  from Categories";
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

        public static bool GetCategoryByID(int CategoryID, ref string CategoryName, ref string Description)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["MyDataBaseConnection"].ConnectionString;
            bool IsFond = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string Query = @"Select * From Categories Where CategoryID=@CategoryID";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {

                        command.Parameters.AddWithValue("@CategoryID", CategoryID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFond = true;

                                CategoryName = (string)reader["CategoryName"];
                                Description = (string)reader["Description"];
                               

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

        public static bool GetCategoryByName(string CategoryName, ref int CategoryID, ref string Description)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["MyDataBaseConnection"].ConnectionString;
            bool IsFond = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string Query = @"Select * From Categories Where CategoryName=@CategoryName";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {

                        command.Parameters.AddWithValue("@CategoryName", CategoryName);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFond = true;

                                CategoryID = (int)reader["CategoryID"];
                                Description = (string)reader["Description"];


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

        public static int AddNewCategory(string CategoryName, string Description)
        {
            int CategoryID = -1;

            string ConnectionString = ConfigurationManager.ConnectionStrings["MyDataBaseConnection"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string Query = @"INSERT INTO [dbo].[Categories]
           ([CategoryName]
           ,[Description])
     VALUES
           (@CategoryName
           ,@Description)
                    Select SCOPE_IDENTITY();  ";

                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@CategoryName", CategoryName);
                        command.Parameters.AddWithValue("@Description", Description);
                      

                        object reder = command.ExecuteScalar();

                        if (reder != null && int.TryParse(reder.ToString(), out int autoID))
                        {
                            CategoryID = autoID;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                clsEventLog.EventLogExsiption(ex);
            }
            return CategoryID;
        }

        public static bool UpdateCategory(int CategoryID, string CategoryName, string Description)
        {
            int rowAfeted = -1;

            string ConnectionString = ConfigurationManager.ConnectionStrings["MyDataBaseConnection"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string Query = @" UPDATE [dbo].[Categories]
            SET [CategoryName] = @CategoryName,
                [Description] = @Description
               
            WHERE CategoryID = @CategoryID;";

                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@CategoryID", CategoryID);
                        command.Parameters.AddWithValue("@CategoryName", CategoryName);
                        command.Parameters.AddWithValue("@Description", Description);
                      

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

        public static bool DeleteCategory(int Id)

        {
            int rowafected = -1;

            string ConnectionString = ConfigurationManager.ConnectionStrings["MyDataBaseConnection"].ConnectionString;


            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string Query = @"Delete Categories where CategoryID=@CategoryID";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {

                        command.Parameters.AddWithValue("@CategoryID", Id);

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
