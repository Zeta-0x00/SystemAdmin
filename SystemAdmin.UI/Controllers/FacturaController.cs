using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SystemAdmin.UI.Controllers
{
    public class FacturaController : Controller
    {
        // GET: Factura
        public ActionResult Crear()
        {
            return View();
        }

        public ActionResult Editar()
        {
            return View();
        }
    }
}