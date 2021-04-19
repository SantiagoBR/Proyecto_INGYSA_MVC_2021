using System.Web.Mvc;

namespace Proyecto_INGYSA_MVC_2021.Areas.ACADEMICO
{
    public class ACADEMICOAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "ACADEMICO";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "ACADEMICO_default",
                "ACADEMICO/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}