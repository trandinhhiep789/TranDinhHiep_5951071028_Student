using System.Web;
using System.Web.Mvc;

namespace TranDinhHiep_5951071028
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
