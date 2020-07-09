using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort2
{
    interface ISortEngine
    {
        void DoWork(int[] TheArray, Graphics g, int axVal);
    }
}
