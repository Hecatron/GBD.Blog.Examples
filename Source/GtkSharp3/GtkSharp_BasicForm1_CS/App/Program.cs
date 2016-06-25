using System;
using Gtk;

namespace GtkSharp_BasicForm1_CS.App
{
    /// <summary> A program. </summary>
    static class Program
    {
        /// <summary> The main entry point for the application. </summary>
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
