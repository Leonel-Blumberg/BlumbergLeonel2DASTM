using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio011.Clases
{
    internal class Cliente
    {
        public int DNI { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateOnly FechaNacimiento { get; set; }

        public List<Cuenta> Cuentas { get; set; } = [];

        public void MostrarCuentas()
        {
            Console.WriteLine($"\nCuentas del cliente {Nombre} {Apellido} (DNI: {DNI}): \n");

            if (Cuentas.Count == 0)
            {
                Console.WriteLine("No posee cuentas registradas.");
                return;
            }

            int i = 1;
            foreach (Cuenta cuenta in Cuentas)
            {
                string tipo = cuenta is CuentaCorriente ? "Cuenta Corriente" : "Caja de Ahorro";

                Console.WriteLine($"{i}. {tipo}");
                Console.WriteLine($"   ID: {cuenta.ID}");
                Console.WriteLine($"   Saldo: {cuenta.Saldo:C}");
                i++;
            }
        }

    }
}
