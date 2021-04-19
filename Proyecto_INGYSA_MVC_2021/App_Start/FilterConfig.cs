using System.Web;
using System.Web.Mvc;

namespace Proyecto_INGYSA_MVC_2021
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
