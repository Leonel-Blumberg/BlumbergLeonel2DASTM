using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02.Clases
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public int DNI { get; set; }
        public DateOnly FechaNacimiento { get; set; }
        public List<Paquete> PaquetesContratados { get; set; } = [];
    }
}
