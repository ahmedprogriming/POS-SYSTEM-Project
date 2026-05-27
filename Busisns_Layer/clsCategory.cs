using DataAcsses_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busisns_Layer
{
    public class clsCategory
    {
        public enum enMode { AddNew = 1, Update = 2 };

        public enMode Mode = enMode.AddNew;
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public string Description { get; set; }

        public clsCategory(int categoryID, string categoryName, string description  )
        {
            CategoryID = categoryID;
            CategoryName = categoryName;
            Description = description;

            Mode= enMode.Update;
        }

        public clsCategory() 
        {
            this.CategoryID = -1;
            this.CategoryName = "";
            this.Description = "";
            Mode = enMode.AddNew;
        }

        public static DataTable GetAllCategries()
        {
            return clsCategoryData.GetAllCategory();
        }

        public static clsCategory GetAllCategoriesByID(int categoryID)
        {
            string CateName = "", Descrip = "";
            if(clsCategoryData.GetCategoryByID(categoryID,ref CateName,ref Descrip))
            {
                return new clsCategory(categoryID,CateName,Descrip);
            }
            return null;
        }

        public static clsCategory GetAllCategoriesByName(string NameCategory)
        {
            int categoryID = -1;string Descrip = "";
            if (clsCategoryData.GetCategoryByName(NameCategory, ref categoryID, ref Descrip))
            {
                return new clsCategory(categoryID, NameCategory, Descrip);
            }
            return null;
        }
        private bool _AddnewCategories()
        {
            this.CategoryID = clsCategoryData.AddNewCategory(this.CategoryName, this.Description);

            return (this.CategoryID != -1);
        }

        private bool _UpdateCategories()
        {
            return clsCategoryData.UpdateCategory(this.CategoryID, this.CategoryName, this.Description);
        }

        public static bool Deleted(int ID)
        {
            return clsCategoryData.DeleteCategory(ID);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddnewCategories())
                    {
                        Mode = enMode.Update;
                        return true;

                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:

                    return _UpdateCategories();
            }
            return false;
        }
    }
}
