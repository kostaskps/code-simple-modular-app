using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modular_App.Desktop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.UnhandledException += Application_OnUnhandledException;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ModulesRegistration.Register();

            Application.Run(new MainForm());
        }

        private static void Application_OnUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var unhandledException = e.ExceptionObject as Exception;
            string errorMessage = unhandledException.Message
                + Environment.NewLine
                + Environment.NewLine
                + "The application will close.";
            MessageBox.Show(errorMessage, "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
