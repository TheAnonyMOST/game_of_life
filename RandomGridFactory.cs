using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class RandomGridFactory:GridFactory
    {
        private readonly int _seed;
        private readonly ulong _height, _width;

        public RandomGridFactory(ulong h, ulong w, [Optional] int? seed)
        {
            this._width = w;
            this._height = h;
            if (seed != null) this._seed = (int)seed;
        }

        public override BaseGrid GetGrid()
        {
            return new RandomGrid(_width, _height , _seed);
        }
    }
}
