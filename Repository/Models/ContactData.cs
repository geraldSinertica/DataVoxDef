using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class ContactData
    {
        public ContactData()
        {
            Direcciones = new List<tb_Direccion>();
            Telefonos = new List<tb_Telefono>();
        }
        public List<tb_Telefono> Telefonos { get; set; }
        public List<tb_Direccion> Direcciones { get; set; }
    }
}
