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
    
    public partial class tb_MuebleParteGravamen
    {
        public int IdParteGravamen { get; set; }
        public int idGravamen { get; set; }
        public Nullable<int> idPersona { get; set; }
        public string NumeroParte { get; set; }
        public string TipoParte { get; set; }
        public string TomoConstitucion { get; set; }
        public string AsientoConstitucion { get; set; }
        public string SecuenciaConstitucion { get; set; }
        public Nullable<System.DateTime> FechaConstitucion { get; set; }
        public Nullable<int> IdFuente { get; set; }
    
        public virtual tb_MuebleGravamen tb_MuebleGravamen { get; set; }
    }
}
