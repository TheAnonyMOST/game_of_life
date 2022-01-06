using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{

    /// <summary>
    /// One of the classes that are called to create the grid of cells.
    /// This class takes the same height and width parameters, but also takes
    /// an optional int parameter for use as a seed for a random number generator.
    /// This will be called for the "random grid", "random with seed", "random using time".
    /// menu items.
    /// </summary>
    internal class RandomGrid : BaseGrid
    {
        public override ulong Width { get; }
        public override ulong Height { get; }
        public override Cell[,] Grid { get; protected set; }



        public RandomGrid(ulong width, ulong height, [Optional] int? seed )
        {
            var rnd = seed != null ? new Random((int)seed) : new Random();
            Width = width;
            Height = height;
            Grid = new Cell[width, height];
            for (ulong i = 0; i < width; i++)
            {
                for (ulong j = 0; j < height; j++)
                {
                    var random = rnd.Next(10);
                    var cell = random > 4 ? new Cell(i, j) : new Cell(i, j, true);
                    Grid[i, j] = cell;
                }
            }
        }
    }
}
