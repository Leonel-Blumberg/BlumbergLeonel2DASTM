using Ejercicio011.Clases;
using Ejercicio011.Gestores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio011
{
    public class Program
    {
        static void Main()
        {
            MostrarMenu();
            UtilizarOpcion();
        }

        readonly static GestorBanco gestorBanco = new();

        static void MostrarMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("=================================");
            Console.WriteLine("        GESTIÓN DE BANCO");
            Console.WriteLine("=================================\n");

            Console.ResetColor();

            Console.WriteLine("Bienvenido, seleccione si es:\n");

            Console.WriteLine(" 1. Cliente");
            Console.WriteLine(" 2. Administrador");
            Console.WriteLine(" 0. Salir\n");

            Console.ResetColor();
            Console.Write("Opción: ");
        }

        static void MostrarOpcionesCliente()
        {
            bool continuar = true;
            try
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("=================================");
                Console.WriteLine("        MENÚ DE CLIENTE");
                Console.WriteLine("=================================\n");

                Console.ResetColor();

                Console.Write("Ingrese su DNI: ");
                int dni = int.Parse(Console.ReadLine()!);

                Cliente cliente = gestorBanco.BuscarClientePorDNI(dni);

                if (cliente == null)
                {
                    Console.Clear();
                    Console.WriteLine("\nCliente no encontrado. Verifique el DNI.\n");
                    return;
                }

                if (cliente.Cuentas.Count == 0)
                {
                    Console.Clear();
                    Console.WriteLine($"\nEl cliente {cliente.Nombre} {cliente.Apellido} no posee cuentas registradas.");
                    Console.WriteLine("Solicite al administrador la creación de una cuenta.\n");
                    return;
                }

                while (continuar)
                {
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine($"\nBienvenido {cliente.Nombre}, seleccione una de sus cuentas:\n");

                    Console.ResetColor();

                    int opcion = 1;

                    foreach (Cuenta cuenta in cliente.Cuentas)
                    {
                        string tipo = cuenta is CuentaCorriente ? "Cuenta Corriente" : "Caja de Ahorro";
                        Console.WriteLine($" {opcion}. {tipo} | Código: {cuenta.ID}, Saldo: {cuenta.Saldo:C} |");
                        opcion++;
                    }

                    Console.WriteLine(" 0. Volver\n");

                    Console.Write("Opción: ");

                    int seleccion = int.Parse(Console.ReadLine()!);

                    if (seleccion == 0)
                    {
                        Console.Clear();
                        return;
                    }

                    if (seleccion > 0 && seleccion <= cliente.Cuentas.Count)
                    {
                        Cuenta cuentaElegida = cliente.Cuentas[seleccion - 1];

                        if (cuentaElegida is CuentaCorriente cc)
                            GestorBanco.MostrarHomeBankingCC(cc);
                        else if (cuentaElegida is CajaDeAhorro ca)
                            GestorBanco.MostrarHomeBankingCA(ca);
                    }
                    else
                        Console.WriteLine("\nOpción fuera de rango.\n");
                }
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
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static void MostrarOpcionesAdministrador()
        {
            bool continuar = true;

            try
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("=================================");
                Console.WriteLine("      MENÚ DE ADMINISTRADOR");
                Console.WriteLine("=================================\n");
                Console.ResetColor();

                while (continuar)
                {
                    Console.WriteLine("1. Ver todos los clientes");
                    Console.WriteLine("2. Buscar cliente por DNI");
                    Console.WriteLine("3. Crear cuenta a cliente");
                    Console.WriteLine("4. Agregar cliente");
                    Console.WriteLine("5. Eliminar cliente");
                    Console.WriteLine("0. Volver\n");

                    Console.Write("Opción: ");

                    ConsoleKey opcionElegida = Console.ReadKey().Key;

                    switch (opcionElegida)
                    {
                        case ConsoleKey.D1:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("---------------------------------");
                            Console.WriteLine("      LISTA DE CLIENTES");
                            Console.WriteLine("---------------------------------\n");

                            int i = 1;
                            foreach (Cliente cliente in gestorBanco.ListarClientes())
                            {
                                Console.WriteLine($"Cliente nro {i}:\n DNI: {cliente.DNI}\n Nombre y Apellido: {cliente.Nombre} {cliente.Apellido}\n Número de teléfono: {cliente.Telefono}\n Email: {cliente.Email}\n Fecha de nacimiento: {cliente.FechaNacimiento}");

                                cliente.MostrarCuentas();
                                Console.WriteLine();
                                Console.WriteLine("- - - - - - - - - - - - - - - - - - -\n");
                                i++;
                            }

                            Console.ResetColor();

                            break;

                        case ConsoleKey.D2:
                            Console.Write("\nIngrese DNI del cliente: ");
                            int dni = int.Parse(Console.ReadLine()!);
                            Cliente clienteEncontrado = gestorBanco.BuscarClientePorDNI(dni);

                            Console.ForegroundColor = ConsoleColor.White;

                            Console.WriteLine("\n---------------------------------\n");

                            if (clienteEncontrado == null)
                                Console.WriteLine("Cliente no encontrado.\n");
                            else
                                Console.WriteLine($"Cliente encontrado:\n DNI: {clienteEncontrado.DNI}\n Nombre y Apellido: {clienteEncontrado.Nombre} {clienteEncontrado.Apellido}\n Cuentas: {clienteEncontrado.Cuentas.Count}\n");

                            Console.WriteLine("---------------------------------\n");

                            Console.ResetColor();
                            break;

                        case ConsoleKey.D3:
                            Console.Write("\nIngrese DNI del cliente: ");
                            int dniCuenta = int.Parse(Console.ReadLine()!);
                            Cliente clienteCuenta = gestorBanco.BuscarClientePorDNI(dniCuenta);

                            if (clienteCuenta == null)
                                Console.WriteLine("\nCliente no encontrado.\n");
                            else
                            {
                                Console.WriteLine("\nSeleccione tipo de cuenta:");
                                Console.WriteLine("1. Caja de Ahorro");
                                Console.WriteLine("2. Cuenta Corriente");
                                Console.Write("Opción: ");

                                ConsoleKey tipo = Console.ReadKey().Key;


                                Cuenta nuevaCuenta;

                                switch (tipo)
                                {
                                    case ConsoleKey.D1:
                                        nuevaCuenta = new CajaDeAhorro();
                                        break;
                                    case ConsoleKey.D2:
                                        nuevaCuenta = new CuentaCorriente();
                                        break;
                                    default:
                                        Console.WriteLine("\n\nOpción inválida.\n");
                                        return;
                                }

                                Random random = new();
                                int nuevoId;

                                do
                                    nuevoId = random.Next(1000, 20001);
                                while (gestorBanco.ListarClientes()
                                                    .SelectMany(c => c.Cuentas)
                                                    .Any(c => c.ID == nuevoId));

                                nuevaCuenta.ID = nuevoId;

                                clienteCuenta.Cuentas.Add(nuevaCuenta);
                                Console.WriteLine($"\nCuenta creada con éxito para {clienteCuenta.Nombre} {clienteCuenta.Apellido}.\n");
                            }
                            break;

                        case ConsoleKey.D4:
                            gestorBanco.AgregarCliente();
                            break;

                        case ConsoleKey.D5:
                            Console.Write("\nIngrese DNI del cliente a eliminar: ");
                            int dniEliminar = int.Parse(Console.ReadLine()!);
                            Cliente clienteEliminar = gestorBanco.BuscarClientePorDNI(dniEliminar);

                            if (clienteEliminar == null)
                                Console.WriteLine("\nCliente no encontrado.\n");
                            else
                            {
                                gestorBanco.EliminarCliente(clienteEliminar);
                                Console.WriteLine($"\nCliente {clienteEliminar.Nombre} {clienteEliminar.Apellido} eliminado correctamente.\n");
                            }
                            break;

                        case ConsoleKey.D0:
                            Console.Clear();
                            continuar = false;
                            break;

                        default:
                            Console.WriteLine("\nOpción inválida.\n");
                            break;
                    }
                }
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
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static void UtilizarOpcion()
        {
            bool salir = false;

            do
            {
                try
                {
                    ConsoleKey opcionElegida = Console.ReadKey().Key;
                    switch (opcionElegida)
                    {
                        case ConsoleKey.D0:
                            salir = true;
                            Salir();
                            break;
                        case ConsoleKey.D1:
                            MostrarOpcionesCliente();
                            MostrarMenu();
                            break;
                        case ConsoleKey.D2:
                            MostrarOpcionesAdministrador();
                            MostrarMenu();
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("\nPor favor, seleccione una opción válida\n");
                            MostrarMenu();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MostrarMenu();
                }
            } while (!salir);
        }

        private static void Salir()
        {
            Console.Clear();
            Console.WriteLine("¡Gracias por usar la aplicación!");
            Environment.Exit(0);
        }
    }
}
