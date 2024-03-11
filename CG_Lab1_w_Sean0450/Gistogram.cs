using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Gistogram: Filters
    {
        protected override Color CalculateNewPixelColour(Bitmap sourceimage, int x, int y)
        {
            Color source = sourceimage.GetPixel(x, y);
            int R = (source.R - Counter.mR()) * (255 / (Counter.mxR() - Counter.mR()));
            int G = (source.G - Counter.mG()) * (255 / (Counter.mxG() - Counter.mG()));
            int B = (source.B - Counter.mB()) * (255 / (Counter.mxB() - Counter.mB()));
            return Color.FromArgb(R, G, B);
        }
    }
}
