using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
     class Sepia:Filters
    {
        protected override Color CalculateNewPixelColour(Bitmap sourceimage, int x, int y)
        {
            Color sourceColor = sourceimage.GetPixel(x, y);
            int k = 23;
            int intensity = Clamp((int)(0.3 * sourceColor.R) + (int)(0.59 * sourceColor.G) + (int)(0.11 * sourceColor.B), 0, 255);
            Color resultColor = Color.FromArgb(Clamp(intensity + 2*k, 0, 255), Clamp(intensity + (int)(0.5 * k), 0, 255), Clamp(intensity - 1 * k, 0, 255));
            return resultColor;
        }
    }
}
