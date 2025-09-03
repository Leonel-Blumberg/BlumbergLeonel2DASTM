using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio011.Clases
{
    public enum TipoOperacion
    {
        Deposito,
        Extraccion
    }

    public class Operacion
    {
        public DateTime Fecha { get; set; }
        public TipoOperacion Tipo { get; set; }
        public decimal Importe { get; set; }
    }
}
