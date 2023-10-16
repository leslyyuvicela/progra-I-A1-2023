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
    public partial class Productos : Form
    {
        Conexion objConexion = new Conexion();
        DataSet miDs = new DataSet();
        DataTable miTabla = new DataTable();
        public int posicion = 0;
        String accion = "nuevo";
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            actualizarDsProductos();
            cboOpcionBuscarProducto.SelectedIndex = 0;
        }
        private void actualizarDsProductos()
        {
            miDs.Clear();
            miDs = objConexion.obtenerDatos();
            miTabla = miDs.Tables["productos"];
            miTabla.PrimaryKey = new DataColumn[] { miTabla.Columns["idProducto"] };
            mostrarProductos();
            mostrarDatosProducto();
        }
        private void mostrarProductos()
        {

            grdDatosProductos.DataSource = miTabla.DefaultView;
        }

        //C A M B I A    S E G U N   E L    F O R M U L A R I O
        private void filtrarProductos(String valor, int opcion)
        {
            try
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = grdDatosProductos.DataSource;
                bs.Filter = opcion == 0 ? "nombre like '%" + valor + "%'" : opcion == 1 ? "direccion like '%" + valor + "%'"
                    : opcion == 2 ? "correo like '%" + valor + "%'" : opcion == 3 ? "telefono like '%" + valor + "%'" :
                    opcion == 4 ? "fechaNacimiento like '%" + valor + "%'" : "fechaRegistro like '%" + valor.ToString() + "%'";
                grdDatosProductos.DataSource = bs;
                erpProductos.SetError(txtBuscarProducto, "");
            }
            catch (Exception e)
            {
                erpProductos.SetError(txtBuscarProducto, "Por favor ingrese dato a buscar");
            }
        }


        //C A M B I A    S E G U N   E L    F O R M U L A R I O
        private void mostrarDatosProducto()
        {
            if (miTabla.Rows.Count > 0)
            {

                txtNombreProducto.Text = miTabla.Rows[posicion].ItemArray[1].ToString().Trim();
                txtMarcaProducto.Text = miTabla.Rows[posicion].ItemArray[2].ToString().Trim();
                txtPrincipiosActivosProducto.Text = miTabla.Rows[posicion].ItemArray[3].ToString().Trim();
                txtPrecioProducto.Text = miTabla.Rows[posicion].ItemArray[4].ToString().Trim();
                txtDescripcionProducto.Text = miTabla.Rows[posicion].ItemArray[5].ToString().Trim();

                lblPosicionProducto.Text = (posicion + 1) + " de " + miTabla.Rows.Count;

            }
            else
            {
                limpiarCajas();
            }
        }

        private void btnSiguienteProducto_Click(object sender, EventArgs e)
        {
            if (posicion < miTabla.Rows.Count - 1)
            {
                posicion++;
                mostrarDatosProducto();
            }
        }

        private void btnUltimoProducto_Click(object sender, EventArgs e)
        {
            posicion = miTabla.Rows.Count - 1;
            mostrarDatosProducto();
        }

        private void btnAnteriorProducto_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatosProducto();
            }

        }

        private void btnPrimeroProducto_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatosProducto();
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            if (btnNuevoProducto.Text == "Nuevo producto")
            {
                btnNuevoProducto.Text = "Guardar";
                btnModificarProducto.Text = "Cancelar";
                estadoControles(false);
                limpiarCajas();
                accion = "nuevo";
            }
            else
            {

                //C A M B I A    S E G U N   E L    F O R M U L A R I O
                try
                {
                    String msg = objConexion.mantenimientoProductos(accion, Convert.ToInt32(miTabla.Rows[posicion].ItemArray[0].ToString()), txtNombreProducto.Text,
                    txtMarcaProducto.Text, txtPrincipiosActivosProducto.Text, Double.Parse(txtPrecioProducto.Text), txtDescripcionProducto.Text);

                    if (msg != "1")
                    {
                        MessageBox.Show("Error en el registro de Productos: " + msg, "Registro de Productos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        actualizarDsProductos();
                        estadoControles(true);
                        btnNuevoProducto.Text = "Nuevo producto";
                        btnModificarProducto.Text = "Modificar datos";
                    }
                    
                }
                catch(Exception ex)
                {
                    erpProductos.SetError(txtPrecioProducto, "Ingrese unicamente valores numéricos");
                }
                
            }
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            if (btnModificarProducto.Text == "Modificar datos")
            {
                btnNuevoProducto.Text = "Guardar";
                btnModificarProducto.Text = "Cancelar";
                estadoControles(false);
                accion = "modificar";
            }
            else
            {

                estadoControles(true);
                mostrarDatosProducto();
                btnNuevoProducto.Text = "Nuevo producto";
                btnModificarProducto.Text = "Modificar datos";
            }
        }


        //C A M B I A    S E G U N   E L    F O R M U L A R I O
        private void estadoControles(Boolean estado)
        {

            txtNombreProducto.ReadOnly = estado;
            txtMarcaProducto.ReadOnly = estado;
            txtPrincipiosActivosProducto.ReadOnly = estado;
            txtPrecioProducto.ReadOnly = estado;
            txtDescripcionProducto.ReadOnly = estado;
            

            grbNavegacionProducto.Enabled = estado;
            btnEliminarProducto.Enabled = estado;
            txtBuscarProducto.ReadOnly = !estado;

        }
        private void limpiarCajas()
        {
            txtNombreProducto.Text = "";
            txtMarcaProducto.Text = "";
            txtPrincipiosActivosProducto.Text = "";
            txtPrecioProducto.Text = "";
            txtDescripcionProducto.Text = "";
        }


        private void txtBuscarProducto_KeyUp(object sender, KeyEventArgs e)
        {
            filtrarProductos(txtBuscarProducto.Text, cboOpcionBuscarProducto.SelectedIndex);
            if (e.KeyValue == 13)
            {//tecla enter
                seleccionarProducto();
            }
        }
        private void seleccionarProducto()
        {
            try
            {
                posicion = miTabla.Rows.IndexOf(miTabla.Rows.Find(grdDatosProductos.CurrentRow.Cells["idProducto"].Value.ToString()));
                mostrarDatosProducto();
            }
            catch { }
        }

        private void grdDatosProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarProducto();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            accion = "eliminar";
            if (MessageBox.Show("Esta seguro de eliminar a " + txtNombreProducto.Text.Trim() + "?", "Eliminado Productos",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


                //C A M B I A    S E G U N   E L    F O R M U L A R I O

                String msg = objConexion.mantenimientoProductos(accion, Convert.ToInt32(miTabla.Rows[posicion].ItemArray[0].ToString()), txtNombreProducto.Text,
                    txtMarcaProducto.Text,txtPrincipiosActivosProducto.Text,double.Parse(txtPrecioProducto.Text),txtDescripcionProducto.Text);
                if (msg != "1")
                {
                    MessageBox.Show("Error en la eliminacion de Productos: " + msg, "Registro de Productos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    posicion = 0;
                    actualizarDsProductos();
                }
            }
            accion = "nuevo";
        }

        private void txtPrecioProducto_TextChanged(object sender, EventArgs e)
        {
            erpProductos.SetError(txtPrecioProducto, "");
        }
    }
}
