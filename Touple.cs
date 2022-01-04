using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    struct Tuple<TX, TY> : IEquatable<Tuple<TX, TY>>
    {
        readonly TX x;
        readonly TY y;

        public Tuple(TX first, TY second)
        {
            this.x = first;
            this.y = second;
        }

        public TX First => x;
        public TY Second => y;

        public override int GetHashCode()
        {
            return x.GetHashCode() ^ y.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Equals((Tuple<TX,TY>)obj);
        }

        public bool Equals(Tuple<TX, TY> other)
        {
            return other.x.Equals(x) && other.y.Equals(y);
        }
    }
}
