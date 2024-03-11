using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace Lab1
{
    abstract class Filters
    {

        protected abstract Color CalculateNewPixelColour(Bitmap sourceimage, int x, int y);
        public Bitmap processImage(Bitmap sourceimage, BackgroundWorker worker)
        {
            Bitmap resultImage = new Bitmap(sourceimage.Width, sourceimage.Height);
            if (this is Gistogram || this is PerfectReflector)
            {
                Counter.work(sourceimage);
            }
            for (int i =0; i < sourceimage.Width; i++)
            {
                if (worker != null)
                {
                    worker.ReportProgress((int)((float)i / resultImage.Width * 100));
                    if (worker.CancellationPending)
                        return null;
                }
                for (int j = 0; j < sourceimage.Height; j++)
                {
                    int source = sourceimage.GetPixel(i, j).R;
                    resultImage.SetPixel(i, j, CalculateNewPixelColour(sourceimage, i, j));
                }
            }
            return resultImage;
        }
        public static int Clamp(int value, int min, int max)
        {
            if (value < min)
            {
                return min;
            }
            if (value > max)
            {
                return max;
            }
            return value;
        }
    }
}
