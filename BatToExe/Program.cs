using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SoftwareByDefault.OpenSource.BatToExe
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Much more elegant than a global try/catch block
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        /// <summary>
        /// Handle application crash a bit more graceful
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            string displayMessage = "BatToExe has encountered an unrecoverable error and needs to close.\r\n";
            displayMessage += "An error log has been saved in the same directory as the application.\r\n";
            displayMessage += "Please help us to improve the software by submitting the error log contents to:";
            displayMessage += "<a href=http://softwarebydefault.com>http://softwarebydefault.com</a>";

            MessageBox.Show(displayMessage, "Application Crash", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
