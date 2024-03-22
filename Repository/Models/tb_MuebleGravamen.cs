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
    
    public partial class tb_MuebleGravamen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_MuebleGravamen()
        {
            this.tb_MuebleParteGravamen = new HashSet<tb_MuebleParteGravamen>();
        }
    
        public int idGravamen { get; set; }
        public string TomoGravamen { get; set; }
        public string AsientoGravamen { get; set; }
        public string SecuenciaGravamen { get; set; }
        public string TipoGravamen { get; set; }
        public Nullable<System.DateTime> FechaInscripcion { get; set; }
        public Nullable<System.DateTime> FechaInicio { get; set; }
        public Nullable<System.DateTime> FechaVencimiento { get; set; }
        public Nullable<int> IdMoneda { get; set; }
        public Nullable<decimal> Monto { get; set; }
        public string Plazo { get; set; }
        public string EstadoGravamen { get; set; }
        public string NumeroSumaria { get; set; }
        public string AutoridadJudicial { get; set; }
        public string Intereses { get; set; }
        public string TomoUltMovimiento { get; set; }
        public string AsientoUltMovimiento { get; set; }
        public string SecuenciaUltMovimiento { get; set; }
        public Nullable<System.DateTime> FechaUltMovimiento { get; set; }
        public Nullable<int> IdFuente { get; set; }
    
        public virtual tb_MuebleGarantia tb_MuebleGarantia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_MuebleParteGravamen> tb_MuebleParteGravamen { get; set; }
    }
}
