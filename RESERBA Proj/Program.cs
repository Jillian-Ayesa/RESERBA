namespace RESERBA_Proj
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.SetCompatibleTextRenderingDefault(true);
            FontManager.LoadFonts();
            Application.Run(new AAAStart());
        }
    }
}
