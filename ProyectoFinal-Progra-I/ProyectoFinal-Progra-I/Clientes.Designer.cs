
namespace ProyectoFinal_Progra_I
{
    partial class Clientes
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
            this.grdDatosClientes = new System.Windows.Forms.DataGridView();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtCorreoCliente = new System.Windows.Forms.TextBox();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.txtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.dtpNacimietoCliente = new System.Windows.Forms.DateTimePicker();
            this.dtpRegistroCliente = new System.Windows.Forms.DateTimePicker();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.cboOpcionBuscarCliente = new System.Windows.Forms.ComboBox();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.btnPrimeroCliente = new System.Windows.Forms.Button();
            this.btnUltimoCliente = new System.Windows.Forms.Button();
            this.btnSiguienteCliente = new System.Windows.Forms.Button();
            this.btnAnteriorCliente = new System.Windows.Forms.Button();
            this.lblPosicionCliente = new System.Windows.Forms.Label();
            this.grbEdicionCliente = new System.Windows.Forms.GroupBox();
            this.grbNavegacionCliente = new System.Windows.Forms.GroupBox();
            this.grbDatosCliente = new System.Windows.Forms.GroupBox();
            this.erpClientes = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosClientes)).BeginInit();
            this.grbEdicionCliente.SuspendLayout();
            this.grbNavegacionCliente.SuspendLayout();
            this.grbDatosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDatosClientes
            // 
            this.grdDatosClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCliente,
            this.nombre,
            this.direccion,
            this.correo,
            this.telefono,
            this.fechaRegistro,
            this.fechaNacimiento});
            this.grdDatosClientes.Location = new System.Drawing.Point(26, 106);
            this.grdDatosClientes.Name = "grdDatosClientes";
            this.grdDatosClientes.Size = new System.Drawing.Size(490, 540);
            this.grdDatosClientes.TabIndex = 0;
            this.grdDatosClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatosClientes_CellClick);
            // 
            // idCliente
            // 
            this.idCliente.DataPropertyName = "idCliente";
            this.idCliente.HeaderText = "ID";
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            this.idCliente.Visible = false;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "Dirección";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // correo
            // 
            this.correo.DataPropertyName = "correo";
            this.correo.HeaderText = "Correo";
            this.correo.Name = "correo";
            this.correo.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "Teléfono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 50;
            // 
            // fechaRegistro
            // 
            this.fechaRegistro.DataPropertyName = "fechaRegistro";
            this.fechaRegistro.HeaderText = "Fecha de registro";
            this.fechaRegistro.Name = "fechaRegistro";
            this.fechaRegistro.ReadOnly = true;
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.DataPropertyName = "fechaNacimiento";
            this.fechaNacimiento.HeaderText = "Fecha de nacimiento";
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Teléfono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dirección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Correo electrónico";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fecha de nacimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 423);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Fecha de registro";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(195, 40);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(430, 26);
            this.txtNombreCliente.TabIndex = 8;
            // 
            // txtCorreoCliente
            // 
            this.txtCorreoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoCliente.Location = new System.Drawing.Point(195, 287);
            this.txtCorreoCliente.Name = "txtCorreoCliente";
            this.txtCorreoCliente.ReadOnly = true;
            this.txtCorreoCliente.Size = new System.Drawing.Size(430, 26);
            this.txtCorreoCliente.TabIndex = 9;
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionCliente.Location = new System.Drawing.Point(195, 202);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.ReadOnly = true;
            this.txtDireccionCliente.Size = new System.Drawing.Size(430, 26);
            this.txtDireccionCliente.TabIndex = 10;
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoCliente.Location = new System.Drawing.Point(195, 123);
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.ReadOnly = true;
            this.txtTelefonoCliente.Size = new System.Drawing.Size(430, 26);
            this.txtTelefonoCliente.TabIndex = 11;
            // 
            // dtpNacimietoCliente
            // 
            this.dtpNacimietoCliente.Enabled = false;
            this.dtpNacimietoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNacimietoCliente.Location = new System.Drawing.Point(195, 354);
            this.dtpNacimietoCliente.Name = "dtpNacimietoCliente";
            this.dtpNacimietoCliente.Size = new System.Drawing.Size(336, 26);
            this.dtpNacimietoCliente.TabIndex = 12;
            // 
            // dtpRegistroCliente
            // 
            this.dtpRegistroCliente.Enabled = false;
            this.dtpRegistroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRegistroCliente.Location = new System.Drawing.Point(195, 423);
            this.dtpRegistroCliente.Name = "dtpRegistroCliente";
            this.dtpRegistroCliente.Size = new System.Drawing.Size(336, 26);
            this.dtpRegistroCliente.TabIndex = 13;
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCliente.Location = new System.Drawing.Point(267, 66);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(249, 26);
            this.txtBuscarCliente.TabIndex = 14;
            this.txtBuscarCliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarCliente_KeyUp);
            // 
            // cboOpcionBuscarCliente
            // 
            this.cboOpcionBuscarCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOpcionBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOpcionBuscarCliente.FormattingEnabled = true;
            this.cboOpcionBuscarCliente.Items.AddRange(new object[] {
            "Nombre",
            "Dirección",
            "Correo",
            "Teléfono",
            "Fecha de nacimiento",
            "Fecha de registro"});
            this.cboOpcionBuscarCliente.Location = new System.Drawing.Point(98, 66);
            this.cboOpcionBuscarCliente.Name = "cboOpcionBuscarCliente";
            this.cboOpcionBuscarCliente.Size = new System.Drawing.Size(154, 28);
            this.cboOpcionBuscarCliente.TabIndex = 15;
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnModificarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCliente.Location = new System.Drawing.Point(112, 19);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(90, 55);
            this.btnModificarCliente.TabIndex = 16;
            this.btnModificarCliente.Text = "Modificar datos";
            this.btnModificarCliente.UseVisualStyleBackColor = false;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEliminarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCliente.Location = new System.Drawing.Point(208, 19);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(90, 55);
            this.btnEliminarCliente.TabIndex = 17;
            this.btnEliminarCliente.Text = "Eliminar Cliente";
            this.btnEliminarCliente.UseVisualStyleBackColor = false;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnNuevoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCliente.Location = new System.Drawing.Point(17, 19);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(90, 55);
            this.btnNuevoCliente.TabIndex = 18;
            this.btnNuevoCliente.Text = "Nuevo cliente";
            this.btnNuevoCliente.UseVisualStyleBackColor = false;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // btnPrimeroCliente
            // 
            this.btnPrimeroCliente.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPrimeroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroCliente.Location = new System.Drawing.Point(14, 31);
            this.btnPrimeroCliente.Name = "btnPrimeroCliente";
            this.btnPrimeroCliente.Size = new System.Drawing.Size(37, 30);
            this.btnPrimeroCliente.TabIndex = 19;
            this.btnPrimeroCliente.Text = "|<";
            this.btnPrimeroCliente.UseVisualStyleBackColor = false;
            this.btnPrimeroCliente.Click += new System.EventHandler(this.btnPrimeroCliente_Click);
            // 
            // btnUltimoCliente
            // 
            this.btnUltimoCliente.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnUltimoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoCliente.Location = new System.Drawing.Point(231, 31);
            this.btnUltimoCliente.Name = "btnUltimoCliente";
            this.btnUltimoCliente.Size = new System.Drawing.Size(37, 30);
            this.btnUltimoCliente.TabIndex = 20;
            this.btnUltimoCliente.Text = ">|";
            this.btnUltimoCliente.UseVisualStyleBackColor = false;
            this.btnUltimoCliente.Click += new System.EventHandler(this.btnUltimoCliente_Click);
            // 
            // btnSiguienteCliente
            // 
            this.btnSiguienteCliente.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSiguienteCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteCliente.Location = new System.Drawing.Point(188, 31);
            this.btnSiguienteCliente.Name = "btnSiguienteCliente";
            this.btnSiguienteCliente.Size = new System.Drawing.Size(37, 30);
            this.btnSiguienteCliente.TabIndex = 21;
            this.btnSiguienteCliente.Text = ">";
            this.btnSiguienteCliente.UseVisualStyleBackColor = false;
            this.btnSiguienteCliente.Click += new System.EventHandler(this.btnSiguienteCliente_Click);
            // 
            // btnAnteriorCliente
            // 
            this.btnAnteriorCliente.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAnteriorCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorCliente.Location = new System.Drawing.Point(57, 31);
            this.btnAnteriorCliente.Name = "btnAnteriorCliente";
            this.btnAnteriorCliente.Size = new System.Drawing.Size(37, 30);
            this.btnAnteriorCliente.TabIndex = 22;
            this.btnAnteriorCliente.Text = "<";
            this.btnAnteriorCliente.UseVisualStyleBackColor = false;
            this.btnAnteriorCliente.Click += new System.EventHandler(this.btnAnteriorCliente_Click);
            // 
            // lblPosicionCliente
            // 
            this.lblPosicionCliente.AutoSize = true;
            this.lblPosicionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicionCliente.Location = new System.Drawing.Point(107, 36);
            this.lblPosicionCliente.Name = "lblPosicionCliente";
            this.lblPosicionCliente.Size = new System.Drawing.Size(57, 20);
            this.lblPosicionCliente.TabIndex = 23;
            this.lblPosicionCliente.Text = "x de n";
            // 
            // grbEdicionCliente
            // 
            this.grbEdicionCliente.Controls.Add(this.btnNuevoCliente);
            this.grbEdicionCliente.Controls.Add(this.btnModificarCliente);
            this.grbEdicionCliente.Controls.Add(this.btnEliminarCliente);
            this.grbEdicionCliente.Location = new System.Drawing.Point(536, 564);
            this.grbEdicionCliente.Name = "grbEdicionCliente";
            this.grbEdicionCliente.Size = new System.Drawing.Size(331, 82);
            this.grbEdicionCliente.TabIndex = 24;
            this.grbEdicionCliente.TabStop = false;
            this.grbEdicionCliente.Text = "Edición";
            // 
            // grbNavegacionCliente
            // 
            this.grbNavegacionCliente.BackColor = System.Drawing.SystemColors.Control;
            this.grbNavegacionCliente.Controls.Add(this.btnPrimeroCliente);
            this.grbNavegacionCliente.Controls.Add(this.btnAnteriorCliente);
            this.grbNavegacionCliente.Controls.Add(this.btnUltimoCliente);
            this.grbNavegacionCliente.Controls.Add(this.btnSiguienteCliente);
            this.grbNavegacionCliente.Controls.Add(this.lblPosicionCliente);
            this.grbNavegacionCliente.Location = new System.Drawing.Point(915, 564);
            this.grbNavegacionCliente.Name = "grbNavegacionCliente";
            this.grbNavegacionCliente.Size = new System.Drawing.Size(278, 82);
            this.grbNavegacionCliente.TabIndex = 25;
            this.grbNavegacionCliente.TabStop = false;
            this.grbNavegacionCliente.Text = "Navegación";
            // 
            // grbDatosCliente
            // 
            this.grbDatosCliente.Controls.Add(this.txtTelefonoCliente);
            this.grbDatosCliente.Controls.Add(this.txtDireccionCliente);
            this.grbDatosCliente.Controls.Add(this.txtCorreoCliente);
            this.grbDatosCliente.Controls.Add(this.txtNombreCliente);
            this.grbDatosCliente.Controls.Add(this.dtpNacimietoCliente);
            this.grbDatosCliente.Controls.Add(this.label7);
            this.grbDatosCliente.Controls.Add(this.label6);
            this.grbDatosCliente.Controls.Add(this.dtpRegistroCliente);
            this.grbDatosCliente.Controls.Add(this.label5);
            this.grbDatosCliente.Controls.Add(this.label2);
            this.grbDatosCliente.Controls.Add(this.label4);
            this.grbDatosCliente.Controls.Add(this.label3);
            this.grbDatosCliente.Location = new System.Drawing.Point(536, 66);
            this.grbDatosCliente.Name = "grbDatosCliente";
            this.grbDatosCliente.Size = new System.Drawing.Size(657, 472);
            this.grbDatosCliente.TabIndex = 26;
            this.grbDatosCliente.TabStop = false;
            this.grbDatosCliente.Text = "Datos del cliente";
            // 
            // erpClientes
            // 
            this.erpClientes.ContainerControl = this;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.ControlBox = false;
            this.Controls.Add(this.grbDatosCliente);
            this.Controls.Add(this.grbNavegacionCliente);
            this.Controls.Add(this.grbEdicionCliente);
            this.Controls.Add(this.cboOpcionBuscarCliente);
            this.Controls.Add(this.txtBuscarCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdDatosClientes);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosClientes)).EndInit();
            this.grbEdicionCliente.ResumeLayout(false);
            this.grbNavegacionCliente.ResumeLayout(false);
            this.grbNavegacionCliente.PerformLayout();
            this.grbDatosCliente.ResumeLayout(false);
            this.grbDatosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdDatosClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtCorreoCliente;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.TextBox txtTelefonoCliente;
        private System.Windows.Forms.DateTimePicker dtpNacimietoCliente;
        private System.Windows.Forms.DateTimePicker dtpRegistroCliente;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.ComboBox cboOpcionBuscarCliente;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.Button btnPrimeroCliente;
        private System.Windows.Forms.Button btnUltimoCliente;
        private System.Windows.Forms.Button btnSiguienteCliente;
        private System.Windows.Forms.Button btnAnteriorCliente;
        private System.Windows.Forms.Label lblPosicionCliente;
        private System.Windows.Forms.GroupBox grbEdicionCliente;
        private System.Windows.Forms.GroupBox grbNavegacionCliente;
        private System.Windows.Forms.GroupBox grbDatosCliente;
        private System.Windows.Forms.ErrorProvider erpClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimiento;
    }
}