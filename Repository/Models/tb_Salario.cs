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
    
    public partial class tb_Salario
    {
        public int idSalario { get; set; }
        public Nullable<int> idPersonaAsalariado { get; set; }
        public Nullable<int> idPersonaPatrono { get; set; }
        public Nullable<decimal> UltimoSalario { get; set; }
        public Nullable<decimal> SalarioPromedio2meses { get; set; }
        public Nullable<decimal> SalarioPromedio3meses { get; set; }
        public Nullable<decimal> SalarioPromedio6meses { get; set; }
        public Nullable<decimal> SalarioPromedio12meses { get; set; }
        public string IdRangoUltSalario { get; set; }
        public string IdRangoPromedio2meses { get; set; }
        public string IdRangoPromedio3meses { get; set; }
        public string IdRangoPromedio6meses { get; set; }
        public string IdRangoPromedio12meses { get; set; }
        public Nullable<short> ConteoMesesLaborados { get; set; }
        public Nullable<System.DateTime> FechaActualizacion { get; set; }
        public Nullable<bool> EsOculto { get; set; }
        public Nullable<System.DateTime> FechaOculto { get; set; }
        public Nullable<int> IdFuente { get; set; }
    
        public virtual tb_Persona tb_Persona { get; set; }
    }
}
