using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
     class BlureFilter:MatrixFilters
    {
        public BlureFilter()
        {
            int sizeX = 3;
            kernel = new float[sizeX, sizeX];
            for (int i = 0; i < sizeX; i++)
            {
                for (int j = 0; j < sizeX; j++)
                {
                    kernel[i, j] = 1.0f / (float)(9);
                }
            }
        }
    }
}
