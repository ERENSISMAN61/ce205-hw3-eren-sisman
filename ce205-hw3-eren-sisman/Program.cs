using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ce205_hw3_eren_sisman
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
            Application.Run(new MnFrm());
        }
    }
}
