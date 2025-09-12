using System;
using System.Collections.Generic;

namespace TP_N4___CRUD_con_Sql_Server_y_Entity_Framework.Models;

public partial class Personas3
{
    public int Id { get; set; }
    public string Nombre { get; set; } = null!;
    public string Correo { get; set; } = null!;
    public DateOnly FechaDeNacimiento { get; set; }
}
