using System;
using System.Collections.Generic;

namespace DbFirst2.Models
{
    public partial class Pacientes
    {
        public int IdPacientes { get; set; }
        public int IdDoctores { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Genero { get; set; }
        public int Edad { get; set; }
        public int NumeroSeguroSocial { get; set; }
        public int CodigoPostal { get; set; }
        public string Direccion { get; set; }
        public int TelefonoContacto { get; set; }
    }
}
