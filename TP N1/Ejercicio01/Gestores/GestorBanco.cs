using Ejercicio011.Clases;
using Ejercicio011.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio011.Gestores
{
    internal class GestorBanco
    {
        private readonly RepositorioClientes clientes = new();

        public Cliente BuscarClientePorDNI(int dni)
        {
            Cliente? cliente = clientes.ListarClientes().FirstOrDefault(x => x.DNI == dni);

            return cliente!;
        }

        public static void MostrarHomeBankingCC(CuentaCorriente cuenta)
        {
            try
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("=================================================");
                Console.WriteLine("        HOME BANKING - Cuenta Corriente");
                Console.WriteLine("=================================================\n");
                Console.ResetColor();

                ConsoleKey opcionElegida;
                do
                {
                    Console.WriteLine($"Código: {cuenta.ID}\nSaldo actual: {cuenta.Saldo:C}\n");

                    Console.WriteLine("1. Depositar");
                    Console.WriteLine("2. Extraer");
                    Console.WriteLine("3. Ver operaciones");
                    Console.WriteLine("0. Volver\n");

                    Console.Write("Opción: ");

                    opcionElegida = Console.ReadKey().Key;

                    switch (opcionElegida)
                    {
                        case ConsoleKey.D1:
                            Console.Write("\nIngrese importe a depositar: ");
                            decimal dep = decimal.Parse(Console.ReadLine()!);
                            cuenta.Depositar(dep);
                            break;

                        case ConsoleKey.D2:
                            Console.Write("\nIngrese importe a extraer: ");
                            decimal ext = decimal.Parse(Console.ReadLine()!);
                            cuenta.Extraer(ext);
                            break;

                        case ConsoleKey.D3:
                            Console.Clear();

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("------------------------------------");
                            Console.WriteLine("     HISTORIAL DE OPERACIONES");
                            Console.WriteLine("------------------------------------\n");

                            if (cuenta.Operaciones.Count == 0)
                            {
                                Console.WriteLine("No hay operaciones registradas.\n");
                                Console.ResetColor();
                            }
                            else
                            {
                                int i = 1;
                                foreach (var op in cuenta.Operaciones)
                                {
                                    Console.WriteLine($"Operacion nro {i}:\n Fecha: {op.Fecha:dd/MM/yyyy HH:mm}\n Tipo: {op.Tipo}\n Importe: {op.Importe:C}\n");
                                    i++;
                                }

                                Console.WriteLine("------------------------------------\n");
                            }
                            Console.ResetColor();
                            break;
                    }
                } while (opcionElegida != ConsoleKey.D0);
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nPor favor, selecciones valores/opciones válidas\n");
            }
            catch (FormatException)
            {
                Console.WriteLine("\nLos campos solo aceptan valores numéricos\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void MostrarHomeBankingCA(CajaDeAhorro cuenta)
        {
            try
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("=================================================");
                Console.WriteLine("        HOME BANKING - Caja de Ahorro");
                Console.WriteLine("=================================================\n");
                Console.ResetColor();

                ConsoleKey opcionElegida;
                do
                {
                    Console.WriteLine($"Código: {cuenta.ID}\nSaldo actual: {cuenta.Saldo:C}\n");

                    Console.WriteLine("1. Depositar");
                    Console.WriteLine("2. Extraer");
                    Console.WriteLine("3. Ver operaciones");
                    Console.WriteLine("0. Volver\n");

                    Console.Write("Opción: ");

                    opcionElegida = Console.ReadKey().Key;

                    switch (opcionElegida)
                    {
                        case ConsoleKey.D1:
                            Console.Write("\nIngrese importe a depositar: ");
                            decimal dep = decimal.Parse(Console.ReadLine()!);
                            cuenta.Depositar(dep);
                            break;

                        case ConsoleKey.D2:
                            Console.Write("\nIngrese importe a extraer: ");
                            decimal ext = decimal.Parse(Console.ReadLine()!);
                            cuenta.Extraer(ext);
                            break;

                        case ConsoleKey.D3:
                            Console.Clear();

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("------------------------------------");
                            Console.WriteLine("     HISTORIAL DE OPERACIONES");
                            Console.WriteLine("------------------------------------\n");

                            if (cuenta.Operaciones.Count == 0)
                            {
                                Console.WriteLine("No hay operaciones registradas.\n");
                                Console.ResetColor();
                            }
                            else
                            {
                                int i = 1;
                                foreach (var op in cuenta.Operaciones)
                                {
                                    Console.WriteLine(
                                        $"Operación nro {i}:\n Fecha: {op.Fecha:dd/MM/yyyy HH:mm}\n Tipo: {op.Tipo}\n Importe: {op.Importe:C}\n");
                                    i++;
                                }

                                Console.WriteLine("------------------------------------\n");
                            }
                            Console.ResetColor();
                            break;
                    }

                } while (opcionElegida != ConsoleKey.D0);
            }
            catch (FormatException)
            {
                Console.WriteLine("\nEntrada inválida: solo se aceptan números.\n");
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nNúmero demasiado grande o pequeño.\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public IReadOnlyCollection<Cliente> ListarClientes()
        {
            return clientes.ListarClientes();
        }

        public void AgregarCliente()
        {
            try
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("=================================================");
                Console.WriteLine("              AGREGACIÓN DE CLIENTE");
                Console.WriteLine("=================================================\n");
                Console.ResetColor();

                Console.Write("Ingrese el DNI: ");
                int DNI = int.Parse(Console.ReadLine()!);

                if (DNI < 0)
                    throw new DatoInvalidoException("Por favor, ingrese un DNI válido");

                Console.Write("Ingrese el Nombre: ");
                string nombre = Console.ReadLine()!;

                if (string.IsNullOrWhiteSpace(nombre))
                    throw new DatoInvalidoException("El nombre no puede estar vacío");

                Console.Write("Ingrese el Apellido: ");
                string apellido = Console.ReadLine()!;

                if (string.IsNullOrWhiteSpace(apellido))
                    throw new DatoInvalidoException("El apellido no puede estar vacío");

                Console.Write("Ingrese el Número de teléfono: ");
                string telefono = Console.ReadLine()!;

                if (string.IsNullOrWhiteSpace(telefono))
                    throw new DatoInvalidoException("El número de teléfono no puede estar vacío");

                Console.Write("Ingrese el Email: ");
                string email = Console.ReadLine()!;

                if (string.IsNullOrWhiteSpace(email) || !email.Contains('@'))
                    throw new DatoInvalidoException("Por favor, ingrese un email válido");

                Console.Write("Ingrese la Fecha de nacimiento (dd/MM/yyyy): ");

                if (!DateOnly.TryParse(Console.ReadLine(), out DateOnly fechaNacimiento))
                    throw new DatoInvalidoException("Formato de fecha inválido, use dd/MM/yyyy");

                DateOnly hoy = DateOnly.FromDateTime(DateTime.Today);
                int edad = hoy.Year - fechaNacimiento.Year;

                if (fechaNacimiento > hoy.AddYears(-edad))
                    edad--;

                if (edad < 18)
                    throw new ClienteMenorDeEdadException("El cliente debe ser mayor de 18 años");

                Cliente cliente = new()
                {
                    DNI = DNI,
                    Nombre = nombre,
                    Apellido = apellido,
                    Telefono = telefono,
                    Email = email,
                    FechaNacimiento = fechaNacimiento
                };

                clientes.RegistrarCliente(cliente);

                Console.WriteLine("\nSe ha registrado el cliente correctamente.\n");
            }
            catch (FormatException)
            {
                Console.WriteLine("\nEntrada inválida: solo se aceptan números.\n");
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nNúmero demasiado grande o pequeño.\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void EliminarCliente(Cliente cliente)
        {
            clientes.EliminarCliente(cliente);
        }
    }
}
