﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort2
{
    class SortEngineBubblecs : ISortEngine
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

            while(!_sorted)
            {
                for(int i = 0; i < TheArray.Count() - 1; i++)
                {
                    if(TheArray[i] > TheArray[i+1])
                    {
                        Swap(i, i + 1);
                    }
                }
                _sorted = IsSorted();
            }

        }
        private void Swap(int i, int p)
        {
            int temp = TheArray[i];
            TheArray[i] = TheArray[i + 1];
            TheArray[i + 1] = temp;

            g.FillRectangle(BlackBrush, i, 0, 1, MaxVal);
            g.FillRectangle(BlackBrush, p, 0, 1, MaxVal);

            g.FillRectangle(WhiteBrush, i, MaxVal - TheArray[i], 1, MaxVal);
            g.FillRectangle(WhiteBrush, p, MaxVal - TheArray[p], 1, MaxVal);
        }

        private bool IsSorted()
        {
            for(int i = 0; i < TheArray.Count() - 1; i++)
            {
                if (TheArray[i] > TheArray[i + 1]) return false;
            }
            return true;
        }
    }
}

