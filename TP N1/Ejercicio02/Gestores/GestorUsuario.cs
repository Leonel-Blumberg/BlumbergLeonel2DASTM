using Ejercicio02.Clases;
using Ejercicio02.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02.Gestores
{
    public class GestorUsuario(RepositorioPaquetes repositorioPaquetes, RepositorioUsuarios repositorioUsuarios)
    {
        private readonly RepositorioPaquetes repositorioPaquetes = repositorioPaquetes;
        private readonly RepositorioUsuarios repositorioUsuarios = repositorioUsuarios;

        string? usuarioSeleccionado = null;

        public void SelecUsua()
        {
            Console.Clear();
            Program.CargarIntro();

            Usuario usuario = new();
            string? respuesta;
            bool bandera;

            do
            {
                Console.Write("Ingrese un nombre: ");
                respuesta = Console.ReadLine()?.Trim();

                try
                {
                    if (string.IsNullOrEmpty(respuesta))
                        throw new RespuestaInvalidaException("\n| Debe ingresar un nombre válido. |\n");

                    usuario.Nombre = respuesta;
                    bandera = true;
                }
                catch (RespuestaInvalidaException ex)
                {
                    Console.WriteLine(ex.Message);
                    bandera = false;
                }
                catch
                {
                    Console.WriteLine("\n| El nombre no puede tener este número de dígitos. |\n");
                    bandera = false;
                }
            } while (!bandera);

            Console.WriteLine();

            do
            {
                Console.Write("Ingrese un apellido: ");
                respuesta = Console.ReadLine()?.Trim();

                try
                {
                    if (string.IsNullOrEmpty(respuesta))
                        throw new RespuestaInvalidaException("\n| Debe ingresar un apellido válido. |\n");

                    usuario.Apellido = respuesta;
                    bandera = true;
                }
                catch (RespuestaInvalidaException ex)
                {
                    Console.WriteLine(ex.Message);
                    bandera = false;
                }
                catch
                {
                    Console.WriteLine("\n| El apellido no puede tener este número de dígitos. |\n");
                    bandera = false;
                }
            } while (!bandera);

            Console.WriteLine();

            do
            {
                Console.Write("Ingrese un DNI: ");
                respuesta = Console.ReadLine()?.Trim();

                try
                {
                    if (string.IsNullOrEmpty(respuesta))
                        throw new RespuestaInvalidaException("\n| Debe ingresar un DNI válido. |\n");

                    int DNI = int.Parse(respuesta);

                    usuario.DNI = DNI;
                    bandera = true;
                }
                catch (RespuestaInvalidaException ex)
                {
                    Console.WriteLine(ex.Message);
                    bandera = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("\n| Debe ingresar solo números. |\n");
                    bandera = false;
                }
                catch
                {
                    Console.WriteLine("\n| El DNI no puede tener este número de dígitos. |\n");
                    bandera = false;
                }
            } while (!bandera);

            Console.WriteLine();

            do
            {
                Console.Write("Ingrese un fecha de nacimiento (dd/mm/aaaa): ");
                respuesta = Console.ReadLine()?.Trim();

                try
                {
                    if (string.IsNullOrEmpty(respuesta))
                        throw new RespuestaInvalidaException("\n| Debe ingresar un fecha de nacimiento válida. |\n");

                    DateOnly fechaNacimiento = DateOnly.ParseExact(respuesta, "dd/MM/yyyy");

                    usuario.FechaNacimiento = fechaNacimiento;
                    bandera = true;
                }
                catch (RespuestaInvalidaException ex)
                {
                    Console.WriteLine(ex.Message);
                    bandera = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("\n| Debe ingresar la fecha en el formato: dd/mmm/aaaa. |\n");
                    bandera = false;
                }
                catch
                {
                    Console.WriteLine("\n| La fecha de nacimiento no puede tener este número de dígitos. |\n");
                    bandera = false;
                }
            } while (!bandera);

            repositorioUsuarios.AgregarUsuario(usuario);
            usuarioSeleccionado = usuario.Nombre;

            Console.WriteLine("\n| Se ha seleccionado el usuario correctamente. |\n");

            Console.Write("Oprima un tecla para volver al menú...");
            Console.ReadKey();
        }

        public void ListPaqueCanal()
        {
            Console.Clear();
            Program.CargarIntro();

            ListarPaquetes();

            Console.Write("Oprima un tecla para volver al menú...");
            Console.ReadKey();
        }

        private void ListarPaquetes()
        {
            foreach (Paquete paquete in repositorioPaquetes.ListarPaquetes())
            {
                Console.WriteLine($"| Paquete {paquete.Nombre} (${paquete.Precio}): |");

                Console.WriteLine(". Canales:");

                if (paquete.Canales == null || paquete.Canales.Count == 0)
                    Console.WriteLine("  No hay canales disponibles en este paquete.");

                else
                {
                    int numeroCanal = 1;

                    foreach (Canal canal in paquete.Canales)
                    {
                        Console.WriteLine($"{numeroCanal}. {canal.Nombre}");
                        numeroCanal++;
                    }
                }

                Console.WriteLine("\n. Series:");

                int numeroSerie = 1;
                bool haySeries = false;

                if (paquete.Canales != null)
                {
                    foreach (Canal canal in paquete.Canales)
                    {
                        if (canal.Series != null)
                        {
                            foreach (Serie serie in canal.Series)
                            {
                                haySeries = true;
                                Console.WriteLine($"{numeroSerie}. {serie.Nombre}, {serie.CantidadTemporadas} temporadas, {serie.CantidadEpisodios} episodios, {serie.DuracionTot} horas, {serie.Genero}, {serie.Director}, ranking: {serie.Ranking} (Canal: {canal.Nombre})");
                                numeroSerie++;
                            }
                        }
                    }
                }

                if (!haySeries)
                    Console.WriteLine("    No hay series disponibles en este paquete.");

                Console.WriteLine();
            }
        }

        public void ContrPaque()
        {
            Console.Clear();
            Program.CargarIntro();

            try
            {
                if (usuarioSeleccionado == null)
                    throw new UsuarioNoSeleccionadoException("| No se ha seleccionado ningún usuario. Por favor seleccione uno antes de seleccionar esta opción. |");
            }
            catch (UsuarioNoSeleccionadoException ex)
            {
                Console.Write(ex.Message);
                Thread.Sleep(5000); // No hace nada por 5 segundos.

                while (Console.KeyAvailable) // Borra el buffer del teclado.
                    Console.ReadKey(intercept: true);

                return;
            }

            Console.WriteLine("|| Paquetes disponibles: ||\n");
            ListarPaquetes();

            bool bandera;
            bool duplicado = true;

            do
            {
                Console.Write("Seleccione un paquete (1: Estándar, 2: Silver, 3: Premium): ");
                string respuesta = Console.ReadKey().KeyChar.ToString();

                try
                {
                    if (string.IsNullOrEmpty(respuesta))
                        throw new RespuestaInvalidaException("\n| Debe un número entre 1 y 3. |\n");

                    int paquete = int.Parse(respuesta);

                    if (paquete < 1 || paquete > 3)
                        throw new RespuestaInvalidaException("\n| Debe un número entre 1 y 3. |\n");

                    switch (paquete)
                    {
                        case 1:
                            duplicado = repositorioUsuarios.AgregarContratoPaquete(usuarioSeleccionado, repositorioPaquetes.ListarPaquetes().First(p => p is Estandar));
                            break;

                        case 2:
                            duplicado = repositorioUsuarios.AgregarContratoPaquete(usuarioSeleccionado, repositorioPaquetes.ListarPaquetes().First(p => p is Silver));
                            break;

                        case 3:
                            duplicado = repositorioUsuarios.AgregarContratoPaquete(usuarioSeleccionado, repositorioPaquetes.ListarPaquetes().First(p => p is Premium));
                            break;
                    }

                    bandera = true;
                }
                catch (RespuestaInvalidaException ex)
                {
                    Console.WriteLine(ex.Message);
                    bandera = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("\n| Debe ingresar un paquete válido. |\n");
                    bandera = false;
                }
            } while (!bandera);

            if (duplicado)
                Console.WriteLine("\n| El paquete se débito de su cuenta correctamente. ¡Que lo disfrute! |\n");
            else
                Console.WriteLine("\n| El usuario ya cuenta con el paquete. No se efectuo la compra. |\n");

            Console.Write("Oprima un tecla para volver al menú...");
            Console.ReadKey();
        }

        public void MostrarSeriesConRankingMayorA35()
        {
            var seriesRanking = repositorioPaquetes.ListarPaquetes()
                .SelectMany(paquete => paquete.Canales)
                .SelectMany(canal => canal.Series)
                .Where(serie => serie.Ranking > 3.5)
                .ToList();

            if (seriesRanking.Count == 0)
                Console.WriteLine("\n\n| No hay series con ranking mayor a 3,5. |");
            else
            {
                Console.WriteLine("\n\n|| Series con ranking mayor a 3,5: ||\n");

                foreach (Serie serie in seriesRanking)
                    Console.WriteLine($"- {serie.Nombre} ({serie.Genero}, Dir: {serie.Director}) -> Ranking: {serie.Ranking}");

                Console.WriteLine($"\nTotal: {seriesRanking.Count} series encontradas.");
            }

            Console.Write("\nOprima una tecla para volver al menú...");
            Console.ReadKey();
        }
    }
}
