namespace TP_N2___CRUD_con_Sql_Server_y_ADO.NET
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