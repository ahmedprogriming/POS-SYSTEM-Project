using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess_Layer;
using DataAcsses_Layer;

namespace Busisns_Layer
{
    public class clsReports
    {
        public clsReports() { }

        public static DataTable GetDailySales()
        {
            return clsReportsData.GetAllDailySales();
        }

        public static DataTable GetMonthlyAndYearSales(DateTime StData,DateTime EndDate)
        {
            return clsReportsData.GetAllMonthlyAndYearSales(StData, EndDate);
        }
    }
}
