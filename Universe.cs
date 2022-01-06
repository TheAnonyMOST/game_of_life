using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Universe
    {
        public Cell[,] cells
        {
            get;
        }

        public Universe(int width, int height)
        {
            cells = new Cell[width, height];
            for (int w = 0; w < width; w++)
            {
                for (int h = 0; h < height; h++)
                {
                    var cell = new Cell(w,h);
                    cells[w, h] = cell;

                }
            }
        }

    }
}
