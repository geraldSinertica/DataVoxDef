//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Repository.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_Moneda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_Moneda()
        {
            this.tb_InmuebleDerecho = new HashSet<tb_InmuebleDerecho>();
            this.tb_InmuebleGravamen = new HashSet<tb_InmuebleGravamen>();
            this.tb_InmuebleMatrices = new HashSet<tb_InmuebleMatrices>();
        }
    
        public short IdMoneda { get; set; }
        public string Sigla { get; set; }
        public string Nombre { get; set; }
        public Nullable<decimal> TipoCambio { get; set; }
        public Nullable<System.DateTime> FechaTipoCambio { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_InmuebleDerecho> tb_InmuebleDerecho { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_InmuebleGravamen> tb_InmuebleGravamen { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_InmuebleMatrices> tb_InmuebleMatrices { get; set; }
    }
}