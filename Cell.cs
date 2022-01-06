using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    internal class Cell
    {
        public int X { get; }
        public int Y { get; }
        public  bool State { get; set; }
        public int GenerationsAlive { get; }
        public Cell(int x, int y, bool state = false, int gensAlive = 0)
        {
            this.X = x;
            this.Y = y;
            this.State = state;
            this.GenerationsAlive = State ? gensAlive + 1 : gensAlive;
        }

        /// <summary>
        /// Changes the [State] from true to false
        /// or false to true.
        /// </summary>
        public void Toggle() => State = !State;


        /// <summary>
        /// Checks to see how many of this [Cell]'s neighbors are alive in the given [Universe].
        /// The [Universe]'s grid wraps around for neighbors that would be out of range.
        /// Neighbors are numbered as follows:
        /// -----------
        /// |1 - 2 - 3|
        /// |4 - * - 5|
        /// |6 - 7 - 8|
        /// -----------
        /// where the '*' is this Cell.
        /// </summary>
        /// <param name="cells"></param>
        /// <returns></returns>
        public int CheckNeighborsWrap(Cell[,]cells)
        {
            var livingNeighbors = 0;
            var wrapX = cells.GetLength(0) - 1;
            var wrapY = cells.GetLength(1) - 1;

            var neighbors = new Cell[8]
            {
                // Neighbor 1
                cells[X == 0 ? wrapX : X - 1, Y == 0 ? wrapY : Y - 1],

                // Neighbor 2
                cells[X, Y == 0 ? wrapY : Y - 1],

                // Neighbor 3
                cells[X == wrapX ? 0 : X + 1, Y == 0 ? wrapY : Y - 1],

                // Neighbor 4
                cells[X == 0 ? wrapX : X - 1, Y],

                // Neighbor 5
                cells[X == 0 ? wrapX : X + 1, Y],

                // Neighbor 6
                cells[X == 0 ? wrapX : X - 1, Y == wrapY ? 0 : Y + 1],

                // Neighbor 7
                cells[X, Y == wrapY ? 0 : Y + 1],

                // Neighbor 8
                cells[X == wrapX ? 0 : X + 1, Y == wrapY ? 0 : Y + 1]
            };

            foreach (var neighbor in neighbors)
            {
                if (neighbor.State)
                {
                    livingNeighbors++;
                }  
            }

            return livingNeighbors;
        }

        /// <summary>
        /// Checks to see how many of this [Cell]'s neighbors are alive in the given [Universe].
        /// This check assumes that any neighboring [Cell]s that would be out of the
        /// [Universe]'s range are dead.
        /// Neighbors are numbered as follows:\n
        /// -----------\n
        /// |1 - 2 - 3|\n
        /// |4 - * - 5|\n
        /// |6 - 7 - 8|\n
        /// -----------\n
        /// where the '*' is this Cell.
        /// </summary>
        /// <param name="cells"></param>
        /// <returns></returns>
        public int CheckNeighborsNoWrap(Cell[,] cells)
        {
            var livingNeighbors = 0;
            var limitX = cells.GetLength(0);
            var limitY = cells.GetLength(1);
            var neighborStates = new bool[8]
            {
                // Neighbor 1
                X == 0 || Y == 0 ? false : cells[X - 1, Y - 1].State,

                // Neighbor 2
                Y == 0 ? false : cells[X, Y - 1].State,

                // Neighbor 3
                X == limitX || Y == 0 ? false : cells[X + 1, Y - 1].State,

                // Neighbor 4
                X == 0 ? false : cells[X - 1, Y].State,

                // Neighbor 5
                X == limitX ? false : cells[X + 1, Y].State,

                // Neighbor 6
                X == 0 || Y == limitY ? false : cells[X - 1, Y + 1].State,

                // Neighbor 7
                Y == limitY ? false : cells[X, Y + 1].State,

                // Neighbor 8
                X == limitX || Y == limitY ? false : cells[X + 1, Y + 1].State

            };

            foreach (var val in neighborStates)
            {
                if (val)
                {
                    livingNeighbors++;
                }   
            }

            return livingNeighbors;
        }

    }
}

/*
 *  For reference.
 *   var n1 = cells[X == 0 ? wrapX : X - 1, Y == 0 ? wrapY : Y - 1];
 *   var n2 = cells[X, Y == 0 ? wrapY : Y - 1];
 *   var n3 = cells[X == wrapX ? 0 : X + 1, Y == 0 ? wrapY : Y - 1];
 *   var n4 = cells[X == 0 ? wrapX : X - 1, Y];
 *   var n5 = cells[X == 0 ? wrapX : X + 1, Y];
 *   var n6 = cells[X == 0 ? wrapX : X - 1, Y == wrapY ? 0 : Y + 1];
 *   var n7 = cells[X, Y == wrapY ? 0 : Y + 1];
 *   var n8 = cells[X == wrapX ? 0 : X + 1, Y == wrapY ? 0 : Y + 1];
 **/