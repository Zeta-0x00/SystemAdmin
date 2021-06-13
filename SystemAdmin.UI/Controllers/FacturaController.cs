using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using SystemAdmin.UI.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;


namespace SystemAdmin.UI.Controllers
{
    public class FacturaController : Controller
    {
        // GET: Factura
        public ActionResult Crear()
        {
            return View();
        }

        public ActionResult Facturas()
        {
            List<get_facturas_Result> lst;
            //  return View();
            using (ProyectoEntities db = new ProyectoEntities())
            {

                db.Configuration.LazyLoadingEnabled = false;
                lst = db.get_facturas().ToList();
            }


            return View(lst);
        }
    }
}