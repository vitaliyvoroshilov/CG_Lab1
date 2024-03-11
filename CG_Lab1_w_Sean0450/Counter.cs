using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace Lab1
{
    public class Counter
    {
        static int maxR = 0;
        static int maxG = 0;
        static int maxB = 0;
        static int minR = 0;
        static int minG = 0;
        static int minB = 0;
        public static void work(Bitmap sourceimage)
        {
            Bitmap resultImage = new Bitmap(sourceimage.Width, sourceimage.Height);
            if (maxR == 0 && maxG == 0 && maxB == 0)
            {
                for (int i = 0; i < sourceimage.Width; i++)
                {
                    for (int j = 0; j < sourceimage.Height; j++)
                    {
                        if (sourceimage.GetPixel(i, j).R > maxR)
                        {
                            maxR = sourceimage.GetPixel(i, j).R;
                        }
                        if (sourceimage.GetPixel(i, j).G > maxG)
                        {
                            maxG = sourceimage.GetPixel(i, j).G;
                        }
                        if (sourceimage.GetPixel(i, j).B > maxB)
                        {
                            maxB = sourceimage.GetPixel(i, j).B;
                        }
                        if (sourceimage.GetPixel(i, j).R < minR)
                        {
                            minR = sourceimage.GetPixel(i, j).R;
                        }
                        if (sourceimage.GetPixel(i, j).G < minG)
                        {
                            minG = sourceimage.GetPixel(i, j).G;
                        }
                        if (sourceimage.GetPixel(i, j).B < minB)
                        {
                            minB = sourceimage.GetPixel(i, j).B;
                        }
                    }
                }
            }
            
            
        }
        public static int mxR()
        {
            return maxR;
        }
        public static int mxG()
        {
            return maxG;
        }
        public static int mxB()
        {
            return maxB;
        }
        public static int mR()
        {
            return minR;
        }
        public static int mG()
        {
            return minG;
        }
        public static int mB()
        {
            return minB;
        }
    }
}
