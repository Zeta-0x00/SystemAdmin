//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SystemAdmin.UI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CuentaPorCobrar
    {
        public string codigo { get; set; }
        public int plazo { get; set; }
        public System.DateTime vencimiento { get; set; }
        public decimal saldo { get; set; }
        public string idFactura { get; set; }
        public string cedula { get; set; }
        public string codigoAbono { get; set; }
    
        public virtual Abono Abono { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Factura Factura { get; set; }
    }
}
