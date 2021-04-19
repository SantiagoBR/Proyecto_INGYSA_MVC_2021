using System.Web.Mvc;

namespace Proyecto_INGYSA_MVC_2021.Areas.COLEGIOS
{
    public class COLEGIOSAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "COLEGIOS";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "COLEGIOS_default",
                "COLEGIOS/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}