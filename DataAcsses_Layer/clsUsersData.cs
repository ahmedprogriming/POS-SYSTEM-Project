using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading.Tasks;
using DataAccess_Layer;


namespace DataAcsses_Layer
{
    public class clsUsersData
    {
        public static DataTable GetAllUsers()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["MyDataBaseConnection"].ConnectionString;
            DataTable result = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string Query = "Select * from Users";
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

        public static bool GetUserByUserNameAndPassword(ref int UserID, ref int RoleID, string Username,string Password,ref string FullName
            ,ref bool IsActive,DateTime CreatedAt)
        {
            bool IsFond=false;
            string ConnectionString = ConfigurationManager.ConnectionStrings["MyDataBaseConnection"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string Query = @"Select * from Users where Password=@Password and Username=@Username;";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", Username);
                        command.Parameters.AddWithValue("@Password", Password);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                           

                            if (reader.Read())
                            {
                                IsFond = true;

                                UserID = (int)reader["UserID"];
                                RoleID = (int)reader["RoleID"];
                                FullName = (string)reader["FullName"];
                                IsActive = (bool)reader["IsActive"];
                                CreatedAt = (DateTime)reader["CreatedAt"];


                            }
                            else
                            {
                                IsFond = false;
                            }

                        }

                    }


                }
            }catch(SqlException  ex) 
            {
                clsEventLog.EventLogExsiption(ex);
            }
            return IsFond;
        }
    }
}
