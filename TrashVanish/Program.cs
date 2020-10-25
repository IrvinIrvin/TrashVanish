using System;
using System.Windows.Forms;
using TrashVanish.Classes;

namespace TrashVanish
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            currentCulture.setLanguageForCurrentCulture();
            Application.Run(new MainWindow());
        }
    }
}