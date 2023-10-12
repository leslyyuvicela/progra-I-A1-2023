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
        double[,] tabla = {
        {0.01, 500.01, 1000.01, 2000.01, 3000.01, 8000.01, 18000.01, 30000.01, 60000.01, 100000.01, 200000.01, 300000.01,  400000.01, 500000.01, 1000000.01},
        {500, 1000, 2000, 3000, 8000, 18000, 30000, 60000, 100000, 200000, 300000, 400000, 500000, 1000000, 99999999},
        {1.5, 1.5, 3, 6, 9, 15, 39, 63, 93, 125, 195,255,300,340,490},
        {0, 3, 3, 3, 2, 2, 2, 1, 0.8, 0.7, 0.6, 0.45, 0.4, 0.30, 0.18},
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularImpuesto_Click(object sender, EventArgs e)
        {
            int indice = 0;
            int numeroTabla = 0;
            double cantidad = double.Parse(txtCantidadImpuesto.Text);

            while (indice < 15)
            {
                if (cantidad >= tabla[0, indice] && cantidad <= tabla[1, indice])
                    numeroTabla = indice;
                indice++;
            }
            lblValorAPagarImpuesto.Text = "El valor a pagar es: " + Convert.ToString(Math.Round((cantidad - tabla[0, numeroTabla]) / 1000 * tabla[3, numeroTabla] + tabla[2, numeroTabla], 2));
        }
    }
}
