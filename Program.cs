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
            var universe = new BlankGrid(512, 512);
            var scratchPad = new BlankGrid(universe.Height,universe.Width);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TheGameofLife());
        }

        private static void CheckNeighbors(BaseGrid universe, ref BaseGrid scratchPad)
        {
            for (int w = 0; w < (int)scratchPad.Width; w++)
            {
                for (int h = 0; h < (int)scratchPad.Height; h++)
                {
                    var neighbors = new int[8, 2]
                    {
                        {h-1,w-1},
                        {h-1,w},
                        {h-1,w+1},
                        {h,w-1},
                        {h,w+1},
                        {h+1,w-1},
                        {h+1,w},
                        {h+1,w+1},
                    };
                    for (int i = 0; i < neighbors.Length; i++)
                    {
                    }
                }
            }
        }
    }
}
