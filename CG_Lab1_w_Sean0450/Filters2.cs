using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    abstract class Filters2
    {
        protected abstract Color CalculateNewPixelColour(Bitmap sourceimage1, Bitmap sourceimage2, int x, int y);

        public Bitmap processImage(Bitmap sourceimage1, Bitmap sourceimage2, BackgroundWorker worker)
        {
            Bitmap resultImage = new Bitmap(sourceimage1.Width, sourceimage1.Height);
            if (this is Gistogram || this is PerfectReflector)
            {
                Counter.work(sourceimage1);
            }
            for (int i = 0; i < sourceimage1.Width; i++)
            {
                if (worker != null)
                {
                    worker.ReportProgress((int)((float)i / resultImage.Width * 100));
                    if (worker.CancellationPending)
                        return null;
                }
                for (int j = 0; j < sourceimage1.Height; j++)
                {
                    int source1 = sourceimage1.GetPixel(i, j).R;
                    resultImage.SetPixel(i, j, CalculateNewPixelColour(sourceimage1, sourceimage2, i, j));
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
