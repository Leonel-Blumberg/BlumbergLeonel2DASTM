using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio011.Clases
{
    public abstract class Cuenta
    {
        public int ID { get; set; }
        public decimal Saldo { get; set; }
        public List<Operacion> Operaciones { get; set; } = [];

        public abstract void Extraer(decimal importe);

        public abstract void Depositar(decimal importe);

    }
}
