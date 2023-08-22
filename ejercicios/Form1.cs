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
        string[][] tiposConversores = {
           new String[] {"Dolar","Euro","Quetzal","Lempira","Colon Salvadoreño","Cordoba","Peso Costarricense","Yenes","Libras Esterlinas","Rupia india"},//Monedas
           new String[] { "Miligramos", "Gramos","Kilogramos","Libras","Toneladas","Tonelada corta","Tonelada larga","Onza","Quintal","Stone"},//Masa
           new String[] { "Mililitro","Litro", "Metro Cubico", "Galon", "Cuarto", "Pinta", "Onza liquida","Taza","Cucharada","Cucharadita"},//Volumen
           new String[] { "Micrometro", "Milimetro", "Centimetro", "Metro","Kilometro","Milla","Milla nautica","Yarda","Pulgada","Pie"},//Longitud
           new String[] {"Bit","Byte","Kilobit","Kilobyte","Megabit","Megabyte","Gigabit","Gigabyte","Terabit","Terabyte"},//Almacenamiento
           new String[] {"Microsegundo", "Milisegundo", "Segundo","Minuto","Hora","Dia","Semana","Año","Decada","Siglo"}//Tiempo

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

            double[][] unidades = {
                new double[] { 1, 0.92, 7.86, 24.66, 8.75, 36.58, 535.14, 145.47, 0.79, 83.29 },
                new double[]{1000000000,1000000,1000,2200,1,1.1002,0.9842,35274,10,157.473},//Masa
                new double[]{1000,1,0.001,0.264172,1.05669,2.11338,33.814,4.1667,67.628,202.884},//Volumen
                new double[]{1000000, 1000, 100,1,0.001,0.00062137,0.0005399,1.09361,39.3701,3.28084},//Longitud
                new double[]{8000000,1000000,8000,1000,8,1,0.008,0.001,0.000008,0.000001},//Almacenamiento
                new double[]{ 86400000000, 86400000,86400,1440,24,1,1.0/7,1.0/365,1.0/3650,1.0/36500},//Tiempo
            };
            respuesta = unidades[cboTipoConversor.SelectedIndex][a] / unidades[cboTipoConversor.SelectedIndex][de] * cantidad;

            lblRespuestaConversores.Text = "Respuesta: " + Math.Round(respuesta, 6);

           
        }

        private void cboTipoConversor_TextChanged(object sender, EventArgs e)
        {
            cboDeConversores.Items.Clear();
            cboDeConversores.Items.AddRange(tiposConversores[cboTipoConversor.SelectedIndex]);

            cboAConversores.Items.Clear();
            cboAConversores.Items.AddRange(tiposConversores[cboTipoConversor.SelectedIndex]);
        }
    }
        }
    

