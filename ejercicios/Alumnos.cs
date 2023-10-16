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
    public partial class Alumnos : Form
    {
        Conexion objConexion = new Conexion();
        DataSet miDs = new DataSet();
        DataTable miTabla = new DataTable();
        public int posicion = 0;
        String accion = "nuevo";
        public Alumnos()
        {
            InitializeComponent();
        }

        private void Alumnos_Load(object sender, EventArgs e)
        {
            actualizarDsAlumnos();
            cboBuscarAlumnos.SelectedIndex = 1;
        }
        private void actualizarDsAlumnos()
        {
            miDs.Clear();
            miDs = objConexion.obtenerDatos();
            miTabla = miDs.Tables["Alumnos"];
            miTabla.PrimaryKey = new DataColumn[] { miTabla.Columns["idAlumno"] };
            mostrarAlumnos();
            mostrarDatosAlumno();
        }
        private void mostrarAlumnos()
        {

            grdDatosAlumno.DataSource = miTabla.DefaultView;
        }
        private void filtrarAlumnos(String valor, int opcion)
        {
            try
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = grdDatosAlumno.DataSource;
                bs.Filter = opcion == 0 ? "codigo=" + valor : "Alumno like '%" + valor + "%'";
                grdDatosAlumno.DataSource = bs;
                //erpAlumnos.SetError(txtBuscarAlumnos, "");
            }
            catch (Exception e)
            {
                //erpAlumnos.SetError(txtBuscarAlumnos, "Por favor ingrese un codigo o Alumno a buscr");
            }
        }
        private void mostrarDatosAlumno()
        {
            if (miTabla.Rows.Count > 0)
            {
                // Cambia de un formulario a otro
                txtCodigoAlumno.Text = miTabla.Rows[posicion].ItemArray[1].ToString();
                txtNombreAlumno.Text = miTabla.Rows[posicion].ItemArray[2].ToString();
                txtDireccionAlumnos.Text = miTabla.Rows[posicion].ItemArray[3].ToString();
                txtTelefonoAlumno.Text = miTabla.Rows[posicion].ItemArray[4].ToString();

                lblRegistroAlumno.Text = (posicion + 1) + " de " + miTabla.Rows.Count;
            }
            else
            {
                limpiarCajas();
            }
        }

        private void btnSiguienteAlumno_Click(object sender, EventArgs e)
        {
            if (posicion < miTabla.Rows.Count - 1)
            {
                posicion++;
                mostrarDatosAlumno();
            }
            else
            {
                MessageBox.Show("Ultimo Registro", "Registro de Alumnos");
            }
        }

        private void btnUltimoAlumno_Click(object sender, EventArgs e)
        {
            posicion = miTabla.Rows.Count - 1;
            mostrarDatosAlumno();
        }

        private void btnAnteriorAlumno_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatosAlumno();
            }
            else
            {
                MessageBox.Show("Primer regisro", "Registro de Alumnos");
            }
        }

        private void btnPrimeroAlumno_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatosAlumno();
        }

        private void btnNuevoAlumno_Click(object sender, EventArgs e)
        {
            if (btnNuevoAlumno.Text == "Nuevo")
            {
                btnNuevoAlumno.Text = "Guardar";
                btnModificarAlumno.Text = "Cancelar";
                estadoControles(false);
                limpiarCajas();
                accion = "nuevo";
            }
            else
            {//Guardar
                //Cambia de un formulario a otro
                String[] Alumnos = new string[] {
                    accion,txtCodigoAlumno.Text, txtNombreAlumno.Text, txtDireccionAlumnos.Text, txtTelefonoAlumno.Text,
                    miTabla.Rows[posicion].ItemArray[0].ToString()
                };
                String msg = objConexion.mantenimientoAlumnos(Alumnos);
                if (msg != "1")
                {
                    MessageBox.Show("Error en el registro de Alumnos: " + msg, "Registro de Alumnos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    actualizarDsAlumnos();
                    estadoControles(true);
                    btnNuevoAlumno.Text = "Nuevo";
                    btnModificarAlumno.Text = "Modificar";
                }
            }
        }

        private void btnModificarAlumno_Click(object sender, EventArgs e)
        {
            if (btnModificarAlumno.Text == "Modificar")
            {
                btnNuevoAlumno.Text = "Guardar";
                btnModificarAlumno.Text = "Cancelar";
                estadoControles(false);
                accion = "modificar";
            }
            else
            {

                estadoControles(true);
                mostrarDatosAlumno();
                btnNuevoAlumno.Text = "Nuevo";
                btnModificarAlumno.Text = "Modificar";
            }
        }
        private void estadoControles(Boolean estado)
        {
            //Cambia de un formulario a otro
            txtCodigoAlumno.ReadOnly = estado;
            txtNombreAlumno.ReadOnly = estado;
            txtDireccionAlumnos.ReadOnly = estado;
            txtTelefonoAlumno.ReadOnly = estado;

            grbNavegacionAlumnos.Enabled = estado;
            btnEliminarAlumno.Enabled = estado;
            txtBuscarAlumnos.ReadOnly = !estado;
        }
        private void limpiarCajas()
        {
            //Cambia de un formulario a otro
            txtCodigoAlumno.Text = "";
            txtNombreAlumno.Text = "";
            txtDireccionAlumnos.Text = "";
            txtTelefonoAlumno.Text = "";
        }

        private void txtBuscarAlumnos_KeyUp(object sender, KeyEventArgs e)
        {
            filtrarAlumnos(txtBuscarAlumnos.Text, cboBuscarAlumnos.SelectedIndex);
            if (e.KeyValue == 13)
            {//tecla enter
                seleccionarAlumno();
            }
        }
        private void seleccionarAlumno()
        {
            posicion = miTabla.Rows.IndexOf(miTabla.Rows.Find(grdDatosAlumno.CurrentRow.Cells["idAlumno"].Value.ToString()));
            mostrarDatosAlumno();
        }

        private void grdDatosAlumno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarAlumno();
        }

        private void btnEliminarAlumno_Click(object sender, EventArgs e)
        {
            //Cambia de un formulario a otro
            if (MessageBox.Show("Esta seguro de eliminar a " + txtNombreAlumno.Text, "Eliminado Alumnos",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String[] Alumnos = new string[] {
                    "eliminar",txtCodigoAlumno.Text, txtNombreAlumno.Text, txtDireccionAlumnos.Text, txtTelefonoAlumno.Text,
                    miTabla.Rows[posicion].ItemArray[0].ToString()
                };
                String msg = objConexion.mantenimientoAlumnos(Alumnos);
                if (msg != "1")
                {
                    MessageBox.Show("Error en la eliminacion de Alumnos: " + msg, "Registro de Alumnos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    posicion = 0;
                    actualizarDsAlumnos();
                }
            }
        }

    }
}
