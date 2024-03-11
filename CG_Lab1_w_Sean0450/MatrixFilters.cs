using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
     class MatrixFilters:Filters
    {
        protected float[,] kernel = null;
        protected MatrixFilters() { }
        public MatrixFilters(float[,] kernel)
        {
            this.kernel = kernel;
        }
        protected override Color CalculateNewPixelColour(Bitmap sourceimage, int x, int y)
        {
            int RadiusX = kernel.GetLength(0) / 2;
            int RadiusY = kernel.GetLength(1) / 2;
            float ResultR = 0, ResultG = 0, ResultB = 0;
            for (int i = -RadiusY; i <= RadiusY; i++){
                for (int k = -RadiusX; k <= RadiusX; k++)
                {
                    int idx = Clamp(x + k, 0, sourceimage.Width - 1);
                    int idy = Clamp(y + i, 0, sourceimage.Height - 1);
                    Color neighbocolor = sourceimage.GetPixel(idx, idy);
                    ResultR += neighbocolor.R * kernel[k + RadiusX, i + RadiusY];
                    ResultG += neighbocolor.G * kernel[k + RadiusX, i + RadiusY];
                    ResultB += neighbocolor.B * kernel[k + RadiusX, i + RadiusY];
                }

            }
            return Color.FromArgb(Clamp((int)ResultR, 0, 255), Clamp((int)ResultG, 0, 255), Clamp((int)ResultB, 0, 255));
        }
    }
}
