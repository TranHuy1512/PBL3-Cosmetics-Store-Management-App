using PBL3___Cosmetics_Store_Management_App.Views;
using System;
using System.Windows.Forms;

namespace PBL3___Cosmetics_Store_Management_App
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
            Application.Run(new frmMain());
            
        }
    }
}
