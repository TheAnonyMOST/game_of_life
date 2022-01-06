using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static GameOfLife.BaseGrid;

namespace GameOfLife
{
    internal class BlankGrid : BaseGrid
    {
        /*
         * One of the classes that are called to create the grid of cells.
         * BlankGrid is the default grid.
         */

        public override ulong Width { get; }
        public override ulong Height { get; }
        public sealed override Cell[,] Grid { get; protected set; }


        public BlankGrid(ulong height, ulong width)
        {
            Width = width;
            Height = height;
            Grid = new Cell[width, height];
            for (ulong i = 0; i < width; i++)
            {
                for (ulong j = 0; j < height; j++)
                {
                    var cell = new Cell(i, j);
                    Grid[i, j] = cell;
                }
            }


        }

    }
}
