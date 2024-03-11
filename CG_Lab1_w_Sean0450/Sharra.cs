using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Sharra:Bordersf
    {
        public Sharra()
        {
            kernel = new float[3, 3] { { 3, 10, 3 }, { 0, 0, 0 }, { -3, -10, -3 } };
            kernel2 = new float[3, 3] { { 3, 0, -3 }, { 10, 0, -10 }, { 3, 0, -3 } };
        }
    }
}
