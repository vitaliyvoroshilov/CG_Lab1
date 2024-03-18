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
                int maxR = 0, maxG = 0, maxB = 0;
                for (int j = 0; j < n; j++)
                    for (int i = 0; i < n; i++)
                    {
                        if ((tool[i, j] == 1) && (sourceimage.GetPixel(x, y).R > maxR))
                            maxR = sourceimage.GetPixel(x + i - n / 2, y + j - n / 2).R;
                        if ((tool[i, j] == 1) && (sourceimage.GetPixel(x, y).G > maxG))
                            maxG = sourceimage.GetPixel(x + i - n / 2, y + j - n / 2).G;
                        if ((tool[i, j] == 1) && (sourceimage.GetPixel(x, y).B > maxB))
                            maxB = sourceimage.GetPixel(x + i - n / 2, y + j - n / 2).B;
                    }
                return Color.FromArgb(maxR, maxG, maxB);
            }
            return sourceimage.GetPixel(x, y);    
        }
    }
}
