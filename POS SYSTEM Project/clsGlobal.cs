using Busisns_Layer;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_SYSTEM_Project
{
    public class clsGlobal
    {
        public static clsUsers Currentuser {  get; set; }

        public static bool RememberUsernameAndPassword(string username, string password)
        {

            try
            {
                string Keypath = @"HKEY_CURRENT_USER\Software\User_POS_SYSTEM_Login";
                string valueName = "Date_Login_User";
                string valueDate = username + "#//#" + password;
  
                Registry.SetValue(Keypath, valueName, valueDate, RegistryValueKind.String);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;

            }
        }

        public static bool GetStoredCredential(ref string username, ref string password)
        {
            try
            {
                string Keypath = @"HKEY_CURRENT_USER\Software\User_POS_SYSTEM_Login";
                string valueName = "Date_Login_User";

                string value = Registry.GetValue(Keypath, valueName, null) as string;
                if (value != null)
                {
                    string[] datavalue = value.Split(new string[] { "#//#" }, StringSplitOptions.None);

                    if (datavalue.Length > 1)
                    {
                        username = datavalue[0];
                        password = datavalue[1];
                        return true;
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }
    }
}
