using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Median:Filters
    {
        static int[] ResultR = new int[50];
        static int[] ResultG = new int[50];
        static int[] ResultB = new int[50];
        static int count = 0;
        public static void Medi(Bitmap sourceimage, int x, int y)
        {
            for (int i = -3; i <= 3; i++)
            {
                for (int k = -3; k <= 3; k++)
                {
                    int idx = Clamp(x + k, 0, sourceimage.Width - 1);
                    int idy = Clamp(y + i, 0, sourceimage.Height - 1);
                    Color neighbocolor = sourceimage.GetPixel(idx, idy);
                    ResultR[count] = neighbocolor.R;
                    ResultG[count] = neighbocolor.G;
                    ResultB[count] = neighbocolor.B;
                    count++;
                }

            }
            count = 0;
            Array.Sort(ResultR);
            Array.Sort(ResultG);
            Array.Sort(ResultB);
        }
        public static int middleR()
        {
            return ResultR[25];
        }
        public static int middleG()
        {
            return ResultG[25];
        }
        public static int middleB()
        {
            return ResultB[25];
        }
        protected override Color CalculateNewPixelColour(Bitmap sourceimage, int x, int y)
        {
            Medi(sourceimage, x, y);
            return Color.FromArgb(Clamp(ResultR[25], 0, 255), Clamp(ResultG[25], 0, 255), Clamp(ResultB[25], 0, 255) );
        }
    }
}
