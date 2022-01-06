using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    internal class Cell : Point
    {
        public bool State
        {
            get;
            set;
        }

        private ulong _generationsAlive, _generationsDead;

        public Cell(ulong x, ulong y, bool state = false): base(x:x, y: y)
        {
       
            State = state;
            if (state)
            {
                _generationsAlive = 1;
                _generationsDead = 0;
            }
            else
            {
                _generationsDead = 1;
                _generationsDead = 0;
            }
        }

      

        public void Kill()
        {
            if (State)
            {
                State = false;
            }
        }

        public void Birth()
        {
            if (!State)
            {
                State = true;
            }
        }


    }
}
