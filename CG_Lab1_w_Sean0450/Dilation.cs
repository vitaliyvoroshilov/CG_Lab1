using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Dilation: Filters
    {
        protected int n = 7;
        protected int[,] tool = { { 0, 0, 1, 1, 1, 0, 0 },
                                  { 0, 1, 1, 1, 1, 1, 0 },
                                  { 1, 1, 1, 1, 1, 1, 1 },
                                  { 1, 1, 1, 1, 1, 1, 1 },
                                  { 1, 1, 1, 1, 1, 1, 1 },
                                  { 0, 1, 1, 1, 1, 1, 0 },
                                  { 0, 0, 1, 1, 1, 0, 0 } };
        //protected int[,] tool = { { 1, 1, 1 },
        //                          { 1, 1, 1 },
        //                          { 1, 1, 1 } };

        protected override Color CalculateNewPixelColour(Bitmap sourceimage, int x, int y)
        {   
            if ((x >= n/2) && (x < sourceimage.Width - n / 2) && (y >= n/2) && (y < sourceimage.Height - n/2))
            {
                int max = 0;
                for (int j = 0; j < n; j++)
                    for (int i = 0; i < n; i++)
                    {
                        if ((tool[i,j] == 1) && (sourceimage.GetPixel(x, y).R > max))
                            max = sourceimage.GetPixel(x + i - n / 2, y + j - n/2).R;
                    }
                return Color.FromArgb(max, max, max);
            }
            return sourceimage.GetPixel(x, y);    
        }
    }
}
