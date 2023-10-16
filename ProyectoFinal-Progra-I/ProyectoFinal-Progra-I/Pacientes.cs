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
    public partial class Pacientes : Form
    {
        Conexion objConexion = new Conexion();
        DataSet miDs = new DataSet();
        DataTable miTabla = new DataTable();
        public int posicion = 0;
        String accion = "nuevo";
        public Pacientes()
        {
            InitializeComponent();
        }

        private void Pacientes_Load(object sender, EventArgs e)
        {
            actualizarDsPacientes();
            cboOpcionBuscarPaciente.SelectedIndex = 0;
        }
        private void actualizarDsPacientes()
        {
            miDs.Clear();
            miDs = objConexion.obtenerDatos();
            miTabla = miDs.Tables["Pacientes"];
            miTabla.PrimaryKey = new DataColumn[] { miTabla.Columns["idPaciente"] };
            mostrarPacientes();
            mostrarDatosPaciente();
        }
        private void mostrarPacientes()
        {

            grdDatosPacientes.DataSource = miTabla.DefaultView;
        }

        //C A M B I A    S E G U N   E L    F O R M U L A R I O
        private void filtrarPacientes(String valor, int opcion)
        {
            try
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = grdDatosPacientes.DataSource;
                bs.Filter = opcion == 0 ? "nombre like '%" + valor + "%'" : opcion == 1 ? "direccion like '%" + valor + "%'"
                    : opcion == 2 ? "correo like '%" + valor + "%'" : opcion == 3 ? "telefono like '%" + valor + "%'" :
                    opcion == 4 ? "fechaNacimiento like '%" + valor + "%'" : "fechaRegistro like '%" + valor.ToString() + "%'";
                grdDatosPacientes.DataSource = bs;
                erpPacientes.SetError(txtBuscarPaciente, "");
            }
            catch (Exception e)
            {
                erpPacientes.SetError(txtBuscarPaciente, "Por favor ingrese dato a buscar");
            }
        }


        //C A M B I A    S E G U N   E L    F O R M U L A R I O
        private void mostrarDatosPaciente()
        {
            if (miTabla.Rows.Count > 0)
            {

                txtNombrePaciente.Text = miTabla.Rows[posicion].ItemArray[1].ToString().Trim();
                txtEspeciePaciente.Text = miTabla.Rows[posicion].ItemArray[2].ToString().Trim();
                txtRazaPaciente.Text = miTabla.Rows[posicion].ItemArray[3].ToString().Trim();
                txtColorPaciente.Text = miTabla.Rows[posicion].ItemArray[4].ToString().Trim();
                txtEstaturaPaciente.Text = miTabla.Rows[posicion].ItemArray[5].ToString().Trim();
                txtPesoPaciente.Text = miTabla.Rows[posicion].ItemArray[6].ToString().Trim();
                dtpNacimietoPaciente.Value = (DateTime)miTabla.Rows[posicion].ItemArray[7];
                dtpRegistroPaciente.Value = (DateTime)miTabla.Rows[posicion].ItemArray[8];
                txtDescripcionPaciente.Text = miTabla.Rows[posicion].ItemArray[9].ToString().Trim();

                lblPosicionPaciente.Text = (posicion + 1) + " de " + miTabla.Rows.Count;

            }
            else
            {
                limpiarCajas();
            }
        }

        private void btnSiguientePaciente_Click(object sender, EventArgs e)
        {
            if (posicion < miTabla.Rows.Count - 1)
            {
                posicion++;
                mostrarDatosPaciente();
            }
        }

        private void btnUltimoPaciente_Click(object sender, EventArgs e)
        {
            posicion = miTabla.Rows.Count - 1;
            mostrarDatosPaciente();
        }

        private void btnAnteriorPaciente_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatosPaciente();
            }

        }

        private void btnPrimeroPaciente_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatosPaciente();
        }

        private void btnNuevoPaciente_Click(object sender, EventArgs e)
        {
            if (btnNuevoPaciente.Text == "Nuevo paciente")
            {
                btnNuevoPaciente.Text = "Guardar";
                btnModificarPaciente.Text = "Cancelar";
                estadoControles(false);
                limpiarCajas();
                accion = "nuevo";
            }
            else
            {

                //C A M B I A    S E G U N   E L    F O R M U L A R I O
                try
                {
                    String msg = objConexion.mantenimientoPacientes(accion, Convert.ToInt32(miTabla.Rows[posicion].ItemArray[0].ToString()), txtNombrePaciente.Text,
                        txtEspeciePaciente.Text, txtRazaPaciente.Text, txtColorPaciente.Text, double.Parse(txtEstaturaPaciente.Text), double.Parse(txtPesoPaciente.Text), dtpNacimietoPaciente.Value.Date,
                        dtpRegistroPaciente.Value.Date, txtDescripcionPaciente.Text);

                    if (msg != "1")
                    {
                        MessageBox.Show("Error en el registro de Pacientes: " + msg, "Registro de Pacientes.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        actualizarDsPacientes();
                        estadoControles(true);
                        btnNuevoPaciente.Text = "Nuevo paciente";
                        btnModificarPaciente.Text = "Modificar datos";
                    }
                }
                catch { 
                    erpPacientes.SetError(txtEstaturaPaciente, "Ingrese unicamente valores numericos");
                    erpPacientes.SetError(txtPesoPaciente, "Ingrese unicamente valores numericos");
                }
            }
        }

        private void btnModificarPaciente_Click(object sender, EventArgs e)
        {
            if (btnModificarPaciente.Text == "Modificar datos")
            {
                btnNuevoPaciente.Text = "Guardar";
                btnModificarPaciente.Text = "Cancelar";
                estadoControles(false);
                accion = "modificar";
            }
            else
            {

                estadoControles(true);
                mostrarDatosPaciente();
                btnNuevoPaciente.Text = "Nuevo paciente";
                btnModificarPaciente.Text = "Modificar datos";
            }
        }


        //C A M B I A    S E G U N   E L    F O R M U L A R I O
        private void estadoControles(Boolean estado)
        {

            txtNombrePaciente.ReadOnly = estado;
           txtEspeciePaciente.ReadOnly = estado;
            txtRazaPaciente.ReadOnly = estado;
            txtColorPaciente.ReadOnly = estado;
            txtEstaturaPaciente.ReadOnly = estado;
            txtPesoPaciente.ReadOnly = estado;
            txtDescripcionPaciente.ReadOnly = estado;
            dtpNacimietoPaciente.Enabled = !estado;

            grbNavegacionPaciente.Enabled = estado;
            btnEliminarPaciente.Enabled = estado;
            txtBuscarPaciente.ReadOnly = !estado;

        }
        private void limpiarCajas()
        {
            txtNombrePaciente.Text = "";
           txtEspeciePaciente.Text = "";
            txtRazaPaciente.Text = "";
            txtColorPaciente.Text = "";
            txtEstaturaPaciente.Text = "";
            txtPesoPaciente.Text = "";
            dtpNacimietoPaciente.Value = DateTime.Today;
            dtpRegistroPaciente.Value = DateTime.Today;
            txtDescripcionPaciente.Text = "";
        }


        private void txtBuscarPaciente_KeyUp(object sender, KeyEventArgs e)
        {
            filtrarPacientes(txtBuscarPaciente.Text, cboOpcionBuscarPaciente.SelectedIndex);
            if (e.KeyValue == 13)
            {//tecla enter
                seleccionarPaciente();
            }
        }
        private void seleccionarPaciente()
        {
            try
            {
                posicion = miTabla.Rows.IndexOf(miTabla.Rows.Find(grdDatosPacientes.CurrentRow.Cells["idPaciente"].Value.ToString()));
                mostrarDatosPaciente();
            }
            catch { }
        }

        private void grdDatosPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarPaciente();
        }

        private void btnEliminarPaciente_Click(object sender, EventArgs e)
        {
            accion = "eliminar";
            if (MessageBox.Show("Esta seguro de eliminar a " + txtNombrePaciente.Text.Trim() + "?", "Eliminado Pacientes",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


                //C A M B I A    S E G U N   E L    F O R M U L A R I O

                String msg = objConexion.mantenimientoPacientes(accion, Convert.ToInt32(miTabla.Rows[posicion].ItemArray[0].ToString()), txtNombrePaciente.Text,
                    txtEspeciePaciente.Text, txtRazaPaciente.Text, txtColorPaciente.Text, double.Parse(txtEstaturaPaciente.Text), double.Parse(txtPesoPaciente.Text), dtpNacimietoPaciente.Value.Date,
                    dtpRegistroPaciente.Value.Date, txtDescripcionPaciente.Text);
                if (msg != "1")
                {
                    MessageBox.Show("Error en la eliminacion de Pacientes: " + msg, "Registro de Pacientes.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    posicion = 0;
                    actualizarDsPacientes();
                }
            }
            accion = "nuevo";
        }

        private void txtEstaturaPaciente_TextChanged(object sender, EventArgs e)
        {
            erpPacientes.SetError(txtEstaturaPaciente, "");
        }

        private void txtPesoPaciente_TextChanged(object sender, EventArgs e)
        {
            erpPacientes.SetError(txtPesoPaciente, "");
        }
    }
}
