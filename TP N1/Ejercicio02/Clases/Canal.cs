using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02.Clases
{
    public class Canal
    {
        public string Nombre { get; set; } = string.Empty;
        public List<Serie> Series { get; set; } = [];
    }
}
