using LaptopShop.Forms;
using System;
using System.Windows.Forms;

namespace LaptopShop
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DatabaseManager.UpdateInfo();
            Application.Run(new StartForm());
        }
    }
}
