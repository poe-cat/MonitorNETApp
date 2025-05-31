using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace KalkulatorApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(new System.Diagnostics.Stopwatch()));
        }
    }
}
