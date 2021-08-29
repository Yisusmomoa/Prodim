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
    public partial class Colorizar : Form
    {
        private int variablepruebagit;
        //Camara

        private bool HayDispositivos;
        

        //Camara

        private Bitmap original;
        private Bitmap resultante;
        private int[] histograma = new int[256];
        private int[,] conv3x3 = new int[3, 3];
        private int factor;
        private int offset;

        private int AnchoVentana, AltoVentana;

        //valores de los tracks

        private int trackR = 0, trackG = 0, trackB = 0;

        public Colorizar()
        {
            InitializeComponent();
        }

        private void Colorizar_Paint(object sender, PaintEventArgs e)
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
                     

            int x = 0, y = 0;
            double rc = trackR / 255.0; //estos son los valores a editar
            double gc = trackG / 255.0;
            double bc = trackB / 255.0;

            
            Color miColor = new Color();
            int r = 0, b = 0;
            //creamos la imagen en tonos de gris
            #region
            
            resultante = new Bitmap(original.Width, original.Height);
            Color rColor = new Color();
            Color oColor = new Color();
            float g = 0;

            for (x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    oColor = original.GetPixel(x, y);
                    //cambia de color a tono de gris
                    g = oColor.R * 0.299f + oColor.G * 0.587f + oColor.B * 0.114f;
                    rColor = Color.FromArgb((int)g, (int)g, (int)g);
                    //se coloca el color resultante
                    resultante.SetPixel(x, y, rColor);
                }
            }
           // this.Invalidate();

            #endregion
            //tonosDeGrisToolStripMenuItem_Click(sender, e);

            for (x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    miColor = resultante.GetPixel(x, y);
                    r = (int)(miColor.R * rc);
                    g = (int)(miColor.G * gc);
                    b = (int)(miColor.B * bc);
                    resultante.SetPixel(x, y, Color.FromArgb(r, (int) g, b));

                }
            }
            this.Invalidate();

        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            labelValorTrackR.Text = trackBarRed.Value.ToString();
            trackR = trackBarRed.Value;
        }

        private void salarImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                resultante.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);

            }
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            labelValorTrackB.Text = trackBarBlue.Value.ToString();
            trackB = trackBarBlue.Value;
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            labelValorTrackG.Text = trackBarGreen.Value.ToString();
            trackG = trackBarGreen.Value;
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
    }
}
