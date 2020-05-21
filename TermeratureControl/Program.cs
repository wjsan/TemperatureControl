using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TemperatureControl
{
    static class Program
    {
        private static App app = new App();

        internal static App App { get => app; set => app = value; }

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            App.LoadData();
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(App.Settings.Language, true);
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(App.Settings.Language, true);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            App.Screens = new Screens();
            Application.Run(App.Screens.StartScreen);
        }
    }
}
