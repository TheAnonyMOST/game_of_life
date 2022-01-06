using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    /// <summary>
    /// An abstract base class that will create the required grid.
    /// </summary>
    internal abstract class GridFactory
    {
        public abstract BaseGrid GetGrid();

        protected GridFactory() {
            this.GetGrid();
        }
    }


}
