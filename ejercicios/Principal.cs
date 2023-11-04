﻿using System;
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
        public Principal()
        {
            InitializeComponent();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Materias objMaterias = new Materias();
            objMaterias.MdiParent = this;
            objMaterias.Show(); 

        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alumnos objAlumnos = new Alumnos();
            objAlumnos.MdiParent = this;
            objAlumnos.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_usuario objUsuarios = new frm_usuario();
            objUsuarios.MdiParent = this;
            objUsuarios.Show();
        }
    }
}
