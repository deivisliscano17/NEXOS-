using System;
using System.Collections.Generic;

namespace DbFirst2.Models
{
    public partial class Doctores
    {
        public int IdDoctores { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Especialidad { get; set; }
        public int NumeroCredencial { get; set; }
        public string HospitalTrabajo { get; set; }
    }
}
