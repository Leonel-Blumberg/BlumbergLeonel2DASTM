using Ejercicio02.Clases;
using Ejercicio02.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02.Gestores
{
    public class GestorCanal(RepositorioPaquetes repositorioPaquetes, RepositorioUsuarios repositorioUsuarios)
    {
        private readonly RepositorioPaquetes repositorioPaquetes = repositorioPaquetes;
        private readonly RepositorioUsuarios repositorioUsuarios = repositorioUsuarios;

        public void AgregarCanal()
        {
            Console.Clear();
            Program.CargarIntro();

            Canal canal = new();
            string paquete = "Estándar";
            bool duplicado = true;

            PedirDatosAgregarCanal(ref canal, ref paquete, ref duplicado);

            if (duplicado)
                Console.WriteLine("| Se ha ingresado el canal correctamente. |\n");
            else
                Console.WriteLine("| El canal ya se encuentra en la base de datos, no se ha agregado el canal al paquete. |\n");

            Console.Write("Oprima un tecla para volver al menú...");
            Console.ReadKey();
        }

        private void PedirDatosAgregarCanal(ref Canal canal, ref string paquete, ref bool duplicado)
        {
            string? respuesta;
            bool bandera;

            do
            {
                Console.Write("Ingrese un nombre para el canal: ");
                respuesta = Console.ReadLine()?.Trim();

                try
                {
                    if (string.IsNullOrEmpty(respuesta))
                        throw new RespuestaInvalidaException("\n| Debe ingresar un nombre para el canal válido. |\n");

                    canal.Nombre = respuesta;
                    bandera = true;
                }
                catch (RespuestaInvalidaException ex)
                {
                    Console.WriteLine(ex.Message);
                    bandera = false;
                }
                catch
                {
                    Console.WriteLine("\n| El nombre del canal no puede tener este número de dígitos. |\n");
                    bandera = false;
                }
            } while (!bandera);

            Console.WriteLine();

            do
            {
                Console.Write("Ingrese el paquete al que pertenece el canal (1: Estándar, 2: Silver, 3: Premium): ");
                respuesta = Console.ReadKey().KeyChar.ToString();
                Console.WriteLine();

                try
                {
                    if (string.IsNullOrEmpty(respuesta))
                        throw new RespuestaInvalidaException("\n| Debe ingresar una respuesta válida. |\n");

                    int paqueteNro = int.Parse(respuesta);

                    if (paqueteNro < 1 || paqueteNro > 3)
                        throw new RespuestaInvalidaException("\n| Debe ser un número entre 1 y 3. |\n");

                    switch (paqueteNro)
                    {
                        case 1:
                            paquete = "Estándar";
                            break;

                        case 2:
                            paquete = "Silver";
                            break;

                        case 3:
                            paquete = "Premium";
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
                    Console.WriteLine("\n| Debe ingresar una respuesta válida. |\n");
                    bandera = false;
                }
            } while (!bandera);

            Console.WriteLine();
            int opcion = 1;

            do
            {

                do
                {
                    Console.Write("¿Desea agregar una serie al canal? (1: Sí, 2: No): ");
                    respuesta = Console.ReadKey().KeyChar.ToString();
                    Console.WriteLine();

                    try
                    {
                        if (string.IsNullOrEmpty(respuesta))
                            throw new RespuestaInvalidaException("\n| Debe ingresar una respuesta válida. |\n");

                        opcion = int.Parse(respuesta);

                        if (opcion < 1 || opcion > 2)
                            throw new RespuestaInvalidaException("\n| Debe ser un número entre 1 y 2. |\n");

                        bandera = true;
                    }
                    catch (RespuestaInvalidaException ex)
                    {
                        Console.WriteLine(ex.Message);
                        bandera = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("\n| Debe ingresar una respuesta válida. |\n");
                        bandera = false;
                    }
                } while (!bandera);

                Console.WriteLine();

                if (opcion == 1)
                {
                    Serie serie = new();

                    do
                    {
                        Console.Write("Ingrese el nombre de la serie: ");
                        respuesta = Console.ReadLine()?.Trim();

                        try
                        {
                            if (string.IsNullOrEmpty(respuesta))
                                throw new RespuestaInvalidaException("\n| El nombre no puede estar vacío. |\n");

                            serie.Nombre = respuesta;
                            bandera = true;
                        }
                        catch (RespuestaInvalidaException ex)
                        {
                            Console.WriteLine(ex.Message);
                            bandera = false;
                        }
                        catch
                        {
                            Console.WriteLine("\n| El nombre de la serie no puede tener este número de dígitos. |\n");
                            bandera = false;
                        }
                    } while (!bandera);

                    Console.WriteLine();

                    do
                    {
                        Console.Write("Ingrese la cantidad de temporadas: ");
                        respuesta = Console.ReadLine()?.Trim();

                        try
                        {
                            if (string.IsNullOrEmpty(respuesta))
                                throw new RespuestaInvalidaException("\n| La cantidad de temporadas no puede estar vacío. |\n");

                            serie.CantidadTemporadas = int.Parse(respuesta);

                            if (serie.CantidadTemporadas < 1)
                                throw new RespuestaInvalidaException("\n| Debe ingresar un número mayor o igual a 1. |\n");

                            bandera = true;
                        }
                        catch (RespuestaInvalidaException ex)
                        {
                            Console.WriteLine(ex.Message);
                            bandera = false;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("\n| Debe ingresar una cantidad de temporadas válida. |\n");
                            bandera = false;
                        }
                        catch
                        {
                            Console.WriteLine("\n| La cantidad de temporadas no puede tener este número de dígitos. |\n");
                            bandera = false;
                        }
                    } while (!bandera);

                    Console.WriteLine();

                    do
                    {
                        Console.Write("Ingrese la cantidad de episodios: ");
                        respuesta = Console.ReadLine()?.Trim();

                        try
                        {
                            if (string.IsNullOrEmpty(respuesta))
                                throw new RespuestaInvalidaException("\n| La cantidad de episodios no puede estar vacío. |\n");

                            serie.CantidadEpisodios = int.Parse(respuesta);

                            if (serie.CantidadEpisodios < 1)
                                throw new RespuestaInvalidaException("\n| Debe ingresar un número mayor o igual a 1. |\n");

                            bandera = true;
                        }
                        catch (RespuestaInvalidaException ex)
                        {
                            Console.WriteLine(ex.Message);
                            bandera = false;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("\n| Debe ingresar una cantidad de episodios de temporadas válida. |\n");
                            bandera = false;
                        }
                        catch
                        {
                            Console.WriteLine("\n| La cantidad de episodios no puede tener este número de dígitos. |\n");
                            bandera = false;
                        }
                    } while (!bandera);

                    Console.WriteLine();

                    do
                    {
                        Console.Write("Ingrese la duración total en minutos: ");
                        respuesta = Console.ReadLine()?.Trim();

                        try
                        {
                            if (string.IsNullOrEmpty(respuesta))
                                throw new RespuestaInvalidaException("\n| La cantidad de episodios no puede estar vacío. |\n");

                            serie.DuracionTot = float.Parse(respuesta);

                            if (serie.DuracionTot < 1)
                                throw new RespuestaInvalidaException("\n| La duración debe ser mayor o igual a 1. |\n");

                            bandera = true;
                        }
                        catch (RespuestaInvalidaException ex)
                        {
                            Console.WriteLine(ex.Message);
                            bandera = false;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("\n| Debe ingresar una duración total válida. |\n");
                            bandera = false;
                        }
                        catch
                        {
                            Console.WriteLine("\n| La duración total no puede tener este número de dígitos. |\n");
                            bandera = false;
                        }
                    } while (!bandera);

                    Console.WriteLine();

                    do
                    {
                        Console.WriteLine("Seleccione el género de la serie:");
                        Console.WriteLine("1. Acción");
                        Console.WriteLine("2. Comedia");
                        Console.WriteLine("3. Drama");
                        Console.WriteLine("4. Terror");
                        Console.WriteLine("5. Romance\n");
                        Console.Write("Opción: ");
                        respuesta = Console.ReadKey().KeyChar.ToString();
                        Console.WriteLine();

                        try
                        {
                            if (string.IsNullOrEmpty(respuesta))
                                throw new RespuestaInvalidaException("\n| El género de la serie no puede estar vacío. |\n");

                            int generoSeleccionado = int.Parse(respuesta);

                            if (generoSeleccionado < 1 || generoSeleccionado > 5)
                                throw new RespuestaInvalidaException("\n| Seleccione una opción entre 1 y 5. |\n");

                            serie.Genero = (Serie.GeneroSerie)generoSeleccionado;
                            bandera = true;
                        }
                        catch (RespuestaInvalidaException ex)
                        {
                            Console.WriteLine(ex.Message);
                            bandera = false;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("\n| Debe ingresar un género válido. |\n");
                            bandera = false;
                        }
                    } while (!bandera);

                    Console.WriteLine();

                    do
                    {
                        Console.Write("Ingrese el nombre del director: ");
                        respuesta = Console.ReadLine()?.Trim();

                        try
                        {
                            if (string.IsNullOrEmpty(respuesta))
                                throw new RespuestaInvalidaException("\n| El director no puede estar vacío. |\n");

                            serie.Director = respuesta;
                            bandera = true;
                        }
                        catch (RespuestaInvalidaException ex)
                        {
                            Console.WriteLine(ex.Message);
                            bandera = false;
                        }
                        catch
                        {
                            Console.WriteLine("\n| El nombre del director no puede tener este número de dígitos. |\n");
                            bandera = false;
                        }
                    } while (!bandera);

                    Console.WriteLine();

                    do
                    {
                        Console.Write("Ingrese el ranking de la serie: ");
                        respuesta = Console.ReadLine()?.Trim();

                        try
                        {
                            if (string.IsNullOrEmpty(respuesta))
                                throw new RespuestaInvalidaException("\n| El ranking no puede ser un valor vacio. |\n");

                            serie.Ranking = float.Parse(respuesta);

                            if (serie.Ranking < 0 || serie.Ranking > 5)
                                throw new RespuestaInvalidaException("\n| El ranking debe estar entre 0 y 5. |\n");

                            bandera = true;
                        }
                        catch (RespuestaInvalidaException ex)
                        {
                            Console.WriteLine(ex.Message);
                            bandera = false;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("\n| Debe ingresar un ranking válido. |\n");
                            bandera = false;
                        }
                        catch
                        {
                            Console.WriteLine("\n| El ranking no puede tener este número de dígitos. |\n");
                            bandera = false;
                        }
                    } while (!bandera);

                    canal.Series.Add(serie);
                    Console.WriteLine("\n| Se ha ingresado la serie correctamente. |\n");
                }
            } while (opcion == 1);

            duplicado = repositorioPaquetes.AgregarCanalPaquete(canal, paquete);
        }

        public void EliminarCanal()
        {
            Console.Clear();
            Program.CargarIntro();

            if (ListarCanales() == true)
            {
                bool bandera;

                do
                {
                    Console.Write("Ingrese el nombre del canal: ");
                    string? respuesta = Console.ReadLine()?.Trim();

                    try
                    {
                        if (string.IsNullOrEmpty(respuesta))
                            throw new RespuestaInvalidaException("\n| El nombre del canal no puede estar vacío. |\n");

                        if (repositorioPaquetes.EliminarCanal(respuesta) == false)
                            throw new CanalNoEncontradoException("\n| No se ha encontrado el canal, por favor intente nuevamente. |\n");

                        bandera = true;
                    }

                    catch (CanalNoEncontradoException ex)
                    {
                        Console.WriteLine(ex.Message);
                        bandera = false;
                    }
                    catch (RespuestaInvalidaException ex)
                    {
                        Console.WriteLine(ex.Message);
                        bandera = false;
                    }
                    catch
                    {
                        Console.WriteLine("\n| El nombre de la serie no puede tener este número de dígitos. |\n");
                        bandera = false;
                    }
                } while (!bandera);

                Console.Write("Oprima un tecla para volver al menú...");
                Console.ReadKey();
            }
            else
            {
                Thread.Sleep(5000); // No hace nada por 5 segundos.

                while (Console.KeyAvailable) // Borra el buffer del teclado.
                    Console.ReadKey(intercept: true);
            }

        }

        private bool ListarCanales()
        {
            List<Canal> todosLosCanales = [];

            foreach (Paquete paquete in repositorioPaquetes.ListarPaquetes())
            {
                if (paquete.Canales != null && paquete.Canales.Count > 0)
                {
                    foreach (Canal canal in paquete.Canales)
                    {
                        if (!todosLosCanales.Any(c => c.Nombre.Equals(canal.Nombre, StringComparison.OrdinalIgnoreCase)))
                            todosLosCanales.Add(canal);
                    }
                }
            }

            if (todosLosCanales.Count == 0)
            {
                Console.WriteLine("|| No hay canales disponibles actualmente. ||\n");
                return false;
            }

            Console.WriteLine("|| Canales disponibles: ||\n");

            int numeroCanal = 1;

            foreach (Canal canal in todosLosCanales)
            {
                Console.WriteLine($"{numeroCanal}. Canal: {canal.Nombre}");
                numeroCanal++;

                Console.WriteLine("   Series:");

                if (canal.Series == null || canal.Series.Count == 0)
                    Console.WriteLine("    No hay series disponibles en este canal.");
                else
                {
                    int numeroSerie = 1;

                    foreach (Serie serie in canal.Series)
                    {
                        Console.WriteLine($"    {numeroSerie}. {serie.Nombre}, {serie.CantidadTemporadas} temporadas, {serie.CantidadEpisodios} episodios, {serie.DuracionTot} horas, {serie.Genero}, {serie.Director}, ranking: {serie.Ranking}");
                        numeroSerie++;
                    }
                }

                Console.WriteLine();
            }

            return true;
        }

        public void ModificarCanal()
        {
            Console.Clear();
            Program.CargarIntro();

            if (ListarCanales() == true)
            {
                bool bandera;

                Canal canal = new();
                string paquete = "Estándar";
                bool duplicado = true;

                do
                {
                    Console.Write("Ingrese el nombre del canal: ");
                    string? respuesta = Console.ReadLine()?.Trim();

                    try
                    {
                        if (string.IsNullOrEmpty(respuesta))
                            throw new RespuestaInvalidaException("\n| El nombre del canal no puede estar vacío. |\n");

                        if (repositorioPaquetes.EliminarCanal(respuesta) == false)
                            throw new CanalNoEncontradoException("\n| No se ha encontrado el canal, por favor intente nuevamente. |\n");

                        PedirDatosAgregarCanal(ref canal, ref paquete, ref duplicado);

                        if (duplicado)
                            Console.WriteLine("| Se ha modificado el canal correctamente. |\n");
                        else
                            Console.WriteLine("| El canal ya se encuentra en la base de datos, no se ha modificado el canal al paquete. |\n");

                        bandera = true;
                    }

                    catch (CanalNoEncontradoException ex)
                    {
                        Console.WriteLine(ex.Message);
                        bandera = false;
                    }
                    catch (RespuestaInvalidaException ex)
                    {
                        Console.WriteLine(ex.Message);
                        bandera = false;
                    }
                    catch
                    {
                        Console.WriteLine("\n| El nombre de la serie no puede tener este número de dígitos. |\n");
                        bandera = false;
                    }
                } while (!bandera);

                Console.Write("Oprima un tecla para volver al menú...");
                Console.ReadKey();
            }
            else
            {
                Thread.Sleep(5000); // No hace nada por 5 segundos.

                while (Console.KeyAvailable) // Borra el buffer del teclado.
                    Console.ReadKey(intercept: true);
            }
        }

        public void ListPaqueCanal()
        {
            Console.Clear();
            Program.CargarIntro();

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
                                Console.WriteLine($"{numeroSerie}. {serie.Nombre}, {serie.CantidadTemporadas} temporadas, {serie.CantidadEpisodios} episodios, {serie.DuracionTot} horas, {serie.Genero}, {serie.Director} (Canal: {canal.Nombre})");
                                numeroSerie++;
                            }
                        }
                    }
                }

                if (!haySeries)
                    Console.WriteLine("    No hay series disponibles en este paquete.");

                Console.WriteLine();
            }

            Console.Write("Oprima un tecla para volver al menú...");
            Console.ReadKey();
        }

        public void ListPaqueClient()
        {
            Console.Clear();
            Program.CargarIntro();

            var usuarios = repositorioUsuarios.ListarUsuarios();

            if (usuarios == null || usuarios.Count == 0)
            {
                Console.WriteLine("| No hay usuarios registrados. |\n");

                Thread.Sleep(5000); // No hace nada por 5 segundos.

                while (Console.KeyAvailable) // Borra el buffer del teclado.
                    Console.ReadKey(intercept: true);
                return;
            }

            foreach (Usuario usuario in usuarios)
            {
                Console.WriteLine($"=== Usuario: {usuario.Nombre} ===\n");

                if (usuario.PaquetesContratados == null || usuario.PaquetesContratados.Count == 0)
                {
                    Console.WriteLine("No tiene paquetes contratados.\n");
                    continue;
                }

                foreach (Paquete paquete in usuario.PaquetesContratados)
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
                                    Console.WriteLine($"{numeroSerie}. {serie.Nombre}, {serie.CantidadTemporadas} temporadas, {serie.CantidadEpisodios} episodios, {serie.DuracionTot} horas, {serie.Genero}, {serie.Director} (Canal: {canal.Nombre})");
                                    numeroSerie++;
                                }
                            }
                        }
                    }

                    if (!haySeries)
                        Console.WriteLine("    No hay series disponibles en este paquete.");

                    Console.WriteLine();
                }

                Console.WriteLine("---------------------------------------\n");
            }

            Console.Write("Oprima una tecla para volver al menú...");
            Console.ReadKey();
        }

        public void VerPaqueMasVend()
        {
            Console.Clear();
            Program.CargarIntro();

            var usuarios = repositorioUsuarios.ListarUsuarios();

            if (usuarios == null || usuarios.Count == 0)
            {
                Console.WriteLine("| No hay usuarios registrados |\n");
                Thread.Sleep(5000); // No hace nada por 5 segundos.

                while (Console.KeyAvailable) // Borra el buffer del teclado.
                    Console.ReadKey(intercept: true);

                return;
            }

            int estandarCount = usuarios.Sum(u => u.PaquetesContratados.Count(p => p is Estandar));
            int silverCount = usuarios.Sum(u => u.PaquetesContratados.Count(p => p is Silver));
            int premiumCount = usuarios.Sum(u => u.PaquetesContratados.Count(p => p is Premium));

            if (estandarCount == 0 && silverCount == 0 && premiumCount == 0)
            {
                Console.WriteLine("Ningún paquete fue contratado este mes.\n");
                Console.Write("Oprima una tecla para volver...");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("|| Paquetes Vendidos Este Mes ||\n");
            Console.WriteLine($"Estándar: {estandarCount}");
            Console.WriteLine($"Silver: {silverCount}");
            Console.WriteLine($"Premium: {premiumCount}\n");

            int max = Math.Max(estandarCount, Math.Max(silverCount, premiumCount));
            List<string> masVendidos = [];

            if (estandarCount == max) masVendidos.Add("Estándar");
            if (silverCount == max) masVendidos.Add("Silver");
            if (premiumCount == max) masVendidos.Add("Premium");

            if (masVendidos.Count > 1)
                Console.WriteLine($"Hay un empate entre los siguientes paquetes más vendidos: {string.Join(", ", masVendidos)}");

            else
            {
                string nombrePaquete = masVendidos[0];

                Console.WriteLine($"El paquete más vendido fue: {nombrePaquete}\n");

                Paquete paqueteMasVendido = repositorioPaquetes.ListarPaquetes().First(p => p.Nombre.Equals(nombrePaquete, StringComparison.OrdinalIgnoreCase));

                Console.WriteLine($"| Paquete {paqueteMasVendido.Nombre} (${paqueteMasVendido.Precio}): |");

                Console.WriteLine(". Canales:");

                if (paqueteMasVendido.Canales == null || paqueteMasVendido.Canales.Count == 0)
                    Console.WriteLine("  No hay canales disponibles en este paquete.");
                else
                {
                    int numeroCanal = 1;
                    foreach (Canal canal in paqueteMasVendido.Canales)
                    {
                        Console.WriteLine($"{numeroCanal}. {canal.Nombre}");
                        numeroCanal++;
                    }
                }

                Console.WriteLine("\n. Series:");
                int numeroSerie = 1;
                bool haySeries = false;

                foreach (Canal canal in paqueteMasVendido.Canales!)
                {
                    foreach (Serie serie in canal.Series)
                    {
                        haySeries = true;
                        Console.WriteLine($"{numeroSerie}. {serie.Nombre}, {serie.CantidadTemporadas} temporadas, {serie.CantidadEpisodios} episodios, {serie.DuracionTot} horas, {serie.Genero}, {serie.Director} (Canal: {canal.Nombre})");
                        numeroSerie++;
                    }
                }

                if (!haySeries)
                    Console.WriteLine("    No hay series disponibles en este paquete.");
            }

            Console.Write("\nOprima una tecla para volver al menú...");
            Console.ReadKey();
        }

        public void VerTotRecauMes()
        {
            decimal total = 0;

            foreach (Usuario usuario in repositorioUsuarios.ListarUsuarios())
                foreach (Paquete paquete in usuario.PaquetesContratados)
                    total += paquete.Precio;

            if (total != 0)
                Console.WriteLine($"\n\nLa empresa lleva recaudado este mes: {total:C}");
            else
                Console.WriteLine($"\n\nTodavia no se han registrado recuadaciones este mes.");

            Console.Write("\nOprima una tecla para volver al menú...");
            Console.ReadKey();
        }
    }
}
