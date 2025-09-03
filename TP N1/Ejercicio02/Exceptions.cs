using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    public class RespuestaInvalidaException(string mensaje) : Exception(mensaje);
    public class UsuarioNoSeleccionadoException(string mensaje) : Exception(mensaje);
    public class CanalNoEncontradoException(string mensaje) : Exception(mensaje);
}
