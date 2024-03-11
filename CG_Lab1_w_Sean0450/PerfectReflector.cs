using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class PerfectReflector : Filters
    {
        protected override Color CalculateNewPixelColour(Bitmap sourceimage, int x, int y)
        {
            Color source = sourceimage.GetPixel(x, y);
            return Color.FromArgb(Clamp(source.R * 255 / Counter.mxR(), 0, 255), Clamp(source.R * 255 / Counter.mxG(), 0, 255), Clamp(source.R * 255 / Counter.mxB(), 0, 255));

        }
    }
}
