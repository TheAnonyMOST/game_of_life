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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TheGameofLife());

        }

        private static void CheckCells(Universe universe ,ref Universe sketchPad)
        {
            for (ulong x= 0; x < universe.Width; x++)
            {
                for (ulong y = 0; y < universe.Height; y++)
                {
                    switch (universe.cells[x,y].State)
                    {
                        case true when universe.cells[x, y].CheckNeighborsWrap(universe.cells)>1 && universe.cells[x, y].CheckNeighborsWrap(universe.cells)<4:
                            sketchPad.cells[x, y].State = true;
                            break;
                        case true:
                            sketchPad.cells[x, y].State = false;
                            break;
                        case false:
                            sketchPad.cells[x, y].State = universe.cells[x, y].CheckNeighborsWrap(universe.cells) == 3;
                            break;
                    }
                }
            }
        }
    }

}
