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
    
    public partial class tb_PersonaVinculo
    {
        public int IdVinculo { get; set; }
        public Nullable<int> IdPersona { get; set; }
        public Nullable<short> IdVinculoTipo { get; set; }
        public Nullable<int> IdVinculoPersona { get; set; }
        public Nullable<System.DateTime> FechaVinculo { get; set; }
        public Nullable<int> IdFuente { get; set; }
    
        public virtual tb_Persona tb_Persona { get; set; }
        public virtual tb_Persona tb_Persona1 { get; set; }
        public virtual tb_PersonaTipoVinculo tb_PersonaTipoVinculo { get; set; }
    }
}