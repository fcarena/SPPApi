//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class DETALLE_PAGO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DETALLE_PAGO()
        {
            this.DETALLE_PRESTAMO = new HashSet<DETALLE_PRESTAMO>();
        }
    
        public int DETALLE_PAGO_ID { get; set; }
        public int PAGO_ID { get; set; }
        public int PRESTAMO_ID { get; set; }
        public decimal TASA_EFECTIVA { get; set; }
        public decimal MONTO { get; set; }
    
        public virtual PAGO PAGO { get; set; }
        public virtual PRESTAMO PRESTAMO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_PRESTAMO> DETALLE_PRESTAMO { get; set; }
    }
}