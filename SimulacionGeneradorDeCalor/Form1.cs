using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimulacionGeneradorDeCalor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int contador = 1, SuministroSeleccionado = 20700;
        bool puerta = false, banda = false, suministro = false, automatico = false;

        private void CorreaTimer_Tick(object sender, EventArgs e) // Simula la corrrea corriedno
        {
            string ruta = @"C:\Users\User\Desktop\Simulacion digital\Cinta" + contador + ".gif";
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
                TemperaturaLabel.Text = string.Empty;
            }
            CalculoDeCalorias();
        }

        private void MenosButton_Click(object sender, EventArgs e) // boton disminuir velocidad
        {
            if (Convert.ToDouble(VelocidadLabel.Text) <= 1)
                MensajeLabel.Text = "La cinta a alcanzado la velocidad minima!";
            else
            {
                VelocidadLabel.Text = Convert.ToString(Convert.ToInt32(VelocidadLabel.Text) - 1);
                ActualizarIntervalo();
                MensajeLabel.Text = string.Empty;
            }
        }

        private void MasButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(VelocidadLabel.Text) >= 5)
                MensajeLabel.Text = "La cinta a alcanzado la velocidad maxima!";
            else
            {
                VelocidadLabel.Text = Convert.ToString(Convert.ToDouble(VelocidadLabel.Text) + 1);
                ActualizarIntervalo();
                MensajeLabel.Text = string.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e) // Boton de suministro
        {
            if(suministro == false && automatico == false || suministro == false && automatico == true && puerta == true)
            {
                suministro = true;
                SuministroButton.Image = SimulacionGeneradorDeCalor.Properties.Resources.Encendido;
                MasCantidadButton.Enabled = true;
                MenosCantidadButton.Enabled = true;
            }
            else
            {
                suministro = false;
                SuministroButton.Image = SimulacionGeneradorDeCalor.Properties.Resources.Apagado;
                TemperaturaLabel.Text = string.Empty;
                MasCantidadButton.Enabled = false;
                MenosCantidadButton.Enabled = false;
            }
            CalculoDeCalorias();
        }

        private void CombustibleComboBox_SelectedIndexChanged(object sender, EventArgs e) // COmbobox del suministro
        {
            if (SuministroComboBox.SelectedIndex == 0)
            {
                SuministroSeleccionado = 20700; // Kilocalorias de la madera
            } 
            else if (SuministroComboBox.SelectedIndex == 1)
            {
                SuministroSeleccionado = 18100; // Kilocalorias del cesped
            }
            else
            {
                SuministroSeleccionado = 13500; // Kilocalorias de la paja de arroz
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SuministroComboBox.SelectedIndex = 0;
        }

        private void MenosCantidadButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(CantidadLabel.Text) <= 1)
                MensajeLabel.Text = "Se esta suministrando la menor cantidad posible!";
            else
            {
                CantidadLabel.Text = Convert.ToString(Convert.ToInt32(CantidadLabel.Text) - 1);
                ActualizarIntervalo();
                MensajeLabel.Text = string.Empty;
            }
        }

        private void MasCantidadButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(CantidadLabel.Text) >= 5)
                MensajeLabel.Text = "Se esta suministrando la mayor cantidad posible!";
            else
            {
                CantidadLabel.Text = Convert.ToString(Convert.ToInt32(CantidadLabel.Text) + 1);
                ActualizarIntervalo();
                MensajeLabel.Text = string.Empty;
            }
        }

        private void ModoButton_Click(object sender, EventArgs e)
        {
            if(automatico == false)
            {
                automatico = true;
                ModoButton.Image = SimulacionGeneradorDeCalor.Properties.Resources.PalancaEncendida;
            }
            else
            {
                automatico = false;
                ModoButton.Image = SimulacionGeneradorDeCalor.Properties.Resources.PalancaApagada;
            }
            CalculoDeCalorias();
        }

        public void ActualizarIntervalo() //Actualiza intervalo de tiempo
        {
            int intervalo = Convert.ToInt32(Convert.ToDouble(VelocidadLabel.Text) * 100);
            CorreaTimer.Interval = intervalo;
        }

        private void BandaButton_Click(object sender, EventArgs e) // BOton de la banda trasportadora
        {
            if (banda == false && automatico == false || banda == false && automatico == true && puerta == true)
            {
                banda = true;
                BandaButton.Image = SimulacionGeneradorDeCalor.Properties.Resources.Encendido;
                MasVelocidadButton.Enabled = true;
                MenosVelocidadButton.Enabled = true;
                CorreaTimer.Enabled = true;
            }
            else
            {
                banda = false;
                BandaButton.Image = SimulacionGeneradorDeCalor.Properties.Resources.Apagado;
                TemperaturaLabel.Text = string.Empty;
                MasVelocidadButton.Enabled = false;
                MenosVelocidadButton.Enabled = false;
                CorreaTimer.Enabled = false;
            }
            CalculoDeCalorias();
        }

        public void CalculoDeCalorias()
        {
            if(automatico == false)
            {
                if (puerta == true && banda == true && suministro == true)
                {
                    TemperaturaLabel.Text = Convert.ToString(Convert.ToInt32(CantidadLabel.Text) * SuministroSeleccionado * Convert.ToDouble(Convert.ToDouble(VelocidadLabel.Text) / 300));
                    MensajeLabel.Text = string.Empty;
                }
                else
                {
                    if (suministro == true && banda == false && puerta == false)
                        MensajeLabel.Text = "Se esta acumulando combustible, debe encender la banda y abrir la puerta!";
                    else if (suministro == true && banda == true && puerta == false)
                        MensajeLabel.Text = "Debe abrir la puerta, se esta perdiendo combustible!";
                    else if (suministro == true && puerta == true && banda == false)
                        MensajeLabel.Text = "Se esta acumulando combustible, debe encender la cinta!";
                    else if (puerta == true && banda == true && suministro == false)
                        MensajeLabel.Text = "Debe encender el suministro!";
                    else
                        MensajeLabel.Text = string.Empty;
                    TemperaturaLabel.Text = string.Empty;
                }
            }
            else
            {
                if (puerta == true && banda == true && suministro == true)
                {
                    TemperaturaLabel.Text = Convert.ToString(Convert.ToInt32(CantidadLabel.Text) * SuministroSeleccionado * Convert.ToDouble(Convert.ToDouble(VelocidadLabel.Text) / 300));
                    MensajeLabel.Text = string.Empty;
                }
                if(puerta == false)
                {
                    if(banda == true)
                    {
                        banda = false;
                        BandaButton.Image = SimulacionGeneradorDeCalor.Properties.Resources.Apagado;
                        CorreaTimer.Enabled = false;
                        MensajeLabel.Text = "Debe abrir la puerta para poder encender la banda!";
                        TemperaturaLabel.Text = string.Empty;
                    }
                    if(suministro == true)
                    {
                        suministro = false;
                        SuministroButton.Image = SimulacionGeneradorDeCalor.Properties.Resources.Apagado;
                        MensajeLabel.Text = "Debe abrir la puerta para poder encender el suministro!";
                        TemperaturaLabel.Text = string.Empty;
                    }
                }
            }
        }
    }
}
