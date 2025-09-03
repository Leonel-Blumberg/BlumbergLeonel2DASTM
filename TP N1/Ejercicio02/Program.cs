using Ejercicio02.Gestores;
using Ejercicio02.Repositorios;
using System.Runtime.CompilerServices;

namespace Ejercicio02
{
    public class Program
    {
        private static readonly RepositorioPaquetes repositorioPaquetes = new();
        private static readonly RepositorioUsuarios repositorioUsuarios = new();

        private static readonly GestorCanal gestorCanal = new(repositorioPaquetes, repositorioUsuarios);
        private static readonly GestorUsuario gestorUsuario = new(repositorioPaquetes, repositorioUsuarios);

        private static void Main()
        {
            CargarMenu();
        }

        public static void CargarIntro()
        {
            Console.WriteLine(" ----------------------------------");
            Console.WriteLine("| CABLES Y PAQUETES DE PROMOCIONES |");
            Console.WriteLine(" ----------------------------------\n");
        }

        private static void CargarMenu()
        {
            do
            {
                Console.Clear();
                CargarIntro();

                Console.WriteLine("| MENÚ |");
                Console.WriteLine("1. Usuario");
                Console.WriteLine("2. Administrador");
                Console.WriteLine("3. Salir\n");

                bool bandera;
                int opcion = 5;

                do
                {
                    Console.Write("Seleccione una opción: ");
                    string opcionSeleccionada = Console.ReadKey().KeyChar.ToString();

                    try
                    {
                        opcion = int.Parse(opcionSeleccionada);

                        if (opcion < 1 || opcion > 3)
                            throw new RespuestaInvalidaException("\n\n| Debe ingresar un número entre 1 y 3. |\n");

                        bandera = true;
                    }
                    catch (RespuestaInvalidaException ex)
                    {
                        Console.WriteLine(ex.Message);
                        bandera = false;
                    }
                    catch
                    {
                        Console.WriteLine("\n\n| Debe ingresar una opción válida. |\n");
                        bandera = false;
                    }
                } while (!bandera);

                switch (opcion)
                {
                    case 1:
                        CargarMenuUsuarios();
                        break;

                    case 2:
                        CargarMenuAdministrador();
                        break;

                    case 3:
                    default:
                        Salir();
                        break;
                }
            } while (true);
        }

        public static void CargarMenuUsuarios()
        {
            do
            {
                Console.Clear();
                CargarIntro();

                Console.WriteLine("| MENÚ USUARIO |");
                Console.WriteLine("1. Seleccionar usuario.");
                Console.WriteLine("2. Listar todos los paquetes y canales.");
                Console.WriteLine("3. Contratar paquete.");
                Console.WriteLine("4. Listar series con un ranking mayor a 3,5.\n");
                Console.WriteLine("5. Volver al menú principal.");
                Console.WriteLine("6. Salir\n");

                bool bandera;
                int opcion = 6;

                do
                {
                    Console.Write("Seleccione una opción: ");
                    string opcionSeleccionada = Console.ReadKey().KeyChar.ToString();

                    try
                    {
                        opcion = int.Parse(opcionSeleccionada);

                        if (opcion < 1 || opcion > 6)
                            throw new RespuestaInvalidaException("\n\n| Debe ingresar un número entre 1 y 6. |\n");

                        bandera = true;
                    }
                    catch (RespuestaInvalidaException ex)
                    {
                        Console.WriteLine(ex.Message);
                        bandera = false;
                    }
                    catch
                    {
                        Console.WriteLine("\n\n| Debe ingresar una opción válida. |\n");
                        bandera = false;
                    }
                } while (!bandera);

                switch (opcion)
                {
                    case 1:
                        gestorUsuario.SelecUsua();
                        break;

                    case 2:
                        gestorUsuario.ListPaqueCanal();
                        break;

                    case 3:
                        gestorUsuario.ContrPaque();
                        break;

                    case 4:
                        gestorUsuario.MostrarSeriesConRankingMayorA35();
                        break;

                    case 5:
                        CargarMenu();
                        break;

                    default:
                        Salir();
                        break;
                }
            } while (true);
        }

        public static void CargarMenuAdministrador()
        {
            do
            {
                Console.Clear();
                CargarIntro();

                Console.WriteLine("| MENÚ ADMINISTRADOR |");
                Console.WriteLine("1. Agregar canal.");
                Console.WriteLine("2. Eliminar canal.");
                Console.WriteLine("3. Modificar canal.");
                Console.WriteLine("4. Listar todos los paquetes y canales.");
                Console.WriteLine("5. Listar paquetes contratados por clientes.");
                Console.WriteLine("6. Ver total recaudado por la empresa en el mes.");
                Console.WriteLine("7. Ver paquete más vendido.\n");
                Console.WriteLine("8. Volver al menú.");
                Console.WriteLine("9. Salir\n");

                bool bandera;
                int opcion = 5;

                do
                {
                    Console.Write("Seleccione una opción: ");
                    string opcionSeleccionada = Console.ReadKey().KeyChar.ToString();

                    try
                    {
                        opcion = int.Parse(opcionSeleccionada);

                        if (opcion < 1 || opcion > 9)
                            throw new RespuestaInvalidaException("\n\n| Debe ingresar un número entre 1 y 9. |\n");

                        bandera = true;
                    }
                    catch (RespuestaInvalidaException ex)
                    {
                        Console.WriteLine(ex.Message);
                        bandera = false;
                    }
                    catch
                    {
                        Console.WriteLine("\n\n| Debe ingresar una opción válida. |\n");
                        bandera = false;
                    }
                } while (!bandera);

                switch (opcion)
                {
                    case 1:
                        gestorCanal.AgregarCanal();
                        break;

                    case 2:
                        gestorCanal.EliminarCanal();
                        break;

                    case 3:
                        gestorCanal.ModificarCanal();
                        break;

                    case 4:
                        gestorCanal.ListPaqueCanal();
                        break;

                    case 5:
                        gestorCanal.ListPaqueClient();
                        break;

                    case 6:
                        gestorCanal.VerTotRecauMes();
                        break;

                    case 7:
                        gestorCanal.VerPaqueMasVend();
                        break;

                    case 8:
                        CargarMenu();
                        break;

                    case 9:
                    default:
                        Salir();
                        break;
                }
            } while (true);
        }

        private static void Salir()
        {
            Console.Clear();
            Console.WriteLine("¡Gracias por usar la aplicación!");
            Environment.Exit(0);
        }
    }
}
