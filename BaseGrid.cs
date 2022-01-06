using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    internal abstract class BaseGrid
    {
        public abstract ulong Width { get; }
        public abstract ulong Height { get; }
        public abstract Cell[,] Grid { get; protected set; }
    }

}
