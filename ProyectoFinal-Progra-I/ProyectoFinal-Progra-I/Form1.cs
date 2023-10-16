using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_Progra_I
{
    public partial class Form1 : Form
    {
        Pacientes objPacientes = new Pacientes();
        Clientes objClientes = new Clientes();
        Productos objProductos = new Productos();
      
        public Form1()
        {
            InitializeComponent();
           
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objPacientes.MdiParent = this;
            objPacientes.Show();
            objClientes.Hide();
            objProductos.Hide();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objClientes.MdiParent = this;
            objClientes.Show();
            objPacientes.Hide();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objProductos.MdiParent = this;
            objProductos.Show();
            objPacientes.Hide();
            objClientes.Hide();
        }
    }
}
