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
    public partial class frm_usuario : Form
    {
        Conexion objConexion = new Conexion();
        DataSet miDs = new DataSet();
        DataTable miTabla = new DataTable();
        public int posicion = 0;
        String accion = "nuevo";

        public frm_usuario()
        {
            InitializeComponent();
        }

        private void frm_usuario_Load(object sender, EventArgs e)
        {
            actualizarDsUsuarios();
            cboBuscarUsuarios.SelectedIndex = 1;
        }
        private void actualizarDsUsuarios()
        {
            miDs.Clear();
            miDs = objConexion.obtenerDatos();
            miTabla = miDs.Tables["usuarios"];
            miTabla.PrimaryKey = new DataColumn[] { miTabla.Columns["idUsuario"] };
            mostrarUsuario();
            mostrarDatosUsuario();
        }
        private void mostrarUsuario()
        {
            grdDatosUsuario.DataSource = miTabla.DefaultView;
        }
        private void filtrarUsuarios(String valor, int opcion)
        {
            try
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = grdDatosUsuario.DataSource;
                bs.Filter = opcion == 0 ? "nombre like '%" + valor + "%'": "usuario like '%" + valor + "%'";
                grdDatosUsuario.DataSource = bs;
                //erpUsuarios.SetError(txtBuscarUsuarios, "");
            }
            catch (Exception e)
            {
               // erpUsuarios.SetError(txtBuscarUsuarios, "Por favor ingrese un codigo o Alumno a buscar");
            }
        }
        private void mostrarDatosUsuario()
        {
            if (miTabla.Rows.Count > 0)
            {
                // Cambia de un formulario a otro
                txtUsuariofrmUsuario.Text = miTabla.Rows[posicion].ItemArray[1].ToString();
                txtClavefrmUsuario.Text = miTabla.Rows[posicion].ItemArray[2].ToString();
                txtNombrefrmUsuario.Text = miTabla.Rows[posicion].ItemArray[3].ToString();
                txtDireccionfrmUsuario.Text = miTabla.Rows[posicion].ItemArray[4].ToString();
                txtTelefonofrmUsuario.Text = miTabla.Rows[posicion].ItemArray[5].ToString();

                lblRegistroUsuario.Text = (posicion + 1) + " de " + miTabla.Rows.Count;
            }
            else
            {
                limpiarCajas();
            }
        }

        private void btnSiguienteUsuario_Click(object sender, EventArgs e)
        {
            if (posicion < miTabla.Rows.Count - 1)
            {
                posicion++;
                mostrarDatosUsuario();
            }
            else
            {
                MessageBox.Show("Ultimo Registro", "Registro de Usuarios");
            }
        }

        private void btnUltimoUsuario_Click(object sender, EventArgs e)
        {
            posicion = miTabla.Rows.Count - 1;
            mostrarDatosUsuario();
        }

        private void btnAnteriorUsuario_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatosUsuario();
            }
            else
            {
                MessageBox.Show("Primer regisro", "Registro de Usuarios");
            }
        }

        private void btnPrimeroUsuario_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatosUsuario();
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            if (btnNuevoUsuario.Text == "Nuevo")
            {
                btnNuevoUsuario.Text = "Guardar";
                btnModificarUsuario.Text = "Cancelar";
                estadoControles(false);
                limpiarCajas();
                accion = "nuevo";
            }
            else
            {//Guardar
                //Cambia de un formulario a otro
                String[] usuarios = new string[] {
                    accion,txtUsuariofrmUsuario.Text, txtClavefrmUsuario.Text, txtNombrefrmUsuario.Text, txtDireccionfrmUsuario.Text, txtTelefonofrmUsuario.Text,
                    miTabla.Rows[posicion].ItemArray[0].ToString()
                };
                String msg = objConexion.mantenimiento_usuarios(usuarios);
                if (msg != "1")
                {
                    MessageBox.Show("Error en el registro de Alumnos: " + msg, "Registro de Alumnos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    actualizarDsUsuarios();
                    estadoControles(true);
                    btnNuevoUsuario.Text = "Nuevo";
                    btnModificarUsuario.Text = "Modificar";
                }
            }
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            if (btnModificarUsuario.Text == "Modificar")
            {
                btnNuevoUsuario.Text = "Guardar";
                btnModificarUsuario.Text = "Cancelar";
                estadoControles(false);
                accion = "modificar";
            }
            else
            {

                estadoControles(true);
                mostrarDatosUsuario();
                btnNuevoUsuario.Text = "Nuevo";
                btnModificarUsuario.Text = "Modificar";
            }
        }
        private void estadoControles(Boolean estado)
        {
            //Cambia de un formulario a otro
            txtUsuariofrmUsuario.ReadOnly = estado;
            txtClavefrmUsuario.ReadOnly = estado;
            txtNombrefrmUsuario.ReadOnly = estado;
            txtDireccionfrmUsuario.ReadOnly = estado;
            txtTelefonofrmUsuario.ReadOnly = estado;
            txtBuscarUsuarios.ReadOnly = estado;

            grbNavegacionUsuarios.Enabled = estado;
            btnEliminarUsuario.Enabled = estado;
            txtBuscarUsuarios.ReadOnly = !estado;
        }
        private void limpiarCajas()
        {
            //Cambia de un formulario a otro
            txtUsuariofrmUsuario.Text = "";
            txtClavefrmUsuario.Text = "";
            txtNombrefrmUsuario.Text = "";
            txtDireccionfrmUsuario.Text = "";
            txtTelefonofrmUsuario.Text = "";
        }

        private void txtBuscarUsuarios_KeyUp(object sender, KeyEventArgs e)
        {
            filtrarUsuarios(txtBuscarUsuarios.Text, cboBuscarUsuarios.SelectedIndex);
            if (e.KeyValue == 13)
            {//tecla enter
                seleccionarUsuario();
            }
        }
        private void seleccionarUsuario()
        {
            posicion = miTabla.Rows.IndexOf(miTabla.Rows.Find(grdDatosUsuario.CurrentRow.Cells["idUsuario"].Value.ToString()));
            mostrarDatosUsuario();
        }

        private void grdDatosUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarUsuario();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar a " + txtClavefrmUsuario.Text, "Eliminado Alumnos",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String[] Usuarios = new string[] {
                    "eliminar",txtUsuariofrmUsuario.Text, txtClavefrmUsuario.Text, txtNombrefrmUsuario.Text, txtDireccionfrmUsuario.Text, txtTelefonofrmUsuario.Text,
                    miTabla.Rows[posicion].ItemArray[0].ToString()
                };
                String msg = objConexion.mantenimiento_usuarios(Usuarios);
                if (msg != "1")
                {
                    MessageBox.Show("Error en la eliminacion de Alumnos: " + msg, "Registro de Alumnos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    posicion = 0;
                    actualizarDsUsuarios();
                }
            }
        }

        private void v(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
           
        }
    }

    }

