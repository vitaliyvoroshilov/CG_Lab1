using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Erosion: Filters
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
            if ((x >= n/2) && (x < sourceimage.Width - n/2) && (y >= n/2) && (y < sourceimage.Height - n/2))
            {
                int minR = 255, minG = 255, minB = 255;
                for (int j = 0; j < n; j++)
                    for (int i = 0; i < n; i++)
                    {
                        if ((tool[i, j] == 1) && (sourceimage.GetPixel(x, y).R < minR))
                            minR = sourceimage.GetPixel(x + i - n / 2, y + j - n / 2).R;
                        if ((tool[i, j] == 1) && (sourceimage.GetPixel(x, y).G < minG))
                            minG = sourceimage.GetPixel(x + i - n / 2, y + j - n / 2).G;
                        if ((tool[i, j] == 1) && (sourceimage.GetPixel(x, y).B < minB))
                            minB = sourceimage.GetPixel(x + i - n / 2, y + j - n / 2).B;
                    }
                return Color.FromArgb(minR, minG, minB);
            }
            return sourceimage.GetPixel(x, y);
        }
    }
}
