using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SystemAdmin.UI.Models.ViewModels
{
    public class ListClientesViewModel
    {
        public string cedula { get; set; }
        public string nombre { get; set; }
        public float saldoGeneral { get; set; }
        public string direcconExacta { get; set; }
        public string idDistrito { get; set; }
        
    }
}