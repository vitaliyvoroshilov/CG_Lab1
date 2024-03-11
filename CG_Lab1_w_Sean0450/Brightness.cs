using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Lab1
{
    class Brightness:Filters
    {
        protected override Color CalculateNewPixelColour(Bitmap sourceimage, int x, int y)
        {
            Color sourceColor = sourceimage.GetPixel(x, y);
            Form1 text = new Form1();
            Color resultColor = Color.FromArgb(Clamp(sourceColor.R + 30, 0, 255), Clamp(sourceColor.G + 30, 0, 255), Clamp(sourceColor.B + 30, 0, 255));
            return resultColor;
        }
    }
}
