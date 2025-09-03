using Ejercicio02.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    public abstract class Paquete
    {
        public string Nombre { get; set; } = string.Empty;
        public List<Canal> Canales { get; set; } = [];
        public decimal Precio { get; set; }
    }

    public class Estandar : Paquete
    {
        public Estandar()
        {
            Nombre = "Estándar";
            Precio = 10000;
        }
    }

    public class Silver : Paquete
    {
        public Silver()
        {
            Nombre = "Silver";
            Precio = 11500;
        }
    }

    public class Premium : Paquete
    {
        public Premium()
        {
            Nombre = "Premium";
            Precio = 12000;
        }
    }
}
