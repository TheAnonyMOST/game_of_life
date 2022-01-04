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
        private bool _state;
        private ulong _generationsAlive, _generationsDead; 

        public Cell(ulong x, ulong y, bool state = false): base(x:x, y: y)
        {
       
            _state = state;
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
            if (_state)
            {
                _state = false;
            }
        }

        public void Birth()
        {
            if (!_state)
            {
                _state = true;
            }
        }


    }
}
