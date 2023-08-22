using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicios
{
    public partial class Form1 : Form
       
    {
        string[,] tiposConversores = new string[,] {
            {"Dolar", "Euro", "Quetzal", "Lempira", "Colon SV", "Cordoba", "Pesos CR", "Yenes", "Libras Esterlinas", "Rupia india"}, //Monedas
            {"Kilogramo", "Gramo", "Decigramo", "Miligramo", "Nanogramo", "Picogramo", "Tonelada corta", "Quintal estadounidense", "Libra", "Onza"}, //Masa
            {"Litro", "Kilolitro", "Megalitro", "Nanolitro", "Milímetro cúbico", "Centímetro cúbico", "Metro cúbico", "Taza estadounidense", "Galón Imperial", "Pie cúbico"}, //Volumen
            {"Kilómetro", "Metro", "Micrón", "Gigámetro", "Terámetro", "Megámetro", "Milla", "Yarda", "Pie", "Año luz"}, //Longitud
            {"Byte", "Kilobyte", "Megabyte", "Gigabyte", "Terabyte", "Petabyte", "Exabyte", "Zettabyte", "Yottabyte", "Bit"}, //Almacenamiento
            {"Segundo", "Minuto", "Hora", "Día", "Semana", "Quincena", "Mes", "Año", "Siglo", "Milenio"}//Tiempo

        }; //Matriz multidimencional
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertirConversores_Click(object sender, EventArgs e)
        {
            int de = 0, a = 0;
            double cantidad = 0, respuesta = 0;

            de = cboDeConversores.SelectedIndex;
                a = cboAConversores.SelectedIndex;

            cantidad = double.Parse(txtCantidadConversores.Text);
            /*
            Dolar, Euro, Quetzales, Lempiras, Colon SV, Cordoba, Pesos CR, Yen, Libras esterlina, Rupia india
            */

            double[] monedas = {1, 0.92, 7.86, 24.66, 8.75, 36.58, 535.14, 145.47, 0.79, 83.29};
            respuesta = monedas[a] / monedas[de] * cantidad;

            lblRespuestaConversores.Text = "Respuesta: " + Math.Round(respuesta,3);
        }
    }
        }
    

