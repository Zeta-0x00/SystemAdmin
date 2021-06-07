using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SystemAdmin.UI.Controllers
{
    public class NotaController : Controller
    {
        // GET: Nota
        public ActionResult Crear()
        {
            return View();
        }
    }
}