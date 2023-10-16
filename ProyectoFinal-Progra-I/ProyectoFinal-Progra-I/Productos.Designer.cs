
namespace ProyectoFinal_Progra_I
{
    partial class Productos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grbNavegacionProducto = new System.Windows.Forms.GroupBox();
            this.btnPrimeroProducto = new System.Windows.Forms.Button();
            this.btnAnteriorProducto = new System.Windows.Forms.Button();
            this.btnUltimoProducto = new System.Windows.Forms.Button();
            this.btnSiguienteProducto = new System.Windows.Forms.Button();
            this.lblPosicionProducto = new System.Windows.Forms.Label();
            this.grbEdicionProducto = new System.Windows.Forms.GroupBox();
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.btnModificarProducto = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.grbDatosProducto = new System.Windows.Forms.GroupBox();
            this.txtDescripcionProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrincipiosActivosProducto = new System.Windows.Forms.TextBox();
            this.txtMarcaProducto = new System.Windows.Forms.TextBox();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboOpcionBuscarProducto = new System.Windows.Forms.ComboBox();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdDatosProductos = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.principiosActivos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.erpProductos = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbNavegacionProducto.SuspendLayout();
            this.grbEdicionProducto.SuspendLayout();
            this.grbDatosProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // grbNavegacionProducto
            // 
            this.grbNavegacionProducto.BackColor = System.Drawing.SystemColors.Control;
            this.grbNavegacionProducto.Controls.Add(this.btnPrimeroProducto);
            this.grbNavegacionProducto.Controls.Add(this.btnAnteriorProducto);
            this.grbNavegacionProducto.Controls.Add(this.btnUltimoProducto);
            this.grbNavegacionProducto.Controls.Add(this.btnSiguienteProducto);
            this.grbNavegacionProducto.Controls.Add(this.lblPosicionProducto);
            this.grbNavegacionProducto.Location = new System.Drawing.Point(908, 547);
            this.grbNavegacionProducto.Name = "grbNavegacionProducto";
            this.grbNavegacionProducto.Size = new System.Drawing.Size(282, 82);
            this.grbNavegacionProducto.TabIndex = 27;
            this.grbNavegacionProducto.TabStop = false;
            this.grbNavegacionProducto.Text = "Navegación";
            // 
            // btnPrimeroProducto
            // 
            this.btnPrimeroProducto.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPrimeroProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroProducto.Location = new System.Drawing.Point(14, 31);
            this.btnPrimeroProducto.Name = "btnPrimeroProducto";
            this.btnPrimeroProducto.Size = new System.Drawing.Size(37, 30);
            this.btnPrimeroProducto.TabIndex = 19;
            this.btnPrimeroProducto.Text = "|<";
            this.btnPrimeroProducto.UseVisualStyleBackColor = false;
            this.btnPrimeroProducto.Click += new System.EventHandler(this.btnPrimeroProducto_Click);
            // 
            // btnAnteriorProducto
            // 
            this.btnAnteriorProducto.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAnteriorProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorProducto.Location = new System.Drawing.Point(57, 31);
            this.btnAnteriorProducto.Name = "btnAnteriorProducto";
            this.btnAnteriorProducto.Size = new System.Drawing.Size(37, 30);
            this.btnAnteriorProducto.TabIndex = 22;
            this.btnAnteriorProducto.Text = "<";
            this.btnAnteriorProducto.UseVisualStyleBackColor = false;
            this.btnAnteriorProducto.Click += new System.EventHandler(this.btnAnteriorProducto_Click);
            // 
            // btnUltimoProducto
            // 
            this.btnUltimoProducto.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnUltimoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoProducto.Location = new System.Drawing.Point(231, 31);
            this.btnUltimoProducto.Name = "btnUltimoProducto";
            this.btnUltimoProducto.Size = new System.Drawing.Size(37, 30);
            this.btnUltimoProducto.TabIndex = 20;
            this.btnUltimoProducto.Text = ">|";
            this.btnUltimoProducto.UseVisualStyleBackColor = false;
            this.btnUltimoProducto.Click += new System.EventHandler(this.btnUltimoProducto_Click);
            // 
            // btnSiguienteProducto
            // 
            this.btnSiguienteProducto.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSiguienteProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteProducto.Location = new System.Drawing.Point(188, 31);
            this.btnSiguienteProducto.Name = "btnSiguienteProducto";
            this.btnSiguienteProducto.Size = new System.Drawing.Size(37, 30);
            this.btnSiguienteProducto.TabIndex = 21;
            this.btnSiguienteProducto.Text = ">";
            this.btnSiguienteProducto.UseVisualStyleBackColor = false;
            this.btnSiguienteProducto.Click += new System.EventHandler(this.btnSiguienteProducto_Click);
            // 
            // lblPosicionProducto
            // 
            this.lblPosicionProducto.AutoSize = true;
            this.lblPosicionProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicionProducto.Location = new System.Drawing.Point(107, 36);
            this.lblPosicionProducto.Name = "lblPosicionProducto";
            this.lblPosicionProducto.Size = new System.Drawing.Size(57, 20);
            this.lblPosicionProducto.TabIndex = 23;
            this.lblPosicionProducto.Text = "x de n";
            // 
            // grbEdicionProducto
            // 
            this.grbEdicionProducto.Controls.Add(this.btnNuevoProducto);
            this.grbEdicionProducto.Controls.Add(this.btnModificarProducto);
            this.grbEdicionProducto.Controls.Add(this.btnEliminarProducto);
            this.grbEdicionProducto.Location = new System.Drawing.Point(533, 547);
            this.grbEdicionProducto.Name = "grbEdicionProducto";
            this.grbEdicionProducto.Size = new System.Drawing.Size(320, 82);
            this.grbEdicionProducto.TabIndex = 26;
            this.grbEdicionProducto.TabStop = false;
            this.grbEdicionProducto.Text = "Edición";
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnNuevoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoProducto.Location = new System.Drawing.Point(17, 19);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(90, 55);
            this.btnNuevoProducto.TabIndex = 18;
            this.btnNuevoProducto.Text = "Nuevo producto";
            this.btnNuevoProducto.UseVisualStyleBackColor = false;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnModificarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarProducto.Location = new System.Drawing.Point(112, 19);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(90, 55);
            this.btnModificarProducto.TabIndex = 16;
            this.btnModificarProducto.Text = "Modificar datos";
            this.btnModificarProducto.UseVisualStyleBackColor = false;
            this.btnModificarProducto.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEliminarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProducto.Location = new System.Drawing.Point(208, 19);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(90, 55);
            this.btnEliminarProducto.TabIndex = 17;
            this.btnEliminarProducto.Text = "Eliminar producto";
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // grbDatosProducto
            // 
            this.grbDatosProducto.Controls.Add(this.txtDescripcionProducto);
            this.grbDatosProducto.Controls.Add(this.label6);
            this.grbDatosProducto.Controls.Add(this.txtPrincipiosActivosProducto);
            this.grbDatosProducto.Controls.Add(this.txtMarcaProducto);
            this.grbDatosProducto.Controls.Add(this.txtPrecioProducto);
            this.grbDatosProducto.Controls.Add(this.txtNombreProducto);
            this.grbDatosProducto.Controls.Add(this.label5);
            this.grbDatosProducto.Controls.Add(this.label2);
            this.grbDatosProducto.Controls.Add(this.label4);
            this.grbDatosProducto.Controls.Add(this.label3);
            this.grbDatosProducto.Location = new System.Drawing.Point(533, 49);
            this.grbDatosProducto.Name = "grbDatosProducto";
            this.grbDatosProducto.Size = new System.Drawing.Size(657, 472);
            this.grbDatosProducto.TabIndex = 32;
            this.grbDatosProducto.TabStop = false;
            this.grbDatosProducto.Text = "Información del producto";
            // 
            // txtDescripcionProducto
            // 
            this.txtDescripcionProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionProducto.Location = new System.Drawing.Point(208, 324);
            this.txtDescripcionProducto.Name = "txtDescripcionProducto";
            this.txtDescripcionProducto.ReadOnly = true;
            this.txtDescripcionProducto.Size = new System.Drawing.Size(430, 26);
            this.txtDescripcionProducto.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(99, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Descripción";
            // 
            // txtPrincipiosActivosProducto
            // 
            this.txtPrincipiosActivosProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrincipiosActivosProducto.Location = new System.Drawing.Point(208, 244);
            this.txtPrincipiosActivosProducto.Name = "txtPrincipiosActivosProducto";
            this.txtPrincipiosActivosProducto.ReadOnly = true;
            this.txtPrincipiosActivosProducto.Size = new System.Drawing.Size(430, 26);
            this.txtPrincipiosActivosProducto.TabIndex = 11;
            // 
            // txtMarcaProducto
            // 
            this.txtMarcaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarcaProducto.Location = new System.Drawing.Point(208, 160);
            this.txtMarcaProducto.Name = "txtMarcaProducto";
            this.txtMarcaProducto.ReadOnly = true;
            this.txtMarcaProducto.Size = new System.Drawing.Size(430, 26);
            this.txtMarcaProducto.TabIndex = 10;
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioProducto.Location = new System.Drawing.Point(208, 405);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.ReadOnly = true;
            this.txtPrecioProducto.Size = new System.Drawing.Size(430, 26);
            this.txtPrecioProducto.TabIndex = 9;
            this.txtPrecioProducto.TextChanged += new System.EventHandler(this.txtPrecioProducto_TextChanged);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(208, 78);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.ReadOnly = true;
            this.txtNombreProducto.Size = new System.Drawing.Size(430, 26);
            this.txtNombreProducto.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Precio ($)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Principios activos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(124, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Marca";
            // 
            // cboOpcionBuscarProducto
            // 
            this.cboOpcionBuscarProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOpcionBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOpcionBuscarProducto.FormattingEnabled = true;
            this.cboOpcionBuscarProducto.Items.AddRange(new object[] {
            "Nombre",
            "Dirección",
            "Correo",
            "Teléfono",
            "Fecha de nacimiento",
            "Fecha de registro"});
            this.cboOpcionBuscarProducto.Location = new System.Drawing.Point(95, 49);
            this.cboOpcionBuscarProducto.Name = "cboOpcionBuscarProducto";
            this.cboOpcionBuscarProducto.Size = new System.Drawing.Size(154, 28);
            this.cboOpcionBuscarProducto.TabIndex = 31;
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarProducto.Location = new System.Drawing.Point(264, 49);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(249, 26);
            this.txtBuscarProducto.TabIndex = 30;
            this.txtBuscarProducto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarProducto_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Buscar";
            // 
            // grdDatosProductos
            // 
            this.grdDatosProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.nombre,
            this.marca,
            this.principiosActivos,
            this.precio,
            this.descripcion});
            this.grdDatosProductos.Location = new System.Drawing.Point(23, 89);
            this.grdDatosProductos.Name = "grdDatosProductos";
            this.grdDatosProductos.Size = new System.Drawing.Size(490, 540);
            this.grdDatosProductos.TabIndex = 28;
            this.grdDatosProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatosProductos_CellClick);
            // 
            // idProducto
            // 
            this.idProducto.DataPropertyName = "idProducto";
            this.idProducto.HeaderText = "ID";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Visible = false;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // marca
            // 
            this.marca.DataPropertyName = "marca";
            this.marca.HeaderText = "Marca";
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            // 
            // principiosActivos
            // 
            this.principiosActivos.DataPropertyName = "principiosActivos";
            this.principiosActivos.HeaderText = "Principios activos";
            this.principiosActivos.Name = "principiosActivos";
            this.principiosActivos.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "precio";
            this.precio.HeaderText = "Precio ($)";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 50;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // erpProductos
            // 
            this.erpProductos.ContainerControl = this;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.ControlBox = false;
            this.Controls.Add(this.grbDatosProducto);
            this.Controls.Add(this.cboOpcionBuscarProducto);
            this.Controls.Add(this.txtBuscarProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdDatosProductos);
            this.Controls.Add(this.grbNavegacionProducto);
            this.Controls.Add(this.grbEdicionProducto);
            this.Name = "Productos";
            this.Text = "Productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Productos_Load);
            this.grbNavegacionProducto.ResumeLayout(false);
            this.grbNavegacionProducto.PerformLayout();
            this.grbEdicionProducto.ResumeLayout(false);
            this.grbDatosProducto.ResumeLayout(false);
            this.grbDatosProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbNavegacionProducto;
        private System.Windows.Forms.Button btnPrimeroProducto;
        private System.Windows.Forms.Button btnAnteriorProducto;
        private System.Windows.Forms.Button btnUltimoProducto;
        private System.Windows.Forms.Button btnSiguienteProducto;
        private System.Windows.Forms.Label lblPosicionProducto;
        private System.Windows.Forms.GroupBox grbEdicionProducto;
        private System.Windows.Forms.Button btnNuevoProducto;
        private System.Windows.Forms.Button btnModificarProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.GroupBox grbDatosProducto;
        private System.Windows.Forms.TextBox txtPrincipiosActivosProducto;
        private System.Windows.Forms.TextBox txtMarcaProducto;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboOpcionBuscarProducto;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdDatosProductos;
        private System.Windows.Forms.TextBox txtDescripcionProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn principiosActivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.ErrorProvider erpProductos;
    }
}