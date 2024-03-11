using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Prewitt: Bordersf
    {
        public Prewitt()
        {
            kernel = new float[3, 3] { { -1, -1, -1 }, { 0, 0, 0 }, { 1, 1, 1 } };
            kernel2 = new float[3, 3] { { -1, 0, 1 }, { -1, 0, 1 }, { -1, 0, 1 } };
        }
    }
}
