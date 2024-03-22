﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
   public class PersonalData
    {
        [JsonIgnore]
        public int PersonId { get; set; }
        public string Identificacion { get; set; }
        public int TipoIdentificacion { get; set; }
        public string NombreCompleto { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public char Genero { get; set; }
        public string EstadoDeVida { get; set; }
        public string LugarNacimiento { get; set; }
        public int EstadoCivil { get; set; }
        public int Nacionalidad { get; set; }
        public string NombrePadre { get; set; }
        public string NombreMadre { get; set; }
        public string IdentificationIssue { get; set; }
        public string IdentificacionVencimiento { get; set; }

        public List<tb_PersonaEstadoCivilHistorico> CivilStatusHistoric { get; set; }

    }
}
