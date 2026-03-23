using DataAccess_Layer;
using DataAcsses_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Busisns_Layer
{
    public class clsUsers
    {
        public enum enRole {Admin=1,Manager=2,Cashier=3};

        public enRole NuRole=enRole.Admin;
       public int UserID { get; set; }
            public string Password { get; set; }
           public string Username { get; set; }
           public string FullName { get; set; }
           public int RoleID { get; set; }
            public bool IsActive { get; set; }
           public DateTime CreatedAt { get; set; }

        public string NameRole
        {
            
            get
            {
                return _GetNameRole(this.NuRole);
            }
        }

        public clsUsers()
        {
            UserID = -1;
            Password = "";
            Username = "";
            FullName = "";
            RoleID = -1;
            IsActive = false;
            CreatedAt = DateTime.Now;
        }

        public clsUsers(int userID, string password, string username, string fullName, int roleID, bool isActive, DateTime createdAt)
        {
            UserID = userID;
            Password = password;
            Username = username;
            FullName = fullName;
            RoleID = roleID;
            IsActive = isActive;
            CreatedAt = createdAt;
        }

        public static clsUsers FindUserByUserNameAndPassord(string userName, string passward)
        {
            int UserID = -1,RoleID=-1;
            string FullName = "";
            bool IsActive=false;
            
            DateTime CreatedAt=DateTime.MinValue;

            //string HashPassward=ComputeHash(passward);

            if(clsUsersData.GetUserByUserNameAndPassword(ref UserID,ref RoleID,userName,passward,ref FullName,ref IsActive, CreatedAt))
            {
                return new clsUsers(UserID,passward,userName,FullName,RoleID,IsActive, CreatedAt);
            }
            else
            {
                return null;
            }

        }

        public static string ComputeHash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

                return BitConverter.ToString(hashytes).Replace("-", "").ToLower();


            }
        }

        private static string _GetNameRole(enRole role)
        {
            switch (role)
            {
                case enRole.Admin:
                    return "Admin";
                    
                case enRole.Manager:
                    return "Manager";

                case enRole.Cashier:
                    return "Cashier";
                default:
                    return "Null";
            }
        }
    }
}
