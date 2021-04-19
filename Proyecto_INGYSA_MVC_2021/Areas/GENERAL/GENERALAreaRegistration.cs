using System.Web.Mvc;

namespace Proyecto_INGYSA_MVC_2021.Areas.GENERAL
{
    public class GENERALAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "GENERAL";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "GENERAL_default",
                "GENERAL/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}