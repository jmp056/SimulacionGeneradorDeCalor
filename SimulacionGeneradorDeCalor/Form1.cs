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

        private void Form1_Load(object sender, EventArgs e)
        {
            //CorreaPictureBox.BackgroundImage = Image.FromFile(@"C:\Users\User\Desktop\Simulacion digital\Cinta2.gif");
            MoverCorrea();
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
    }
}
