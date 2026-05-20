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
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public string Description { get; set; }

        public clsCategory(int categoryID, string categoryName, string description  )
        {
            CategoryID = categoryID;
            CategoryName = categoryName;
            Description = description;
        }

        public clsCategory() 
        {
            this.CategoryID = -1;
            this.CategoryName = "";
            this.Description = "";
        
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
    }
}
