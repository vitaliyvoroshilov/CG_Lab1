using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Grayfilterscs: Filters
    {
        protected override Color CalculateNewPixelColour(Bitmap sourceimage, int x, int y)
        {
            Color sourceColor = sourceimage.GetPixel(x, y);
            int grey = Clamp((int)(0.3 * sourceColor.R) +  (int)(0.59 * sourceColor.G) + (int)(0.11 * sourceColor.B), 0, 255);
            Color resultColor = Color.FromArgb(grey, grey, grey);
            return resultColor;
        }
    }
}

