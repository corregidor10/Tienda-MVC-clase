using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TiendaMVC.Models;

namespace TiendaMVC.Controllers
{
    public class ProductoAjaxController : Controller
    {
        Tienda11Entities db= new Tienda11Entities();
        // GET: ProductoAjax
        public ActionResult Index()
        {
            return View(db.Producto);
        }

        [OutputCache(Duration = 0, VaryByParam = "*")] // Luis odia el Caché, esto es un anticaché
        public ActionResult Buscar(String nombre)
        {
            var data = db.Producto.Where(o => o.NombreProducto.Contains(nombre));

            return PartialView("_listadoProducto", data);
        }


        public ActionResult Alta(Producto model)
        {
            db.Producto.Add(model);
            db.SaveChanges();
            return Json(model);
        }
    }

   
}