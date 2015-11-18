using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TiendaMVC.Filtros;
using TiendaMVC.Models;

namespace TiendaMVC.Controllers
{
    public class EtiquetaController : Controller
    {
        Tienda11Entities db= new Tienda11Entities();
        
        // GET: Etiqueta
        [FiltroTiempo]
        public ActionResult Index()
        {
            var data = db.Etiqueta;
            ViewBag.losalmacenes = db.Almacen;

            return View(data);
        }
    }
}