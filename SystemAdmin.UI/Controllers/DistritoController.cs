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
    public class DistritoController : Controller
    {
        // GET: Distrito
        public ActionResult Crear()
        {
            return View();
        }
        public ActionResult Editar()
        {
            return View();
        }
        public ActionResult Distritos()
        {
            List<get_distritos_Result> lst;
            //  return View();
            using (ProyectoEntities db = new ProyectoEntities())
            {

                db.Configuration.LazyLoadingEnabled = false;
                lst = db.get_distritos().ToList();
            }


            return View(lst);
        }
    }
}