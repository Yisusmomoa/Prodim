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
using Emgu.CV;
using Emgu.CV.Structure;

namespace ProcDigital1
{
    public partial class Form1 : Form
    {
        private int variablepruebagit;
        //Camara

        private bool HayDispositivos;
        private FilterInfoCollection MiDispositivos;//filter
        private VideoCaptureDevice MiWebCam;//device
        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml");
        //Camara

        private Bitmap original;
        private Bitmap resultante;
        private int[] histograma = new int[256];
        private int[] histogramaR = new int[256];
        private int[] histogramaG = new int[256];
        private int[] histogramaB = new int[256];

        //convolución
        private int[,] conv3x3 = new int[3, 3];
        private int factor;
        private int offset;
        //convolución





        private int AnchoVentana, AltoVentana;

        private int trackR = 0, trackG = 0, trackB = 0;

        private int trackBrillo = 0, trackContraste = 0;

        public int porcentajeRuido, rangoMinRuido, rangoMaxRuido;

        public Form1()
        {
            InitializeComponent();
            resultante = new Bitmap(800, 600);
            original = new Bitmap(800, 600);
            AnchoVentana = 800;
            AltoVentana = 600;
        }

        private void Convolucion()
        {
            int x = 0, y = 0, z = 0, a = 0, b = 0;
            Color oColor;
            int sumaR = 0, sumaG = 0, sumaB=0;
            for ( x = 1; x < original.Width-1; x++)
            {
                for ( y = 1; y < original.Height-1; y++)
                {
                    sumaR = 0; sumaG = 0; sumaB = 0;
                    for ( a = -1; a < 2; a++)
                    {
                        for ( b = -1; b < 2; b++)
                        {
                            oColor = original.GetPixel(x + a, y + b);

                            sumaR = sumaR + (oColor.R * conv3x3[a + 1, b + 1]);
                            sumaG = sumaG + (oColor.G * conv3x3[a + 1, b + 1]);
                            sumaB = sumaB + (oColor.B * conv3x3[a + 1, b + 1]);
                        }
                    }
                    sumaR = (sumaR / factor) + offset;
                    sumaG = (sumaG / factor) + offset;
                    sumaB = (sumaB / factor) + offset;

                    if (sumaR > 255)
                        sumaR = 255;
                    else if (sumaR < 0)
                        sumaR = 0;

                    if (sumaG > 255)
                        sumaG = 255;
                    else if (sumaG < 0)
                        sumaG = 0;
                    if (sumaB > 255)
                        sumaB = 255;
                    else if (sumaB < 0)
                        sumaB = 0;
                    resultante.SetPixel(x, y, Color.FromArgb(sumaR, sumaG, sumaB));
                }
            }

        }

        private void ConvGris(int [,] pmatriz, Bitmap pImagen, int pInferior, int pSuperior)
        {
            int x = 0, y = 0, z = 0, a = 0, b = 0;
            Color oColor;
            int suma = 0;
            for ( x = 1; x < pImagen.Width-1; x++)
            {
                for ( y = 1; y < pImagen.Height-1; y++)
                {
                    suma = 0;
                    for ( a = -1; a < 2; a++)
                    {
                        for (b = -1; b < 2; b++)
                        {
                            oColor = pImagen.GetPixel(x + a, y + b);
                            suma = suma + (oColor.R * pmatriz[a + 1, b + 1]);
                        }
                    }
                    if (suma < pInferior)
                        suma = 0;
                    else if (suma > pSuperior)
                        suma = 255;
                    resultante.SetPixel(x, y, Color.FromArgb(suma, suma, suma));
                }
            }
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
                g.DrawImage(original, new Rectangle(this.AutoScrollPosition.X+90, this.AutoScrollPosition.Y + 490, 408, 204));//img2 original la que esta abajo pues 
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
            Image<Bgr, byte> grayImage = new Image<Bgr, byte>(imgane);
            Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayImage, 1.2, 1);
            foreach (Rectangle rectangle in rectangles)
            {
                using (Graphics graphics = Graphics.FromImage(imgane))
                {
                    using (Pen pen=new Pen(Color.Red, 1))
                    {
                        graphics.DrawRectangle(pen, rectangle);
                    }
                }
            }
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
            float r1 = trackR;
            float g1 = trackG;
            float b1 = trackB;

