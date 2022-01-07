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
        public ulong Height { get; }
        public ulong Width { get; }
        public Universe(ulong width, ulong height)
        {
            Height = height;
            Width = width;
            cells = new Cell[Width, Height];
            for (ulong w = 0; w < Width; w++)
            {
                for (ulong h = 0; h < height; h++)
                {
                    var cell = new Cell((int)w,(int)h);
                    cells[w, h] = cell;

                }
            }
        }

        

    }
}
