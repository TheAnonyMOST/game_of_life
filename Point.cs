using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    internal abstract class Point
    {
        protected Point(ulong x, ulong y)
        {
            X = x;
            Y = y;
        }

        public ulong X { get; }
        public ulong Y { get; }

    }
}