            float r2 = 230;
            float g2 = 100;
            float b2 = 230;

            int r = 0,g=0, b=0;

            float dr = (r2 - r1) / original.Width;
            float dg = (g2 - g1) / original.Width;
            float db = (b2 - b1) / original.Width;

            int x = 0, y = 0;
            Color rColor;
            Color oColor;
            tonosDeGrisToolStripMenuItem_Click(sender, e);
            for ( x = 0; x < original.Width; x++)
            {
                for ( y = 0; y < original.Height; y++)
                {
                    oColor = resultante.GetPixel(x, y);
                    //calculamos el color

                    r = (int)((r1 / 255.0f) * oColor.R);
                    g = (int)((g1 / 255.0f) * oColor.G);
                    b = (int)((b1 / 255.0f) * oColor.B);

                    if (r > 255) r = 255;
                    else if (r < 0) r = 0;

                    if (g > 255) g = 255;
                    else if (g < 0) g = 0;

                    if (b > 255) b = 255;
                    else if (b < 0) b = 0;


                    resultante.SetPixel(x, y, Color.FromArgb(r, g, b));


                }
                r1 = (r1 + dr);
                g1 = (g1 + dg);
                b1 = (b1 + db);
            }



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

        private void mosaicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0, z = 0;
            int mosaico = 8;//la cantidad en la que se va a dividir cada pixel
            int xm = 0, ym = 0;
            Color rColor, oColor;
            int rs=0, gs=0, bs = 0;
            int r = 0, g = 0, b = 0;
            resultante = new Bitmap(original.Width, original.Height);
            for ( x = 0; x < original.Width-mosaico; x+=mosaico)
            {
                for ( y = 0; y < original.Height-mosaico; y+=mosaico)
                {
                    rs = 0; gs = 0; bs = 0;
                    //obtenemos el promedio
                    for ( xm = x; xm < (x+mosaico); xm++)
                        for ( ym = y; ym < (y+mosaico); ym++)
                        {
                            oColor = original.GetPixel(xm, ym);
                            rs += oColor.R;
                            gs += oColor.G;
                            bs += oColor.B;
                        }
                    r = rs / (mosaico * mosaico);
                    g = gs / (mosaico * mosaico);
                    b = bs / (mosaico * mosaico);
                    rColor = Color.FromArgb(r, g, b);

                    for ( xm = x; xm < (x+mosaico); xm++)
                    {
                        for (ym = y;  ym< (y+mosaico); ym++)
                        {
                            resultante.SetPixel(xm, ym, rColor);
                        }
                    }
                }
            }
            this.Invalidate();
        }

