using System;
using System.Web.Mvc;

namespace TiendaMVC.Filtros
{
    public class FiltroTiempo:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var hora = DateTime.Now;
            if (hora.Minute<30 || hora.Minute>39)
            {
                filterContext.Result= new HttpUnauthorizedResult("No puedes pasar !!");
            }
            base.OnActionExecuting(filterContext);
        }
    }
}