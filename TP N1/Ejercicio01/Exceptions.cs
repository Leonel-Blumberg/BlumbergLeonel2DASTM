using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio011
{
    public class ImporteInvalidoException(string message) : Exception(message) { }
    public class DatoInvalidoException(string message) : Exception(message) { }
    public class ClienteMenorDeEdadException(string message) : Exception(message) { }
}
