namespace RESERBA_Proj
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();  
            Application.SetHighDpiMode(HighDpiMode.DpiUnaware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            FontManager.LoadFonts();
            Application.Run(new AAAStart());
        }
    }
}