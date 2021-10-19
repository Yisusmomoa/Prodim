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
    public partial class HistoForm : Form
    {
        private int[] histograma;
        private int mayor;
        private int ColorOpcion = 0;
        public HistoForm(int[] pHistograma, int pColorOpcion)
        {
            InitializeComponent();
            histograma = pHistograma;
            ColorOpcion = pColorOpcion;
            int n = 0;
            mayor = 0;
            //encontramoms el mayor
            for (n=0; n<256;n++)
            {
                if (histograma[n]>mayor)
                {
                    mayor = histograma[n];
                }
            }
            for (n = 0;  n< 256; n++)
            {
                histograma[n] = (int)((float)histograma[n] / (float)mayor * 256.0f);
            }
        }
       

        private void HistoForm_Load(object sender, EventArgs e)
        {

        }

        private void HistoForm_Paint(object sender, PaintEventArgs e)
        {
            int n = 0;
            int altura = 0;
            Graphics g = e.Graphics;
            if (ColorOpcion==1)//R
            {
                Pen plumaH = new Pen(Color.Red);
                Pen plumaEjes = new Pen(Color.Black);
                g.DrawLine(plumaEjes, 19, 271, 277, 271);
                g.DrawLine(plumaEjes, 19, 270, 19, 14);
                for (n = 0; n < 256; n++)
                {
                    g.DrawLine(plumaH, n + 20, 270, n + 20, 270 - histograma[n]);
                    //g.DrawLine(plumaEjes, n + 20, 270, n + 20, 270 - histograma[n]);
                }
            }
            else if (ColorOpcion == 2)//G
            {
                Pen plumaH = new Pen(Color.Green);
                Pen plumaEjes = new Pen(Color.Black);
                g.DrawLine(plumaEjes, 19, 271, 277, 271);
                g.DrawLine(plumaEjes, 19, 270, 19, 14);
                for (n = 0; n < 256; n++)
                {
                    g.DrawLine(plumaH, n + 20, 270, n + 20, 270 - histograma[n]);
                    //g.DrawLine(plumaEjes, n + 20, 270, n + 20, 270 - histograma[n]);
                }
            }
            else if (ColorOpcion == 3)//B
            {
                Pen plumaH = new Pen(Color.Blue);
                Pen plumaEjes = new Pen(Color.Black);
                g.DrawLine(plumaEjes, 19, 271, 277, 271);
                g.DrawLine(plumaEjes, 19, 270, 19, 14);
                for (n = 0; n < 256; n++)
                {
                    g.DrawLine(plumaH, n + 20, 270, n + 20, 270 - histograma[n]);
                    //g.DrawLine(plumaEjes, n + 20, 270, n + 20, 270 - histograma[n]);
                }
            }
           

        }
    }
}
