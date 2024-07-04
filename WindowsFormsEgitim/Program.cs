using System;
using System.Windows.Forms;

namespace WindowsFormsEgitim
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
            Application.Run(new Form5()); // start veya play e basınca açılacak olan form.
        }
    }
}
