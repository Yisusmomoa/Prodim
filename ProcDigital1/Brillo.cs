using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcDigital1
{
    public partial class Brillo : Form
    {
        //Camara

        private Bitmap original;
        private Bitmap resultante;
       
        private int factor;
        private int offset;

        private int AnchoVentana, AltoVentana;

        //valores de los tracks

        private int trackBrillo = 0;
        public Brillo()
        {
            InitializeComponent();
        }

        private void Brillo_Load(object sender, EventArgs e)
        {

        }

        private void abrirImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                original = (Bitmap)(Bitmap.FromFile(openFileDialog1.FileName));
                resultante = (Bitmap)(Bitmap.FromFile(openFileDialog1.FileName));
                AnchoVentana = original.Width;
                AltoVentana = original.Height;
                resultante = original;
                this.Invalidate();
            }
        }

        private void trackBarBrillo_Scroll(object sender, EventArgs e)
        {
            labelBrillo.Text = trackBarBrillo.Value.ToString();
            trackBrillo = trackBarBrillo.Value;
        }

        private void salvarImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                resultante.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);

            }
        }

        private void Brillo_Paint(object sender, PaintEventArgs e)
        {
            if (resultante != null)
            {
                Graphics g = e.Graphics;

                AutoScrollMinSize = new Size(AnchoVentana, AltoVentana);
                //g.DrawImage(resultante, new Rectangle(this.AutoScrollPosition.X, this.AutoScrollPosition.Y + 60, AnchoVentana-300, AltoVentana-400));//img1 original
                g.DrawImage(resultante, new Rectangle(this.AutoScrollPosition.X + 30, this.AutoScrollPosition.Y + 60, 500, 400));//img1
                g.DrawImage(original, new Rectangle(this.AutoScrollPosition.X + 30, this.AutoScrollPosition.Y + 490, 408, 204));//img2
                g.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int brillo = trackBrillo;
            // float pBrillo = 1.2f;
            int x = 0, y = 0;
            resultante = new Bitmap(original.Width, original.Height);
            Color rColor = new Color();
            Color oColor = new Color();
            int r = 0, g = 0, b = 0;

            for (x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    //obtenemos el color del pixel
                    oColor = original.GetPixel(x, y);

                    r = oColor.R + brillo;
                    g = oColor.G + brillo;
                    b = oColor.B + brillo;


                    //r = (int)(oColor.R * pBrillo);
                    //g = (int)(oColor.G * pBrillo);
                    //b = (int)(oColor.B * pBrillo);

                    if (r > 255) r = 255;
                    else if (r < 0) r = 0;

                    if (g > 255) g = 255;
                    else if (g < 0) g = 0;

                    if (b > 255) b = 255;
                    else if (b < 0) b = 0;
                    rColor = Color.FromArgb(r, g, b);

                    resultante.SetPixel(x, y, rColor);


                }
            }
            this.Invalidate();
        }
    }
}
