using System.Drawing;
using System.Windows.Forms;

namespace MandelbrotovaMnozina
{
    public partial class Zobrazovac : Form
    {
        public Zobrazovac()
        {
            InitializeComponent();

            VykresliFraktal();
        }

        public void VykresliFraktal()
        {
            var xMin = -2.5;
            var xMax = 1;
            var yMin = -1;
            var yMax = 1;

            var mandelbrot = new Mandelbrot(xMin, xMax, yMin, yMax, pictureBox.Width, pictureBox.Height);
            var bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);

            for (int x = 0; x < pictureBox.Width; x++)
            {
                for (int y = 0; y < pictureBox.Height; y++)
                {
                    var barva = mandelbrot.SpocitejPixel(x, y);
                    bitmap.SetPixel(x, y, barva);
                }
            }

            pictureBox.Image = bitmap;
        }

        private void vykresliButton_Click(object sender, System.EventArgs e)
        {
            VykresliFraktal();
        }
    }
}