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
    
    public partial class tb_InmuebleParteGravamen
    {
        public int IdParte { get; set; }
        public int IdGravamen { get; set; }
        public int IdPersona { get; set; }
        public string TomoGravamen { get; set; }
        public string AsientoGravamen { get; set; }
        public string ConsecGravamen { get; set; }
        public string SecuenciaGravamen { get; set; }
        public string SubSecuenciaGravamen { get; set; }
        public Nullable<short> SecuenciaParte { get; set; }
        public string CausaAdquisitiva { get; set; }
        public Nullable<decimal> Monto { get; set; }
        public System.DateTime FechaActualizacion { get; set; }
        public Nullable<int> IdFuente { get; set; }
    
        public virtual tb_InmuebleGravamen tb_InmuebleGravamen { get; set; }
        public virtual tb_Persona tb_Persona { get; set; }
    }
}
