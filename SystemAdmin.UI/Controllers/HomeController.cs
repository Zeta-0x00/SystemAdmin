using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SystemAdmin.UI.Models;
using SystemAdmin.UI.Models.ViewModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace SystemAdmin.UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        
        public ActionResult Index()
        {

            List<get_clientes_Result> lst;
            //  return View();
            using (ProyectoEntities db = new ProyectoEntities())
            {
              
                db.Configuration.LazyLoadingEnabled = false;
                lst = db.get_clientes().ToList();
            }
            

            return View(lst);
            
        }


      


    }
}
