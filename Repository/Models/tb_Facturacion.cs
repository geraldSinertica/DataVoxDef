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
    
    public partial class tb_Facturacion
    {
        public int Id { get; set; }
        public Nullable<int> IdUsuario { get; set; }
        public Nullable<int> IdCliente { get; set; }
        public Nullable<int> IdReporte { get; set; }
        public Nullable<int> IdTipoReporte { get; set; }
    
        public virtual tb_TipoReport tb_TipoReport { get; set; }
    }
}