using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Clarityimage : MatrixFilters
    {
        public Clarityimage()
        {
            int size = 3;
            kernel = new float [size, size];
            for (int i =0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == 1 && j == 1)
                    {
                        kernel[i, j] = 9.0f;
                    }
                    else
                    {
                        kernel[i, j] = -1.0f;
                    }
                }
            }
        }
    }
}
