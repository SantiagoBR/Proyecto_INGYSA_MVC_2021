using System.Web.Mvc;

namespace Proyecto_INGYSA_MVC_2021.Areas.PERSONAS
{
    public class PERSONASAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "PERSONAS";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "PERSONAS_default",
                "PERSONAS/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}