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
    
    public partial class tb_HuellaTipoConsulta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_HuellaTipoConsulta()
        {
            this.tb_HuellaBusqueda = new HashSet<tb_HuellaBusqueda>();
        }
    
        public byte IdTipoConsulta { get; set; }
        public string Nombre { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_HuellaBusqueda> tb_HuellaBusqueda { get; set; }
    }
}