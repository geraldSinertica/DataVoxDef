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
    
    public partial class tb_Ejecutivo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_Ejecutivo()
        {
            this.tb_Cliente = new HashSet<tb_Cliente>();
        }
    
        public short IdEjecutivo { get; set; }
        public Nullable<int> IdPersona { get; set; }
        public string NombreEjecutivo { get; set; }
        public string Estado { get; set; }
        public string CorreoNotificacion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Cliente> tb_Cliente { get; set; }
    }
}
