using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulacionGeneradorDeCalor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int contador = 1;
        bool puerta = false, banda = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            //CorreaPictureBox.BackgroundImage = Image.FromFile(@"C:\Users\User\Desktop\Simulacion digital\Cinta2.gif");
            //MoverCorrea();
        }

        public void MoverCorrea()
        {

            CorreaTimer.Enabled = true;

        }

        private void CorreaTimer_Tick(object sender, EventArgs e)
        {
            string ruta = @"C:\Users\User\Desktop\Simulacion digital\Cinta" + contador + ".gif";
            //label1.Text = ruta;
            CorreaPictureBox.BackgroundImage = Image.FromFile(ruta);
            if (contador < 9)
                contador++;
            else
                contador = 2;
        }

        private void PuertaButton_Click(object sender, EventArgs e) // Boton de la puerta
        {
            if(puerta == false)
            {
                puerta = true;
                PuertaButton.Image = SimulacionGeneradorDeCalor.Properties.Resources.Encendido;
                CasillaPictureBox.BackgroundImage = SimulacionGeneradorDeCalor.Properties.Resources.CasillaAbierta;
            }
            else
            {
                puerta = false;
                PuertaButton.Image = SimulacionGeneradorDeCalor.Properties.Resources.Apagado;
                CasillaPictureBox.BackgroundImage = SimulacionGeneradorDeCalor.Properties.Resources.CasillaCerrada;
            }
        }

        private void MenosButton_Click(object sender, EventArgs e) // boton disminuir velocidad
        {
            VelocidadLabel.Text = Convert.ToString(Convert.ToDouble(VelocidadLabel.Text) - 0.2);
        }

        private void MasButton_Click(object sender, EventArgs e)
        {
            VelocidadLabel.Text = Convert.ToString(Convert.ToDouble(VelocidadLabel.Text) + 0.2);
        }

        private void BandaButton_Click(object sender, EventArgs e) // BOton de la banda trasportadora
        {
            if(banda == false)
            {
                banda = true;
                BandaButton.Image = SimulacionGeneradorDeCalor.Properties.Resources.Encendido;
                CorreaTimer.Enabled = true;
            }
            else
            {
                banda = false;
                BandaButton.Image = SimulacionGeneradorDeCalor.Properties.Resources.Apagado;
                CorreaTimer.Enabled = false;
            }
        }
    }
}
