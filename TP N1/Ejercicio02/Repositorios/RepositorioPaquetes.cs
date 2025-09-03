using Ejercicio02.Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02.Repositorios
{
    public class RepositorioPaquetes
    {
        private readonly List<Paquete> listaPaquetes =
        [
            new Estandar(),
            new Silver(),
            new Premium()
        ];

        public IReadOnlyCollection<Paquete> ListarPaquetes()
        {
            return listaPaquetes;
        }

        public bool AgregarCanalPaquete(Canal canal, string tipoPaquete)
        {
            Paquete paquete = listaPaquetes.First(x => x.Nombre == tipoPaquete);

            if (!paquete.Canales.Any(c => c.Nombre == canal.Nombre))
            {
                paquete.Canales.Add(canal);
                return true;
            }

            return false;
        }

        public bool EliminarCanal(string respuesta)
        {
            bool canalEliminado = false;

            foreach (Paquete paquete in listaPaquetes)
            {
                Canal? canalAEliminar = paquete.Canales.FirstOrDefault(c => c.Nombre.Equals(respuesta, StringComparison.OrdinalIgnoreCase));

                if (canalAEliminar != null)
                {
                    paquete.Canales.Remove(canalAEliminar);
                    canalEliminado = true;
                }
            }

            return canalEliminado;
        }
    }
}
