using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02.Clases
{
    public class Serie
    {
        public string Nombre { get; set; } = string.Empty;
        public int CantidadTemporadas { get; set; }
        public int CantidadEpisodios { get; set; }
        public float DuracionTot { get; set; }
        public GeneroSerie Genero { get; set; }
        public string Director { get; set; } = string.Empty;
        public double Ranking { get; set; }

        public enum GeneroSerie
        {
            Accion,
            Comedia,
            Drama,
            Terror,
            Romance
        }
    }
}
