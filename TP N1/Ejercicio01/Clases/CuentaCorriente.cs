using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio011.Clases
{
    internal class CuentaCorriente : Cuenta
    {

        const int SaldoNegativoPermitido = -50000;

        public override void Extraer(decimal importe)
        {
            if (importe <= 0)
                throw new ImporteInvalidoException("El importe debe ser positivo.");

            decimal nuevoSaldo = Saldo - importe;

            if (nuevoSaldo < SaldoNegativoPermitido)
                throw new ImporteInvalidoException("\nNo se puede superar el límite de descubierto (-50.000).");

            Saldo = nuevoSaldo;

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine($"Se ha extraido de la cuenta: {importe:C}\nNuevo saldo: {Saldo:C}");
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
                throw new ImporteInvalidoException("El importe debe ser positivo.");

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
