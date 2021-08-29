using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;

namespace ProcDigital1
{
    public partial class Form1 : Form
    {
        private int variablepruebagit;
        //Camara

        private bool HayDispositivos;
        private FilterInfoCollection MiDispositivos;
        private VideoCaptureDevice MiWebCam;

        //Camara

        private Bitmap original;
        private Bitmap resultante;
        private int[] histograma = new int[256];
        private int[,] conv3x3 = new int[3, 3];
        private int factor;
        private int offset;

        private int AnchoVentana, AltoVentana;

        private int trackR = 0, trackG = 0, trackB = 0;

        private int trackBrillo = 0, trackContraste = 0;
        public Form1()
        {
            InitializeComponent();
            resultante = new Bitmap(800, 600);
            original = new Bitmap(800, 600);
            AnchoVentana = 800;
            AltoVentana = 600;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void abrirImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                original = (Bitmap)(Bitmap.FromFile(openFileDialog1.FileName));
                resultante = (Bitmap)(Bitmap.FromFile(openFileDialog1.FileName));
                AnchoVentana = original.Width;
                AltoVentana = original.Height;
                resultante = original;
                this.Invalidate();
            }
        }

        private void salvarImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                resultante.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);

            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (resultante!=null)
            {
                Graphics g = e.Graphics;

                AutoScrollMinSize = new Size(AnchoVentana, AltoVentana);
                //g.DrawImage(resultante, new Rectangle(this.AutoScrollPosition.X, this.AutoScrollPosition.Y + 60, AnchoVentana-300, AltoVentana-400));//img1 original
                g.DrawImage(resultante, new Rectangle(this.AutoScrollPosition.X+30, this.AutoScrollPosition.Y + 60, 500, 400));//img1
                g.DrawImage(original, new Rectangle(this.AutoScrollPosition.X+30, this.AutoScrollPosition.Y + 490, 408, 204));//img2
                g.Dispose();
            }
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;
            resultante = new Bitmap(original.Width, original.Height);
            for (x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    resultante.SetPixel(x, y, Color.FromArgb(120, 200, 120));
                }
            }
            this.Invalidate();
        }

        private void invertirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se saca el negativo de la imagen/pixel
            int x = 0;
            int y = 0;
            resultante = new Bitmap(original.Width, original.Height);
            Color rColor = new Color();
            Color oColor = new Color();
            for (x = 0;  x< original.Width; x++)
            {
                for ( y = 0; y < original.Height; y++)
                {
                    //obtenemos el color del pixel
                    oColor = original.GetPixel(x, y);
                    //Procesamos y obtenemos el nuevo color
                    rColor = Color.FromArgb(255 - oColor.R, 255 - oColor.G, 255 - oColor.B);
                    //Colocamos el color resultante
                    resultante.SetPixel(x, y, rColor);
                }
            }
            this.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargaDispositivos();
        }

        public void CargaDispositivos()
        {
            MiDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (MiDispositivos.Count>0)
            {
                HayDispositivos = true;
                for (int i = 0; i < MiDispositivos.Count; i++)
                {
                    comboBox1.Items.Add(MiDispositivos[i].Name.ToString());

                }
                comboBox1.Text = MiDispositivos[0].ToString();

            }
            else
            {
                HayDispositivos = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CerrarWebCam();
            int i = comboBox1.SelectedIndex;
            String NombreVide = MiDispositivos[i].MonikerString;
            MiWebCam = new VideoCaptureDevice(NombreVide);
            MiWebCam.NewFrame += new NewFrameEventHandler(capturando);
            MiWebCam.Start();

        }
        private void capturando(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap imgane = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = imgane;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            CerrarWebCam();
        }

        private void filtroColoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0;
            resultante = new Bitmap(original.Width, original.Height);
            Color rColor = new Color();
            Color oColor = new Color();
            //checks individuales
            #region
            if (checkBoxRed.Checked == true)
            {
                for (x = 0; x < original.Width; x++)
                {
                    for (y = 0; y < original.Height; y++)
                    {
                        //obtenemos el color de cada pixel
                        oColor = original.GetPixel(x, y);
                        //procesamos y obtenemos el nuevo color
                        rColor = Color.FromArgb(oColor.R, 0, 0);

                        //colocamos el color en el resultante
                        resultante.SetPixel(x, y, rColor);
                    }
                }
            }
            if (checkBoxGreen.Checked == true)
            {
                for (x = 0; x < original.Width; x++)
                {
                    for (y = 0; y < original.Height; y++)
                    {

                        //obtenemos el color de cada pixel
                        oColor = original.GetPixel(x, y);
                        //procesamos y obtenemos el nuevo color
                        rColor = Color.FromArgb(0, oColor.G, 0);

                        //colocamos el color en el resultante
                        resultante.SetPixel(x, y, rColor);
                    }
                }
            }
            if (checkBoxBlue.Checked == true)
            {
                for (x = 0; x < original.Width; x++)
                {
                    for (y = 0; y < original.Height; y++)
                    {

                        //obtenemos el color de cada pixel
                        oColor = original.GetPixel(x, y);
                        //procesamos y obtenemos el nuevo color
                        rColor = Color.FromArgb(0, 0, oColor.B);

                        //colocamos el color en el resultante
                        resultante.SetPixel(x, y, rColor);
                    }
                }
            }
            #endregion


            //checks 2
            #region

            if (checkBoxBlue.Checked == true && checkBoxRed.Checked == true && checkBoxGreen.Checked == true)
            {
                for (x = 0; x < original.Width; x++)
                {
                    for (y = 0; y < original.Height; y++)
                    {

                        //obtenemos el color de cada pixel
                        oColor = original.GetPixel(x, y);
                        //procesamos y obtenemos el nuevo color
                        rColor = Color.FromArgb(oColor.R, oColor.G, oColor.B);

                        //colocamos el color en el resultante
                        resultante.SetPixel(x, y, rColor);
                    }
                }
            }

            if (checkBoxRed.Checked == true && checkBoxGreen.Checked == true)
            {
                for (x = 0; x < original.Width; x++)
                {
                    for (y = 0; y < original.Height; y++)
                    {
                        //obtenemos el color de cada pixel
                        oColor = original.GetPixel(x, y);
                        //procesamos y obtenemos el nuevo color
                        rColor = Color.FromArgb(oColor.R, oColor.G, 0);
                        //colocamos el color en el resultante
                        resultante.SetPixel(x, y, rColor);
                    }
                }
            }
            if (checkBoxRed.Checked == true && checkBoxBlue.Checked == true)
            {
                for (x = 0; x < original.Width; x++)
                {
                    for (y = 0; y < original.Height; y++)
                    {
                        //obtenemos el color de cada pixel
                        oColor = original.GetPixel(x, y);
                        //procesamos y obtenemos el nuevo color
                        rColor = Color.FromArgb(oColor.R, 0, oColor.B);
                        //colocamos el color en el resultante
                        resultante.SetPixel(x, y, rColor);
                    }
                }
            }


            if (checkBoxGreen.Checked == true && checkBoxBlue.Checked == true)
            {
                for (x = 0; x < original.Width; x++)
                {
                    for (y = 0; y < original.Height; y++)
                    {

                        //obtenemos el color de cada pixel
                        oColor = original.GetPixel(x, y);
                        //procesamos y obtenemos el nuevo color
                        rColor = Color.FromArgb(0, oColor.G, oColor.B);

                        //colocamos el color en el resultante
                        resultante.SetPixel(x, y, rColor);
                    }
                }
            }

           
            #endregion



          
           
            this.Invalidate();
        }

        private void aberracionCromaticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0, a = 4; //a tamaña de la aberración
            int r = 0, g = 0, b = 0;
            resultante = new Bitmap(original.Width, original.Height);
            for (x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    //obtenemoms el verde
                    g = original.GetPixel(x, y).G;

                    //obtenemos el rojo
                    if (x+a<original.Width)
                    {
                        r = original.GetPixel(x + a, y).R;
                    }
                    else
                    {
                        r = 0;
                    }
                    if (x - a >= 0)
                    {
                        b = original.GetPixel(x - a, y).B;
                    }
                    else
                    {
                        b = 0;
                    }
                    //colocamos el pixel
                    resultante.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            this.Invalidate();

        }

        private void gammaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0;
            resultante = new Bitmap(original.Width, original.Height);
            Color rColor = new Color();
            Color oColor = new Color();
            float r = 0, g = 0, b = 0;
            int n = 0;
            //factor para el gamma

            float rg = 1.1f;
            float gg = 1.5f;
            float bg = 0.9f;

            int[] rGama = new int[256];
            int[] gGama = new int[256];
            int[] bGama = new int[256];
            for (n = 0; n < 256; n++)
            {
                rGama[n] = Math.Min(255, (int)((255.0 * Math.Pow(n / 255.0f, 1.0f / rg)) + 0.5f));
                gGama[n] = Math.Min(255, (int)((255.0 * Math.Pow(n / 255.0f, 1.0f / gg)) + 0.5f));
                bGama[n] = Math.Min(255, (int)((255.0 * Math.Pow(n / 255.0f, 1.0f / bg)) + 0.5f));
            }
            //aplicamos el gama a la imagen
            for ( x = 0; x < original.Width; x++)
            {
                for ( y = 0; y < original.Height; y++)
                {
                    //se obtiene el color del pixel

                    oColor = original.GetPixel(x, y);
                    r = rGama[oColor.R];
                    g = gGama[oColor.G];
                    b = bGama[oColor.B];
                    rColor = Color.FromArgb((int)r, (int)g, (int)b);
                    //se coloca el color resultante
                    resultante.SetPixel(x, y, rColor);
                }
            }
            this.Invalidate();
        }

        private void tonosDeGrisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //convertimos la imagen a tonos de gris


            int x = 0, y = 0;
            resultante = new Bitmap(original.Width, original.Height);
            Color rColor = new Color();
            Color oColor = new Color();

            float g = 0;

            for ( x = 0; x <original.Width; x++)
            {
                for ( y = 0; y < original.Height; y++)
                {
                    oColor = original.GetPixel(x, y);
                    //cambia de color a tono de gris
                    g = oColor.R * 0.299f + oColor.G * 0.587f + oColor.B * 0.114f;
                    rColor = Color.FromArgb((int)g, (int)g, (int)g);
                    //se coloca el color resultante
                    resultante.SetPixel(x, y, rColor);
                }
            }
            this.Invalidate();
        }

        private void colorizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* Colorizar frmcolorizar = new Colorizar();
             frmcolorizar.Show();*/
            int x = 0, y = 0;
            double rc = trackR / 255.0; //estos son los valores a editar
            double gc = trackG / 255.0;
            double bc = trackB / 255.0;


            Color miColor = new Color();
            int r = 0, b = 0;
            //creamos la imagen en tonos de gris

            resultante = new Bitmap(original.Width, original.Height);
            Color rColor = new Color();
            Color oColor = new Color();
            float g = 0;

            tonosDeGrisToolStripMenuItem_Click(sender, e);

            for (x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    miColor = resultante.GetPixel(x, y);
                    r = (int)(miColor.R * rc);
                    g = (int)(miColor.G * gc);
                    b = (int)(miColor.B * bc);
                    resultante.SetPixel(x, y, Color.FromArgb(r, (int)g, b));

                }
            }
            this.Invalidate();

        }

        private void colorizarGradienteToolStripMenuItem_Click(object sender, EventArgs e)
        {


            this.Invalidate();
        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            labelValorTrackR.Text = trackBarRed.Value.ToString();
            trackR = trackBarRed.Value;
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            labelValorTrackG.Text = trackBarGreen.Value.ToString();
            trackG = trackBarGreen.Value;
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            labelValorTrackB.Text = trackBarBlue.Value.ToString();
            trackB = trackBarBlue.Value;
        }

        private void trackBarBrillo_Scroll(object sender, EventArgs e)
        {
            labelBrillo.Text = trackBarBrillo.Value.ToString();
            trackBrillo = trackBarBrillo.Value;
        }

        private void contrasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //modificamos el contrasete de la imagen

            int contraste = trackContraste; //el valor va desde -100 a 100
            float c = (100.0f + contraste) / 100;
            c *= c;
            int x = 0, y = 0;
            resultante = new Bitmap(original.Width, original.Height);
            Color rColor = new Color();
            Color oColor = new Color();
            float r = 0, g = 0, b = 0;
            for ( x = 0; x < original.Width; x++)
            {
                for ( y = 0; y < original.Height; y++)
                {
                    oColor = original.GetPixel(x, y);

                    //procesamos y obtenemos el nuevo color
                    r = ((((oColor.R / 255.0f) - 0.5f) * c) + 0.5f) * 255;
                    if (r > 255) r = 255;
                    if (r < 0) r = 0;

                    g = ((((oColor.G / 255.0f) - 0.5f) * c) + 0.5f) * 255;
                    if (g > 255) g = 255;
                    if (g < 0) g = 0;

                    b = ((((oColor.B / 255.0f) - 0.5f) * c) + 0.5f) * 255;
                    if (b > 255) b = 255;
                    if (b < 0) b = 0;
                    rColor = Color.FromArgb((int)r, (int)g, (int)b);
                    resultante.SetPixel(x, y, rColor);
                }
            }
            this.Invalidate();
        }

        private void flipHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0;
            resultante = new Bitmap(original.Width, original.Height);

            Color rColor = new Color();
            Color oColor = new Color();

            for ( x = 0; x < original.Width; x++)
            {
                for ( y = 0; y < original.Height; y++)
                {
                    oColor = original.GetPixel(x, y);
                    rColor = Color.FromArgb(oColor.R, oColor.G, oColor.B);
                    resultante.SetPixel(original.Width -x -1,y, rColor);
                }
            }
            this.Invalidate();

        }

        private void trackBarContraste_Scroll(object sender, EventArgs e)
        {
            labelContraste.Text = trackBarContraste.Value.ToString();
            trackContraste = trackBarContraste.Value;
        }

        private void basicosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void brilloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Brillo frmBrillo = new Brillo();
            frmBrillo.Show();*/

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

        public void CerrarWebCam()
        {
            if (MiWebCam!=null && MiWebCam.IsRunning)
            {
                MiWebCam.SignalToStop();
                MiWebCam = null;
            }
        }
    }
}
