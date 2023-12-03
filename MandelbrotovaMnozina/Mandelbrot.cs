using System.Drawing;

namespace MandelbrotovaMnozina
{
    public class Mandelbrot
    {
        private double xMin;
        private double xMax;
        private double yMin;
        private double yMax;

        private int width;
        private int height;

        private double maxRozdil = 4;
        private int maxIteraci = 1000;

        public Mandelbrot(double xMin, double xMax, double yMin, double yMax,int width, int height)
        {
            this.xMin = xMin;
            this.xMax = xMax;
            this.yMin = yMin;
            this.yMax = yMax;

            this.width = width;
            this.height = height;
        }

        private int SpocitejHodnotu(int x, int y)
        {
            var real = xMin + x * (xMax - xMin) / (width - 1);
            var imaginary = yMin + y * (yMax - yMin) / (height - 1);

            var zReal = real;
            var zImaginary = imaginary;

            for (int i = 0; i < maxIteraci; i++)
            {
                var zRealTemp = zReal * zReal - zImaginary * zImaginary + real;

                zImaginary = 2 * zReal * zImaginary + imaginary;
                zReal = zRealTemp;

                if (zReal * zReal + zImaginary * zImaginary > maxRozdil)
                {
                    return i;
                }
            }

            return maxIteraci;
        }

        public Color SpocitejPixel(int x, int y)
        {
            // Výpočet Mandelbrot iterace
            var value = SpocitejHodnotu(x, y);

            // Barvu počítáme jenom když jsme pod limitem iterací
            if (value < maxIteraci)
            {
                var r = (value % 8) * 32;
                var g = (value % 16) * 16;
                var b = (value % 32) * 8;

                return Color.FromArgb(r, g, b);
            }
            else
            {
                // Black
                return Color.FromArgb(0, 0, 0);
            }
        }
    }
}