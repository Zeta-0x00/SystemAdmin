using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SystemAdmin.UI.Models;
using SystemAdmin.UI.Models.ViewModels;

namespace SystemAdmin.UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        
        public ActionResult Index()
        {

            List<ListClientesViewModel> lst;
            //  return View();
            using (ProyectoEntities db = new ProyectoEntities())
            {
                lst = (from d in db.Cliente
                       select new ListClientesViewModel
                       {
                           cedula = d.cedula,
                           nombre = d.nombre,
                           saldoGeneral = (float)d.saldoGeneral,
                           direcconExacta = d.direccionExacta,
                           idDistrito = d.idDistrito
                       }).ToList();
            }


            return View(lst);
            
        }



      


    }
}
