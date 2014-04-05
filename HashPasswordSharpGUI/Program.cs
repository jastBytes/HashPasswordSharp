using System;
using System.Windows.Forms;

namespace de.janbusch.HashPasswordSharp
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
            Application.Run(new de.janbusch.HashPasswordSharp.HashPasswordSharp());
        }
    }
}
