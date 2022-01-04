using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    internal class Grid
    {
        private Cell[,] cells;
        private ulong _height, _width;

 
        public Grid(ulong height, ulong width)
        {
            _height = height;
            _width = width;
            cells = new Cell[width,height];
        }

        private static Cell[,] CreateGrid(ulong w, ulong h, ref Cell[,] cells)
        {
            /*
             * Populates the 2 dimensional grid of cells.
             */

            for (ulong i = 0; i < w; i++)
            {
                for (ulong j = 0; j < h; j++)
                {
                    var cell = new Cell(i, j);
                    cells[i, j] = cell;
                }
            }

            return cells;
        }

    }
}
