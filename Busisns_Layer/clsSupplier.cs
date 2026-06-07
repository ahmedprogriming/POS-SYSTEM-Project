using DataAcsses_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busisns_Layer
{
    public class clsSupplier
    {
        public enum enMode { AddNew = 1, Update = 2 };

        public enMode Mode = enMode.AddNew;
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string Phone {  get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public clsSupplier(int supplierID, string supplierName, string phone,string address,string email)
        {
            SupplierID = supplierID;
            SupplierName = supplierName;
            Phone = phone;
            Email=email;
            Address=address;

            Mode = enMode.Update;
        }

        public clsSupplier()
        {
            this.SupplierID = -1;
            this.SupplierName = "";
            this.Phone = "";
            this.Email = "";
            this.Address= "";

            Mode = enMode.AddNew;
        }

        public static DataTable GetAllSupplier()
        {
            return clsSuppliersData.GetAllSupplier();
        }

        public static clsSupplier GetAllSupplierByID(int Supplierid)
        {
            string Suppliername = "", Phone = "",Email="",Address="";
            if (clsSuppliersData.GetSupplierByID(Supplierid, ref Suppliername, ref Phone,ref Email,ref Address))
            {
                return new clsSupplier(Supplierid, Suppliername,  Phone,  Email,  Address);
            }
            return null;
        }

        private bool _AddnewSupplier()
        {
            this.SupplierID = clsSuppliersData.AddNewSupplier(this.SupplierName, this.Phone,this.Email,this.Address);

            return (this.SupplierID != -1);
        }

        private bool _UpdateSupplier()
        {
            return clsSuppliersData.UpdateSupplier(this.SupplierID, this.SupplierName, this.Phone, this.Email, this.Address);
        }

        public static bool Deleted(int ID)
        {
            return clsSuppliersData.DeleteSupplier(ID);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddnewSupplier())
                    {
                        Mode = enMode.Update;
                        return true;

                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:

                    return _UpdateSupplier();
            }
            return false;
        }
    }
}
