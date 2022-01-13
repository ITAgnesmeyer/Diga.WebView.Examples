using System;
using System.Windows.Forms;
namespace Diga.WebView.Examples
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            //ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}