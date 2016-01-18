using System;
using Gtk;

namespace GtkSharp_Test2.App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Init();
            TestForm1 win = TestForm1.Create();
            win.Show();
            Application.Run();
        }
    }
}
