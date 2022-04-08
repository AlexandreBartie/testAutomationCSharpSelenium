using Dooggy.CORE;

namespace Dooggy.POC
{
    internal static class Program
    {
        static AutomacaoTestes? POC;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            POC = new AutomacaoTestes();

            POC.Start(prmTipoDriver: eTipoDriver.ChromeDriver);
        }
    }
}