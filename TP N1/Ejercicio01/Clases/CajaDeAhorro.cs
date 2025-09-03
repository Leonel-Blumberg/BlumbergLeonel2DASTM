using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio011.Clases
{
    internal class CajaDeAhorro : Cuenta
    {
        private const decimal LimiteExtraccion = 20000m;

        public override void Extraer(decimal importe)
        {
            if (importe <= 0)
                throw new ArgumentException("El importe debe ser positivo.");

            if (importe > LimiteExtraccion)
                throw new InvalidOperationException($"\nNo puede extraer más de {LimiteExtraccion:C} en una sola operación.");

            if (importe > Saldo)
                throw new InvalidOperationException("\nFondos insuficientes para realizar la extracción.");

            Saldo -= importe;

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine($"Se ha extraído de la cuenta: {importe:C}\nNuevo saldo: {Saldo:C}");
            Console.WriteLine("--------------------------------------------------\n");
            Console.ResetColor();

            Operacion operacion = new()
            {
                Fecha = DateTime.Now,
                Tipo = TipoOperacion.Extraccion,
                Importe = importe
            };

            Operaciones.Add(operacion);
        }

        public override void Depositar(decimal importe)
        {
            if (importe <= 0)
                throw new ArgumentException("El importe debe ser positivo.");

            Saldo += importe;

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine($"Se ha depositado en la cuenta: {importe:C}\nNuevo saldo: {Saldo:C}");
            Console.WriteLine("--------------------------------------------------\n");
            Console.ResetColor();

            Operacion operacion = new()
            {
                Fecha = DateTime.Now,
                Tipo = TipoOperacion.Deposito,
                Importe = importe
            };

            Operaciones.Add(operacion);
        }
    }
}
