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

                    string Query = @"Select Users.UserID,Users.FullName,Users.Username ,
  Case Users.RoleID
   WHEN 1 THEN 'Admin'
        WHEN 2 THEN 'Manager'
        WHEN 3 THEN 'Cashier'
        ELSE 'Other'
    END AS RoleName ,Users.IsActive, Users.CreatedAt
FROM Users;";
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

        public static bool GetUserByID( int UserID, ref int RoleID,ref string Username,ref string Password, ref string FullName
           , ref bool IsActive, DateTime CreatedAt)
        {
            bool IsFond = false;
            string ConnectionString = ConfigurationManager.ConnectionStrings["MyDataBaseConnection"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string Query = @"Select * from Users where UserID=@UserID;";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);
                     

                        using (SqlDataReader reader = command.ExecuteReader())
                        {


                            if (reader.Read())
                            {
                                IsFond = true;

                                Username = (string)reader["Username"];
                                Password = (string)reader["Password"];
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
            }
            catch (SqlException ex)
            {
                clsEventLog.EventLogExsiption(ex);
            }
            return IsFond;
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

        public static int AddNewUser( int RoleID, string Username,
            string Password,  string FullName
           , bool IsActive, DateTime CreatedAt)
        {
            int UserId = -1;

            string ConnectionString = ConfigurationManager.ConnectionStrings["MyDataBaseConnection"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string Query = @"INSERT INTO [dbo].[Users]
           ([FullName]
           ,[Username]
           ,[Password]
           ,[RoleID]
           ,[IsActive]
           ,[CreatedAt])
     VALUES
           (@FullName
           ,@Username
           ,@Password
           ,@RoleID
           ,@IsActive
           ,@CreatedAt
                      )
  Select SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@FullName", FullName);
                        command.Parameters.AddWithValue("@Username", Username);
                        command.Parameters.AddWithValue("@Password", Password);
                        command.Parameters.AddWithValue("@RoleID", RoleID);
                        command.Parameters.AddWithValue("@IsActive", IsActive);
                        command.Parameters.AddWithValue("@CreatedAt", CreatedAt);
                      

                        object reder = command.ExecuteScalar();

                        if (reder != null && int.TryParse(reder.ToString(), out int autoID))
                        {
                            UserId = autoID;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                clsEventLog.EventLogExsiption(ex);
            }
            return UserId;
        }

        public static bool UpdateUser(int UserID,int RoleID, string Username,
            string Password, string FullName
           , bool IsActive, DateTime CreatedAt)
        {
            int rowAfeted = -1;

            string ConnectionString = ConfigurationManager.ConnectionStrings["MyDataBaseConnection"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string Query = @" UPDATE [dbo].[Users]
            SET [RoleID] = @RoleID,
                [Username] = @Username,
                [Password] = @Password,
                [FullName] = @FullName,
                [IsActive] = @IsActive,
                [CreatedAt] = @CreatedAt
              
            WHERE UserID = @UserID;";

                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@FullName", FullName);
                        command.Parameters.AddWithValue("@Username", Username);
                        command.Parameters.AddWithValue("@Password", Password);
                        command.Parameters.AddWithValue("@RoleID", RoleID);
                        command.Parameters.AddWithValue("@IsActive", IsActive);
                        command.Parameters.AddWithValue("@CreatedAt", CreatedAt);

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

        public static bool DeletedUsers(int UserID)
        {
            int rowAfeted = -1;

            string ConnectionString = ConfigurationManager.ConnectionStrings["MyDataBaseConnection"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string Query = @" UPDATE [dbo].[Users]
            SET 
                [IsActive] = 0
              
            WHERE UserID = @UserID;";

                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);
                        
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

    }
}
