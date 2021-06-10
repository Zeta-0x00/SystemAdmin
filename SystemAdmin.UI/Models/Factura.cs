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
    
    public partial class Factura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Factura()
        {
            this.Abono = new HashSet<Abono>();
            this.CuentaPorCobrar = new HashSet<CuentaPorCobrar>();
            this.Nota = new HashSet<Nota>();
        }
    
        public string idFactura { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public decimal montoBruto { get; set; }
        public Nullable<decimal> montoDescuento { get; set; }
        public decimal montoImpuesto { get; set; }
        public decimal montoNeto { get; set; }
        public string notas { get; set; }
        public bool credito { get; set; }
        public bool contado { get; set; }
        public string cedula { get; set; }
        public string idSucursal { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Abono> Abono { get; set; }
        public virtual Cliente Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CuentaPorCobrar> CuentaPorCobrar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Nota> Nota { get; set; }
        public virtual Sucursal Sucursal { get; set; }
    }
}
