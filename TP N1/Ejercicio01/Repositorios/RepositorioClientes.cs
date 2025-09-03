using Ejercicio011.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio011.Repositorios
{
    internal class RepositorioClientes
    {
        private readonly List<Cliente> ListaClientes = [];

        public RepositorioClientes()
        {
            // Juan: SIN cuentas (para probar el aviso al cliente)
            var juan = new Cliente
            {
                DNI = 12345678,
                Nombre = "Juan",
                Apellido = "Pérez",
                Email = "juan.perez@email.com",
                FechaNacimiento = new DateOnly(1990, 5, 10)
            };

            // María: UNA cuenta (Caja de Ahorro)
            var maria = new Cliente
            {
                DNI = 87654321,
                Nombre = "María",
                Apellido = "Gómez",
                Email = "maria.gomez@email.com",
                FechaNacimiento = new DateOnly(1985, 8, 25)
            };
            var cajaMaria = new CajaDeAhorro
            {
                ID = 1001,
                Saldo = 125000.50m
            };
            maria.Cuentas.Add(cajaMaria);

            // Carlos: DOS cuentas (CC + CA)
            var carlos = new Cliente
            {
                DNI = 11223344,
                Nombre = "Carlos",
                Apellido = "López",
                Email = "carlos.lopez@email.com",
                FechaNacimiento = new DateOnly(1995, 3, 14)
            };
            var ccCarlos = new CuentaCorriente
            {
                ID = 1005,
                Saldo = -3000
            };
            var cajaCarlos = new CajaDeAhorro
            {
                ID = 1009,
                Saldo = 12000m
            };
            carlos.Cuentas.Add(ccCarlos);
            carlos.Cuentas.Add(cajaCarlos);

            // Agrego todos al repositorio
            ListaClientes.AddRange([juan, maria, carlos]);
        }


        public void RegistrarCliente(Cliente cliente)
        {
            ListaClientes.Add(cliente);
        }

        public void EliminarCliente(Cliente cliente)
        {
            ListaClientes.Remove(cliente);
        }

        public IReadOnlyCollection<Cliente> ListarClientes()
        {
            return ListaClientes;
        }
    }
}
