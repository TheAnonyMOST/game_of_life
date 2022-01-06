using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    internal class BlankGridFactory : GridFactory
    {
        private readonly ulong _heigth;
        private readonly ulong _width;

        public BlankGridFactory(ulong h, ulong w)
        {
            this._heigth = h;
            this._width = w;
        }
        public override BaseGrid GetGrid()
        {
            return new BlankGrid(_heigth, _width);
        }
    }
}
