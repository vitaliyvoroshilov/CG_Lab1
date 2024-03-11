using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Bordersf: Filters
    {
        protected float[,] kernel = null;
        protected float[,] kernel2 = null;
        protected Bordersf() { }
        public Bordersf(float[,] kernel, float[,] kernel2)
        {
            this.kernel = kernel;
            this.kernel2 = kernel2;
        }
        protected override Color CalculateNewPixelColour(Bitmap sourceimage, int x, int y)
        {
            int RadiusX = kernel.GetLength(0) / 2;
            int RadiusY = kernel.GetLength(1) / 2;
            float ResultR = 0, ResultG = 0, ResultB = 0;
            float ResultR1 = 0, ResultG1 = 0, ResultB1 = 0;
            for (int i = -RadiusY; i <= RadiusY; i++)
            {
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
            for (int i = -RadiusY; i <= RadiusY; i++)
            {
                for (int k = -RadiusX; k <= RadiusX; k++)
                {
                    int idx = Clamp(x + k, 0, sourceimage.Width - 1);
                    int idy = Clamp(y + i, 0, sourceimage.Height - 1);
                    Color neighbocolor = sourceimage.GetPixel(idx, idy);
                    ResultR1 += neighbocolor.R * kernel2[k + RadiusX, i + RadiusY];
                    ResultG1 += neighbocolor.G * kernel2[k + RadiusX, i + RadiusY];
                    ResultB1 += neighbocolor.B * kernel2[k + RadiusX, i + RadiusY];
                }

            }
            return Color.FromArgb(Clamp((int)Math.Sqrt((ResultR * ResultR + ResultR1 * ResultR1)), 0, 255), Clamp((int)Math.Sqrt((ResultG * ResultG + ResultG1 * ResultG1)), 0, 255), Clamp((int)Math.Sqrt((ResultB * ResultB + ResultB1 * ResultB1)), 0, 255));
        }
    }
}
