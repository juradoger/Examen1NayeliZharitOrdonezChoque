namespace SISTEMAGE.VISTA
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            Application.Run(new PersonaVista.PersonaInsertarVista());
            Application.Run(new PersonaVista.PersonaListaVista());
            Application.Run(new EmpleadoVista.EmpleadoInsertarVista());
            Application.Run(new EmpleadoVista.EmpleadoListarVista());

        }
    }
}