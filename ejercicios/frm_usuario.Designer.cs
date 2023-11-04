
namespace ejercicios
{
    partial class frm_usuario
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
            this.txtBuscarUsuarios = new System.Windows.Forms.TextBox();
            this.cboBuscarUsuarios = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbrEdicionUsuarios = new System.Windows.Forms.GroupBox();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.btnNuevoUsuario = new System.Windows.Forms.Button();
            this.grbNavegacionUsuarios = new System.Windows.Forms.GroupBox();
            this.lblRegistroUsuario = new System.Windows.Forms.Label();
            this.btnUltimoUsuario = new System.Windows.Forms.Button();
            this.btnAnteriorUsuario = new System.Windows.Forms.Button();
            this.btnSiguienteUsuario = new System.Windows.Forms.Button();
            this.btnPrimeroUsuario = new System.Windows.Forms.Button();
            this.grbDatosUsuario = new System.Windows.Forms.GroupBox();
            this.txtDireccionfrmUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombrefrmUsuario = new System.Windows.Forms.TextBox();
            this.txtClavefrmUsuario = new System.Windows.Forms.TextBox();
            this.txtUsuariofrmUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.grdDatosUsuario = new System.Windows.Forms.DataGridView();
            this.txtTelefonofrmUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbrEdicionUsuarios.SuspendLayout();
            this.grbNavegacionUsuarios.SuspendLayout();
            this.grbDatosUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarUsuarios
            // 
            this.txtBuscarUsuarios.Location = new System.Drawing.Point(755, 51);
            this.txtBuscarUsuarios.Name = "txtBuscarUsuarios";
            this.txtBuscarUsuarios.Size = new System.Drawing.Size(182, 20);
            this.txtBuscarUsuarios.TabIndex = 20;
            this.txtBuscarUsuarios.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarUsuarios_KeyUp);
            // 
            // cboBuscarUsuarios
            // 
            this.cboBuscarUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscarUsuarios.FormattingEnabled = true;
            this.cboBuscarUsuarios.Items.AddRange(new object[] {
            "Nombre",
            "Usuario"});
            this.cboBuscarUsuarios.Location = new System.Drawing.Point(628, 51);
            this.cboBuscarUsuarios.Name = "cboBuscarUsuarios";
            this.cboBuscarUsuarios.Size = new System.Drawing.Size(121, 21);
            this.cboBuscarUsuarios.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(567, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Buscar:";
            // 
            // gbrEdicionUsuarios
            // 
            this.gbrEdicionUsuarios.Controls.Add(this.btnEliminarUsuario);
            this.gbrEdicionUsuarios.Controls.Add(this.btnModificarUsuario);
            this.gbrEdicionUsuarios.Controls.Add(this.btnNuevoUsuario);
            this.gbrEdicionUsuarios.Location = new System.Drawing.Point(266, 334);
            this.gbrEdicionUsuarios.Name = "gbrEdicionUsuarios";
            this.gbrEdicionUsuarios.Size = new System.Drawing.Size(295, 100);
            this.gbrEdicionUsuarios.TabIndex = 17;
            this.gbrEdicionUsuarios.TabStop = false;
            this.gbrEdicionUsuarios.Text = "Edición";
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuario.ForeColor = System.Drawing.Color.Red;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(215, 69);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(74, 23);
            this.btnEliminarUsuario.TabIndex = 2;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarUsuario.Location = new System.Drawing.Point(105, 69);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(84, 23);
            this.btnModificarUsuario.TabIndex = 1;
            this.btnModificarUsuario.Text = "Modificar";
            this.btnModificarUsuario.UseVisualStyleBackColor = true;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoUsuario.Location = new System.Drawing.Point(11, 69);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(83, 23);
            this.btnNuevoUsuario.TabIndex = 0;
            this.btnNuevoUsuario.Text = "Nuevo";
            this.btnNuevoUsuario.UseVisualStyleBackColor = true;
            this.btnNuevoUsuario.Click += new System.EventHandler(this.btnNuevoUsuario_Click);
            // 
            // grbNavegacionUsuarios
            // 
            this.grbNavegacionUsuarios.Controls.Add(this.lblRegistroUsuario);
            this.grbNavegacionUsuarios.Controls.Add(this.btnUltimoUsuario);
            this.grbNavegacionUsuarios.Controls.Add(this.btnAnteriorUsuario);
            this.grbNavegacionUsuarios.Controls.Add(this.btnSiguienteUsuario);
            this.grbNavegacionUsuarios.Controls.Add(this.btnPrimeroUsuario);
            this.grbNavegacionUsuarios.Location = new System.Drawing.Point(12, 334);
            this.grbNavegacionUsuarios.Name = "grbNavegacionUsuarios";
            this.grbNavegacionUsuarios.Size = new System.Drawing.Size(237, 100);
            this.grbNavegacionUsuarios.TabIndex = 16;
            this.grbNavegacionUsuarios.TabStop = false;
            this.grbNavegacionUsuarios.Text = "Navegación";
            // 
            // lblRegistroUsuario
            // 
            this.lblRegistroUsuario.AutoSize = true;
            this.lblRegistroUsuario.Location = new System.Drawing.Point(103, 74);
            this.lblRegistroUsuario.Name = "lblRegistroUsuario";
            this.lblRegistroUsuario.Size = new System.Drawing.Size(37, 13);
            this.lblRegistroUsuario.TabIndex = 4;
            this.lblRegistroUsuario.Text = "1 de 1";
            // 
            // btnUltimoUsuario
            // 
            this.btnUltimoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoUsuario.Location = new System.Drawing.Point(190, 65);
            this.btnUltimoUsuario.Name = "btnUltimoUsuario";
            this.btnUltimoUsuario.Size = new System.Drawing.Size(41, 29);
            this.btnUltimoUsuario.TabIndex = 3;
            this.btnUltimoUsuario.Text = ">|";
            this.btnUltimoUsuario.UseVisualStyleBackColor = true;
            this.btnUltimoUsuario.Click += new System.EventHandler(this.btnUltimoUsuario_Click);
            // 
            // btnAnteriorUsuario
            // 
            this.btnAnteriorUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorUsuario.Location = new System.Drawing.Point(44, 65);
            this.btnAnteriorUsuario.Name = "btnAnteriorUsuario";
            this.btnAnteriorUsuario.Size = new System.Drawing.Size(41, 29);
            this.btnAnteriorUsuario.TabIndex = 2;
            this.btnAnteriorUsuario.Text = "<";
            this.btnAnteriorUsuario.UseVisualStyleBackColor = true;
            this.btnAnteriorUsuario.Click += new System.EventHandler(this.btnAnteriorUsuario_Click);
            // 
            // btnSiguienteUsuario
            // 
            this.btnSiguienteUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteUsuario.Location = new System.Drawing.Point(156, 65);
            this.btnSiguienteUsuario.Name = "btnSiguienteUsuario";
            this.btnSiguienteUsuario.Size = new System.Drawing.Size(41, 29);
            this.btnSiguienteUsuario.TabIndex = 1;
            this.btnSiguienteUsuario.Text = ">";
            this.btnSiguienteUsuario.UseVisualStyleBackColor = true;
            this.btnSiguienteUsuario.Click += new System.EventHandler(this.btnSiguienteUsuario_Click);
            // 
            // btnPrimeroUsuario
            // 
            this.btnPrimeroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroUsuario.Location = new System.Drawing.Point(6, 65);
            this.btnPrimeroUsuario.Name = "btnPrimeroUsuario";
            this.btnPrimeroUsuario.Size = new System.Drawing.Size(41, 29);
            this.btnPrimeroUsuario.TabIndex = 0;
            this.btnPrimeroUsuario.Text = "|<";
            this.btnPrimeroUsuario.UseVisualStyleBackColor = true;
            this.btnPrimeroUsuario.Click += new System.EventHandler(this.btnPrimeroUsuario_Click);
            // 
            // grbDatosUsuario
            // 
            this.grbDatosUsuario.Controls.Add(this.txtTelefonofrmUsuario);
            this.grbDatosUsuario.Controls.Add(this.label1);
            this.grbDatosUsuario.Controls.Add(this.txtDireccionfrmUsuario);
            this.grbDatosUsuario.Controls.Add(this.label5);
            this.grbDatosUsuario.Controls.Add(this.txtNombrefrmUsuario);
            this.grbDatosUsuario.Controls.Add(this.txtClavefrmUsuario);
            this.grbDatosUsuario.Controls.Add(this.txtUsuariofrmUsuario);
            this.grbDatosUsuario.Controls.Add(this.label4);
            this.grbDatosUsuario.Controls.Add(this.label3);
            this.grbDatosUsuario.Controls.Add(this.lblUsuario);
            this.grbDatosUsuario.Location = new System.Drawing.Point(12, 23);
            this.grbDatosUsuario.Name = "grbDatosUsuario";
            this.grbDatosUsuario.Size = new System.Drawing.Size(549, 305);
            this.grbDatosUsuario.TabIndex = 15;
            this.grbDatosUsuario.TabStop = false;
            this.grbDatosUsuario.Text = "Datos Usuario";
            // 
            // txtDireccionfrmUsuario
            // 
            this.txtDireccionfrmUsuario.Location = new System.Drawing.Point(77, 172);
            this.txtDireccionfrmUsuario.Name = "txtDireccionfrmUsuario";
            this.txtDireccionfrmUsuario.ReadOnly = true;
            this.txtDireccionfrmUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtDireccionfrmUsuario.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Dirección:";
            // 
            // txtNombrefrmUsuario
            // 
            this.txtNombrefrmUsuario.Location = new System.Drawing.Point(77, 133);
            this.txtNombrefrmUsuario.Name = "txtNombrefrmUsuario";
            this.txtNombrefrmUsuario.ReadOnly = true;
            this.txtNombrefrmUsuario.Size = new System.Drawing.Size(271, 20);
            this.txtNombrefrmUsuario.TabIndex = 5;
            // 
            // txtClavefrmUsuario
            // 
            this.txtClavefrmUsuario.Location = new System.Drawing.Point(77, 83);
            this.txtClavefrmUsuario.Name = "txtClavefrmUsuario";
            this.txtClavefrmUsuario.ReadOnly = true;
            this.txtClavefrmUsuario.Size = new System.Drawing.Size(271, 20);
            this.txtClavefrmUsuario.TabIndex = 4;
            this.txtClavefrmUsuario.Enter += new System.EventHandler(this.v);
            // 
            // txtUsuariofrmUsuario
            // 
            this.txtUsuariofrmUsuario.Location = new System.Drawing.Point(77, 36);
            this.txtUsuariofrmUsuario.Name = "txtUsuariofrmUsuario";
            this.txtUsuariofrmUsuario.ReadOnly = true;
            this.txtUsuariofrmUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuariofrmUsuario.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Clave:";
            this.label3.Enter += new System.EventHandler(this.v);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(7, 39);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // grdDatosUsuario
            // 
            this.grdDatosUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAlumno,
            this.usuario,
            this.clave,
            this.nombre,
            this.direccion,
            this.telefono});
            this.grdDatosUsuario.Location = new System.Drawing.Point(582, 84);
            this.grdDatosUsuario.Name = "grdDatosUsuario";
            this.grdDatosUsuario.Size = new System.Drawing.Size(423, 262);
            this.grdDatosUsuario.TabIndex = 14;
            this.grdDatosUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatosUsuario_CellClick);
            // 
            // txtTelefonofrmUsuario
            // 
            this.txtTelefonofrmUsuario.Location = new System.Drawing.Point(77, 218);
            this.txtTelefonofrmUsuario.Name = "txtTelefonofrmUsuario";
            this.txtTelefonofrmUsuario.ReadOnly = true;
            this.txtTelefonofrmUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtTelefonofrmUsuario.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Teléfono:";
            // 
            // idAlumno
            // 
            this.idAlumno.DataPropertyName = "idAlumno";
            this.idAlumno.HeaderText = "ID";
            this.idAlumno.Name = "idAlumno";
            this.idAlumno.ReadOnly = true;
            this.idAlumno.Visible = false;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "usuario";
            this.usuario.HeaderText = "USUARIO";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            // 
            // clave
            // 
            this.clave.DataPropertyName = "clave";
            this.clave.HeaderText = "CLAVE";
            this.clave.Name = "clave";
            this.clave.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "DIRECCION";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "TELEFONO";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // frm_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 446);
            this.Controls.Add(this.txtBuscarUsuarios);
            this.Controls.Add(this.cboBuscarUsuarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbrEdicionUsuarios);
            this.Controls.Add(this.grbNavegacionUsuarios);
            this.Controls.Add(this.grbDatosUsuario);
            this.Controls.Add(this.grdDatosUsuario);
            this.Name = "frm_usuario";
            this.Text = "frm_usuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_usuario_Load);
            this.gbrEdicionUsuarios.ResumeLayout(false);
            this.grbNavegacionUsuarios.ResumeLayout(false);
            this.grbNavegacionUsuarios.PerformLayout();
            this.grbDatosUsuario.ResumeLayout(false);
            this.grbDatosUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscarUsuarios;
        private System.Windows.Forms.ComboBox cboBuscarUsuarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbrEdicionUsuarios;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.Button btnNuevoUsuario;
        private System.Windows.Forms.GroupBox grbNavegacionUsuarios;
        private System.Windows.Forms.Label lblRegistroUsuario;
        private System.Windows.Forms.Button btnUltimoUsuario;
        private System.Windows.Forms.Button btnAnteriorUsuario;
        private System.Windows.Forms.Button btnSiguienteUsuario;
        private System.Windows.Forms.Button btnPrimeroUsuario;
        private System.Windows.Forms.GroupBox grbDatosUsuario;
        private System.Windows.Forms.TextBox txtDireccionfrmUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombrefrmUsuario;
        private System.Windows.Forms.TextBox txtClavefrmUsuario;
        private System.Windows.Forms.TextBox txtUsuariofrmUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.DataGridView grdDatosUsuario;
        private System.Windows.Forms.TextBox txtTelefonofrmUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
    }
}