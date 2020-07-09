using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort2
{
    class SortEngineInsertionSort : ISortEngine
    {
        private bool _sorted = false;
        private int[] TheArray;
        private Graphics g;
        private int MaxVal;
        Brush WhiteBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
        Brush BlackBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);

        public void DoWork(int[] TheArray_ln, Graphics g_ln, int MaxVal_ln)
        {
            TheArray = TheArray_ln;
            g = g_ln;
            MaxVal = MaxVal_ln;

            while (!_sorted)
            {
                for (int i = 0; i < TheArray.Count() - 1; i++)
                {
                    for (int j = i + 1; j > 0; j--)
                    {
                        if (TheArray[j - 1] > TheArray[j])
                        {
                            Swap(j, j-1);
                        }
                    }
                }
                _sorted = IsSorted();
            }
        }

        private void Swap(int j, int p)
        {
            int temp = TheArray[j];
            TheArray[j] = TheArray[j-1];
            TheArray[j-1] = temp;

            g.FillRectangle(BlackBrush, j, 0, 1, MaxVal);
            g.FillRectangle(BlackBrush, j-1, 0, 1, MaxVal);

            g.FillRectangle(WhiteBrush, j, MaxVal - TheArray[j], 1, MaxVal);
            g.FillRectangle(WhiteBrush, j-1, MaxVal - TheArray[j-1], 1, MaxVal);
        }

        private bool IsSorted()
        {
            for (int i = 0; i < TheArray.Count() - 1; i++)
            {
                if (TheArray[i] > TheArray[i+1]) return false;
            }
            return true;
        }
    
    }
}
