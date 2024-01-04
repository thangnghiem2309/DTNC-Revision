using System.Web;
using System.Web.Mvc;

namespace NghiemDangDuyThang_2020601070
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
