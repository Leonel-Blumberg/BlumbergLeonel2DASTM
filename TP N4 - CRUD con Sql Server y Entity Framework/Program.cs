namespace TP_N4___CRUD_con_Sql_Server_y_Entity_Framework
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormularioPrincipal());
        }
    }
}