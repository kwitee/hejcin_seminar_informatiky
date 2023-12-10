using System.Drawing;
using System.IO;
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
            toolStripStatusLabel.Text = "Výpočet fraktálu";
            statusStrip.Update();

            var xMin = double.Parse(xMinTextBox.Text);
            var xMax = double.Parse(xMaxTextBox.Text);
            var yMin = double.Parse(yMinTextBox.Text);
            var yMax = double.Parse(yMaxTextBox.Text);

            var mandelbrot = new Mandelbrot(xMin, xMax, yMin, yMax, pictureBox.Width, pictureBox.Height);
            var bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);

            for (int x = 0; x < pictureBox.Width; x++)
            {
                var prubeh = (double)x / (pictureBox.Width - 1) * 100;
                toolStripProgressBar.Value = (int)prubeh;

                for (int y = 0; y < pictureBox.Height; y++)
                {
                    var barva = mandelbrot.SpocitejPixel(x, y);
                    bitmap.SetPixel(x, y, barva);
                }
            }

            pictureBox.Image = bitmap;
            toolStripStatusLabel.Text = "Výpočet fraktálu byl dokončen";
        }

        private void vykresliButton_Click(object sender, System.EventArgs e)
        {
            VykresliFraktal();
        }

        private void Zobrazovac_ResizeEnd(object sender, System.EventArgs e)
        {
            VykresliFraktal();
        }

        private void ulozitObrazekToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "Bitmap (*.bmp)|*.bmp";
            var result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                pictureBox.Image.Save(dialog.FileName);
                toolStripStatusLabel.Text = "Soubor byl uložen";
            }
        }

        private void nacistParametryToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Textový soubor (*.txt)|*.txt";
            var result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    var obsahSouboru = File.ReadAllText(dialog.FileName);
                    var hodnoty = obsahSouboru.Split(';');

                    xMinTextBox.Text = double.Parse(hodnoty[0]).ToString();
                    xMaxTextBox.Text = double.Parse(hodnoty[1]).ToString();
                    yMinTextBox.Text = double.Parse(hodnoty[2]).ToString();
                    yMaxTextBox.Text = double.Parse(hodnoty[3]).ToString();

                    VykresliFraktal();
                }
                catch
                {
                    MessageBox.Show("Při parsování souboru došlo k chybě",
                        "Chyba",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void ulozitParametryToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "Textový soubor (*.txt)|*.txt";
            var result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                var obsahSouboru = $"{xMinTextBox.Text};{xMaxTextBox.Text};{yMinTextBox.Text};{yMaxTextBox.Text}";
                File.WriteAllText(dialog.FileName, obsahSouboru);
                toolStripStatusLabel.Text = "Parametry uloženy";
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            var xMin = double.Parse(xMinTextBox.Text);
            var xMax = double.Parse(xMaxTextBox.Text);
            var yMin = double.Parse(yMinTextBox.Text);
            var yMax = double.Parse(yMaxTextBox.Text);

            var xRozsah = xMax - xMin;
            var yRozsah = yMax - yMin;

            // Převedeme pozici kurzoru do relativních souřadnic (s hodnotami 0 - 1)
            var xMysRelativni = e.X / (double)(pictureBox.Width - 1);
            var yMysRelativni = e.Y / (double)(pictureBox.Height - 1);

            // Převedeme relativní souřadnice na absolutní v souřadnicovém prostoru fraktálu
            var xSouradnice = xMin + xMysRelativni * xRozsah;
            var ySouradnice = yMin + yMysRelativni * yRozsah;

            toolStripCoordinatesLabel.Text = $"X = {xSouradnice}, Y = {ySouradnice}";
        }

        private void pictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var xMin = double.Parse(xMinTextBox.Text);
            var xMax = double.Parse(xMaxTextBox.Text);
            var yMin = double.Parse(yMinTextBox.Text);
            var yMax = double.Parse(yMaxTextBox.Text);

            var xRozsah = xMax - xMin;
            var yRozsah = yMax - yMin;

            // Převedeme souřadnice kliku na relativní souřadnice (s hodnotami 0 - 1)
            var xKlikRelativni = e.X / (double)(pictureBox.Width - 1);
            var yKlikRelativni = e.Y / (double)(pictureBox.Height - 1);

            var novyXStred = xMin + xKlikRelativni * xRozsah;
            var novyYStred = yMin + yKlikRelativni * yRozsah;

            double zoomFaktor;

            if (e.Button == MouseButtons.Left)
            {
                zoomFaktor = 0.5;
            }
            else
            {
                zoomFaktor = 2;
            }

            var novyXMin = novyXStred - xRozsah / 2 * zoomFaktor;
            var novyXMax = novyXStred + xRozsah / 2 * zoomFaktor;
            var novyYMin = novyYStred - yRozsah / 2 * zoomFaktor;
            var novyYMax = novyYStred + yRozsah / 2 * zoomFaktor;

            xMinTextBox.Text = novyXMin.ToString();
            xMaxTextBox.Text = novyXMax.ToString();
            yMinTextBox.Text = novyYMin.ToString();
            yMaxTextBox.Text = novyYMax.ToString();

            VykresliFraktal();
        }
    }
}