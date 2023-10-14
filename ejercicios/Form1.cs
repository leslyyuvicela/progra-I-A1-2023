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
    public partial class Principal : Form
    {
        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Materias objMaterias = new Materias();
            objMaterias.MdiParent = this;
            objMaterias.Show();
        }
    }
}
