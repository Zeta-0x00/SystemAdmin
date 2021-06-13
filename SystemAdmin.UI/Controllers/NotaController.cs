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
    public class NotaController : Controller
    {
        // GET: Nota
        public ActionResult Crear()
        {
            return View();
        }

        public ActionResult Notas()
        {
            List<get_notas_Result> lst;
            //  return View();
            using (ProyectoEntities db = new ProyectoEntities())
            {

                db.Configuration.LazyLoadingEnabled = false;
                lst = db.get_notas().ToList();
            }


            return View(lst);
        }
    }
}