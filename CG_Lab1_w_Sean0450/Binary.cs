using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
     class Binary:Filters
    {
        protected override Color CalculateNewPixelColour(Bitmap sourceimage, int x, int y)
        {
            Color sourceColor = sourceimage.GetPixel(x, y);
            if (sourceColor.R + sourceColor.G + sourceColor.B >= 120)
            {
                Color resultColor = Color.FromArgb(255, 255, 255);
                return resultColor;
            }
            else
            {
                Color resultColor = Color.FromArgb(0, 0, 0);
                return resultColor;
            }
        }
    }
}
