using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    internal static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Universe universe;
            Universe sketchPad;
            var generation = 0;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TheGameofLife());

        }

        private static void CheckCells(Universe universe ,ref Universe sketchPad)
        {
            var sketchPad = new Universe(universe.Width, universe.Height);
        }
    }

}
