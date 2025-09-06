namespace TP_N3___CRUD_con_Sql_Server_y_Dataset
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