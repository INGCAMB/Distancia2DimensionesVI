using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distancia2DimensionesVI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox3.Enabled = false;
            textBox4.Enabled = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Captura de datos para las variables
                double V, t, x, y;
                V = double.Parse(textBox1.Text);
                t = double.Parse(textBox2.Text);

                // Cálculo de la distancia en x
                x = V * t;

                // Cálculo de la distancia en y
                y = (V * Math.Pow(t, 2)) / 2;

                // Despliegue de resultados
                textBox3.Text = x.ToString();
                textBox4.Text = y.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Favor de ingresar valores válidos.\n\n" + ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error desconocido.\n\n" + ex);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Reinicio de los controles al estado principal
            textBox1.Text = "9";
            textBox2.Text = "1.5";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            // Salida del programa
            Close();
        }
    }
}
