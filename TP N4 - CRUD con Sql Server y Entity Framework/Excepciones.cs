using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_N4___CRUD_con_Sql_Server_y_Entity_Framework
{
    public class DatoIncompletoException(string mensaje) : Exception(mensaje) { }
}