        private void suavizadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conv3x3= new int[,] { {1,1,1},
                                  {1,1,1},
                                  {1,1,1} };
            factor = 9;
            offset = 0;
            Convolucion();
            this.Invalidate();
        }

        private void gaussianoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conv3x3 = new int[,] { {1,2,1},
                                  {2,4,2},
                                  {1,2,1} };

            factor = 16;
            offset = 32;//sirve para compensar si hay algún cambio en la iluminación
            Convolucion();
            this.Invalidate();

        }

        private void sharpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conv3x3 = new int[,] { {0,-2,0 },
                                 {-2,11,-2 },
                                 {0,-2,0 } };


            factor = 2;
            offset = 96;
            Convolucion();
            this.Invalidate();
        }

        private void quickPhillipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conv3x3 = new int[,] { {-1,0,-1 },
                                 {0,4,0 },
                                 {-1,0,-1 } };
            //ponemos la imagen en tonos de gris
            tonosDeGrisToolStripMenuItem_Click(sender, e);
            Bitmap intermedio = (Bitmap)resultante.Clone();
            ConvGris(conv3x3, intermedio, 32, 64);
            this.Invalidate();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void histogramasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           


        }

        private void reconocimeintoFacialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PruebaReconocimiento1 frmReconocimiento = new PruebaReconocimiento1();
            frmReconocimiento.Show();
        }

        private void hToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //tonosDeGrisToolStripMenuItem_Click(sender, e);
            int x = 0, y = 0;
            Color rColor = new Color();
            for (x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    rColor = resultante.GetPixel(x, y);
                    // histograma[rColor.R]++;
                    histogramaR[rColor.R]++;
                    histogramaG[rColor.G]++;
                    histogramaB[rColor.B]++;
                }
            }
            HistoForm hformR = new HistoForm(histogramaR,1);
            hformR.Show();

            HistoForm hformG = new HistoForm(histogramaG,2);
            hformG.Show();

            HistoForm hformB = new HistoForm(histogramaB,3);
            hformB.Show();

            //int[] hs = new int[256];
            //int n = 0;
            //hs[0] = (histograma[0] + histograma[1]) / 2;
            //hs[255] = (histograma[255] + histograma[254]) / 2;
            //for (n=1; n<254;n++)
            //{
            //    hs[n] = (histograma[n - 1] + histograma[n] + histograma[n + 1]) / 3;
            //}
            //HistoForm hform2 = new HistoForm(histograma);
            //hform2.Show();

        }

        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[,] sobel0 = new int[,] { { 1, 2, 1 } ,
                                         {0,0,0 },
                                        {-1,-2,-1 }};

            int[,] sobel1 = new int[,] { { 2, 1, 0 } ,
                                         {1,0,-1 },
                                        {0,-1,-2 }};

            int[,] sobel2 = new int[,] { { 1, 0, -1 } ,
                                         {2,0,-2 },
                                        {1,0,-1 }};

            int[,] sobel3 = new int[,] { { 0, -1, -2 } ,
                                         {1,0,-1 },
                                        {2,1,0 }};

            int[,] sobel4 = new int[,] { { -1, -2, -1 } ,
                                         {0,0,0 },
                                        {1,2,1 }};
            int[,] sobel5 = new int[,] { { -2, -1, 0 } ,
                                         {-1,0,1 },
                                        {0,1,2 }};

            int[,] sobel6 = new int[,] { { -2, -1, 0 } ,
                                         {-1,0,1 },
                                        {0,1,2 }};

            tonosDeGrisToolStripMenuItem_Click(sender, e);
            Bitmap intermedio = (Bitmap)resultante.Clone();
            ConvGris(sobel0, intermedio, 0, 255);
            this.Invalidate();

        }

        private void laplacianoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //conv3x3 = new int[,] { {0,1,0 },
            //                       {1,-4,1},
            //                       {0,1,0 } };

            // //tonosDeGrisToolStripMenuItem_Click(sender, e);
            //factor = 16;
            //offset = 32;//sirve para compensar si hay algún cambio en la iluminación
            //Convolucion();
            //this.Invalidate();
            resultante = new Bitmap(original.Width, original.Height);
            for (int x = 1; x < original.Width-1; x++)
            {
                for (int y = 1; y < original.Height-1; y++)
                {
                    Color xy11 = original.GetPixel(x - 1, y - 1);
                    Color xy12 = original.GetPixel(x, y - 1); //color2
                    Color xy13 = original.GetPixel(x + 1, y - 1);
                    Color xy21 = original.GetPixel(x - 1, y);//color4
                    Color xy22 = original.GetPixel(x, y);//color5
                    Color xy23 = original.GetPixel(x + 1, y);//color6
                    Color xy31 = original.GetPixel(x - 1, y + 1);
                    Color xy32 = original.GetPixel(x, y + 1);//color8
                    Color xy33 = original.GetPixel(x + 1, y + 1);

                    int colorRed = xy12.R + xy21.R + xy22.R * (-4) + xy23.R + xy32.R;
                    int colorGreen = xy12.G + xy21.G + xy22.G * (-4) + xy23.G + xy32.G;
                    int colorBlue = xy12.B + xy21.B + xy22.B * (-4) + xy23.B + xy32.B;
                    int avg = (colorRed + colorGreen + colorBlue) / 3;
                    if (avg > 255)
                        avg = 255;
                    if (avg < 0) avg = 0;
                    resultante.SetPixel(x, y, Color.FromArgb(avg, avg, avg));

                }
            }
            this.Invalidate();

         }

        private void johnsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se saca el promedio del area para que no este sobreiluminado
            int x = 0, y = 0;
            resultante = new Bitmap(original.Width, original.Height);
            int promedio = 0, a = 0, b = 0;
            int sumaPromedio = 0, sumaMatriz = 0;
            int tono = 0, escalar = 25;
            //quick
            int[,] matrizBordes =
            {
                { -1, 0, -1},
                { 0, 4, 0},
                {-1, 0, -1 }

            };
            int[,] mPromedio =
            {
                {1,1,1 },
                {1,1,1 },
                {1,1,1 }
            };
            int limite = 2;

            for (x = 1;  x< original.Width-1; x++)
            {
                for ( y = 1; y < original.Height-1; y++)
                {
                    sumaMatriz = 0;
                    sumaPromedio = 0;
                    for ( a = -1; a < 2; a++)
                    {
                        for (b = -1; b < 2; b++)
                        {
                            sumaMatriz += original.GetPixel(x + a, y + b).R * matrizBordes[a + 1, b + 1] * escalar;
                            sumaPromedio += original.GetPixel(x + a, y + b).R * mPromedio[a + 1, b + 1];
                        }
                    }
                    promedio = sumaPromedio / 9;
                    if (promedio==0)
                    {
                        promedio = 1;
                    }
                    tono = sumaMatriz / promedio;
                    if (tono>limite)
                    {
                        tono = 255;
                    }
                    if (tono < 0)
                        tono = 0;
                    resultante.SetPixel(x, y, Color.FromArgb(tono, tono, tono));
                }
            }
            this.Invalidate();
        }

        private void norteEsteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conv3x3 = new int[,] {  {1,1,1 },
                                    {1,-2,-1},
                                    {1,-1,-1} };
            factor = 16;
            offset = 64;//sirve para compensar si hay algún cambio en la iluminación
            tonosDeGrisToolStripMenuItem_Click(sender, e);
            Convolucion();
            this.Invalidate();

            //int[,] NoroEste =
            //{
            //    {1,1,1},
            //    {1,-2,-1},
            //    {1,-1,-1}
            //};
            //resultante = new Bitmap(original.Width, original.Height);
            //for (int x = 1; x < original.Width-1; x++)
            //{
            //    for (int y = 1; y < original.Height-1; y++)
            //    {
            //        Color xy11 = original.GetPixel(x - 1, y - 1);
            //        Color xy12 = original.GetPixel(x, y - 1);
            //        Color xy13 = original.GetPixel(x + 1, y - 1);
            //        Color xy21 = original.GetPixel(x - 1, y);
            //        Color xy22 = original.GetPixel(x , y);
            //        Color xy23 = original.GetPixel(x + 1, y);
            //        Color xy31 = original.GetPixel(x - 1, y + 1);
            //        Color xy32 = original.GetPixel(x, y + 1);
            //        Color xy33 = original.GetPixel(x+1, y + 1);


            //    }
            //}
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

        private void ruidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ruido FormRuido = new Ruido();
            FormRuido.Show();

            int x = 0, y = 0; //, porcentajeRuido = 0;//porcentaje del ruido
                              //0 a 200 sobre el cual va a aparecer el ruido a un pixel en particular
                              //int rangoMinRuido =0, rangoMaxRuido = 0;
                              // float pBrillo = 0;
          
            Random rnd = new Random();
            Color rColor;
            Color oColor;
            //int r = 0, g = 0, b = 0;
            resultante = new Bitmap(original.Width, original.Height);
            for (x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    if (rnd.Next(1, 100) <= porcentajeRuido)
                    {
                        rColor = Color.FromArgb(rnd.Next(rangoMinRuido, rangoMaxRuido),
                                                rnd.Next(rangoMinRuido, rangoMaxRuido),
                                                rnd.Next(rangoMinRuido, rangoMaxRuido));
                    }
                    else
                    {
                        rColor = original.GetPixel(x, y);
                    }
                    resultante.SetPixel(x, y, rColor);
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
