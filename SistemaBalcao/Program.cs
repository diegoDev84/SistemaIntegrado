using System;
using System.Windows.Forms;

namespace SistemaBalcao
{
    public static class Program
    {
        public static int NumeroPedido = 1;
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TeleInicial());
        }
    }
}
