using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Repository.Models
{
    public class Report
    {
        public Report()
        {
            Demandas = new List<tb_Juicio>();
            HistorialConsultas = new List<Consulta>();
        }

      
        public ApplicantInformation DatosGenerales { get; set; }
        public Incomes Ingresos { get; set; }
        public States Propiedades { get; set; }
       
        public Operations Obligaciones { get; set; }       
        public List<tb_Juicio> Demandas { get; set; }
        public List<Consulta> HistorialConsultas { get; set; }
    }
}
