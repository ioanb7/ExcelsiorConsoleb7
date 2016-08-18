using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelsiorConsoleb7
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var window = new ExcelsiorConsole.MainWindow(
                            new ExcelsiorConsole.ConsoleWindow(
                                new ExcelsiorConsole.ConsoleWindowSettings
                                {
                                    Font = new System.Drawing.Font("Consolas", 12.0f)
                                }));
            window.Height = 640;
            window.Width = 420;
            Application.Run(window);
        }
    }
}
