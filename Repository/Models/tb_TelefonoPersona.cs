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
    
    public partial class tb_TelefonoPersona
    {
        public int IdPersona { get; set; }
        public int IdTelefono { get; set; }
        public Nullable<bool> EsOculto { get; set; }
        public Nullable<System.DateTime> FechaOculto { get; set; }
    
        public virtual tb_Persona tb_Persona { get; set; }
        public virtual tb_Telefono tb_Telefono { get; set; }
    }
}