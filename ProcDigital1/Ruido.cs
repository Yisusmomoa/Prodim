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
    public partial class Ruido : Form
    {
        int porcentaje = 0;//porcentaje del ruido
                            //0 a 200 sobre el cual va a aparecer el ruido a un pixel en particular
        int rangoMin = 0, rangoMax = 0;
        public Ruido()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Ruido_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = Application.OpenForms.OfType<Form1>().SingleOrDefault();
            //f1.rangoMinRuido = rangoMin;
            //f1.rangoMaxRuido = rangoMax;
            //f1.porcentajeRuido = porcentaje;
            if (rangoMin> rangoMax)
            {
                MessageBox.Show("EL VALOR MINIMO NO PUEDE SER MAYOR QUE EL VALOR MAXIMO");
            }
            else
            {
                f1.porcentajeRuido = porcentaje;
                f1.rangoMinRuido = rangoMin;
                f1.rangoMaxRuido = rangoMax;
               
                this.Close();
            }
            
        }

        private void trackBarRMaximo_Scroll(object sender, EventArgs e)
        {
            labelRMaximo.Text = trackBarRMaximo.Value.ToString();
            rangoMax = trackBarRMaximo.Value;
        }

        private void trackBarPorcentaje_Scroll(object sender, EventArgs e)
        {
            labelPorcentaje.Text = trackBarPorcentaje.Value.ToString();
            porcentaje = trackBarPorcentaje.Value;
        }

        private void trackBarRMinimo_Scroll(object sender, EventArgs e)
        {
            labelRMinimo.Text = trackBarRMinimo.Value.ToString();
            rangoMin = trackBarRMinimo.Value;
        }
    }
}
