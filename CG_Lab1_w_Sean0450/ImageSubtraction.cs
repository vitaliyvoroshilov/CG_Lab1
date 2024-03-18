using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class ImageSubtraction: Filters2
    {
        protected override Color CalculateNewPixelColour(Bitmap sourceimage1, Bitmap sourceimage2, int x, int y)
        {
            Color sourceColor1 = sourceimage1.GetPixel(x, y);
            Color sourceColor2 = sourceimage2.GetPixel(x, y);

            Color resultColor = Color.FromArgb(Clamp(sourceColor1.R - sourceColor2.R, 0, 255), Clamp(sourceColor1.G - sourceColor2.G, 0, 255), Clamp(sourceColor1.B - sourceColor2.B, 0, 255));

            return resultColor;
        }
    }
}
