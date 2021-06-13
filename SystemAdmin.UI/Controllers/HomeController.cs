using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SystemAdmin.UI.Models;

using System.ComponentModel.DataAnnotations.Schema;

namespace SystemAdmin.UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        
        public ActionResult Index()
        {

            return View();

        }

    }
}
