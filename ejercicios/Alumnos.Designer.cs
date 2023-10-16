
namespace ejercicios
{
    partial class Alumnos
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
            this.txtBuscarAlumnos = new System.Windows.Forms.TextBox();
            this.cboBuscarAlumnos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbrEdicionAlumnos = new System.Windows.Forms.GroupBox();
            this.btnEliminarAlumno = new System.Windows.Forms.Button();
            this.btnModificarAlumno = new System.Windows.Forms.Button();
            this.btnNuevoAlumno = new System.Windows.Forms.Button();
            this.grbNavegacionAlumnos = new System.Windows.Forms.GroupBox();
            this.lblRegistroAlumno = new System.Windows.Forms.Label();
            this.btnUltimoAlumno = new System.Windows.Forms.Button();
            this.btnAnteriorAlumno = new System.Windows.Forms.Button();
            this.btnSiguienteAlumno = new System.Windows.Forms.Button();
            this.btnPrimeroAlumno = new System.Windows.Forms.Button();
            this.grbDatosAlumno = new System.Windows.Forms.GroupBox();
            this.txtTelefonoAlumno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDireccionAlumnos = new System.Windows.Forms.TextBox();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.txtCodigoAlumno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grdDatosAlumno = new System.Windows.Forms.DataGridView();
            this.idAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbrEdicionAlumnos.SuspendLayout();
            this.grbNavegacionAlumnos.SuspendLayout();
            this.grbDatosAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarAlumnos
            // 
            this.txtBuscarAlumnos.Location = new System.Drawing.Point(755, 52);
            this.txtBuscarAlumnos.Name = "txtBuscarAlumnos";
            this.txtBuscarAlumnos.Size = new System.Drawing.Size(182, 20);
            this.txtBuscarAlumnos.TabIndex = 13;
            this.txtBuscarAlumnos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarAlumnos_KeyUp);
            // 
            // cboBuscarAlumnos
            // 
            this.cboBuscarAlumnos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscarAlumnos.FormattingEnabled = true;
            this.cboBuscarAlumnos.Items.AddRange(new object[] {
            "Código",
            "Nombre"});
            this.cboBuscarAlumnos.Location = new System.Drawing.Point(628, 52);
            this.cboBuscarAlumnos.Name = "cboBuscarAlumnos";
            this.cboBuscarAlumnos.Size = new System.Drawing.Size(121, 21);
            this.cboBuscarAlumnos.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(567, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Buscar:";
            // 
            // gbrEdicionAlumnos
            // 
            this.gbrEdicionAlumnos.Controls.Add(this.btnEliminarAlumno);
            this.gbrEdicionAlumnos.Controls.Add(this.btnModificarAlumno);
            this.gbrEdicionAlumnos.Controls.Add(this.btnNuevoAlumno);
            this.gbrEdicionAlumnos.Location = new System.Drawing.Point(266, 247);
            this.gbrEdicionAlumnos.Name = "gbrEdicionAlumnos";
            this.gbrEdicionAlumnos.Size = new System.Drawing.Size(295, 100);
            this.gbrEdicionAlumnos.TabIndex = 10;
            this.gbrEdicionAlumnos.TabStop = false;
            this.gbrEdicionAlumnos.Text = "Edición";
            // 
            // btnEliminarAlumno
            // 
            this.btnEliminarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAlumno.ForeColor = System.Drawing.Color.Red;
            this.btnEliminarAlumno.Location = new System.Drawing.Point(215, 69);
            this.btnEliminarAlumno.Name = "btnEliminarAlumno";
            this.btnEliminarAlumno.Size = new System.Drawing.Size(74, 23);
            this.btnEliminarAlumno.TabIndex = 2;
            this.btnEliminarAlumno.Text = "Eliminar";
            this.btnEliminarAlumno.UseVisualStyleBackColor = true;
            this.btnEliminarAlumno.Click += new System.EventHandler(this.btnEliminarAlumno_Click);
            // 
            // btnModificarAlumno
            // 
            this.btnModificarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarAlumno.Location = new System.Drawing.Point(105, 69);
            this.btnModificarAlumno.Name = "btnModificarAlumno";
            this.btnModificarAlumno.Size = new System.Drawing.Size(84, 23);
            this.btnModificarAlumno.TabIndex = 1;
            this.btnModificarAlumno.Text = "Modificar";
            this.btnModificarAlumno.UseVisualStyleBackColor = true;
            this.btnModificarAlumno.Click += new System.EventHandler(this.btnModificarAlumno_Click);
            // 
            // btnNuevoAlumno
            // 
            this.btnNuevoAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoAlumno.Location = new System.Drawing.Point(11, 69);
            this.btnNuevoAlumno.Name = "btnNuevoAlumno";
            this.btnNuevoAlumno.Size = new System.Drawing.Size(83, 23);
            this.btnNuevoAlumno.TabIndex = 0;
            this.btnNuevoAlumno.Text = "Nuevo";
            this.btnNuevoAlumno.UseVisualStyleBackColor = true;
            this.btnNuevoAlumno.Click += new System.EventHandler(this.btnNuevoAlumno_Click);
            // 
            // grbNavegacionAlumnos
            // 
            this.grbNavegacionAlumnos.Controls.Add(this.lblRegistroAlumno);
            this.grbNavegacionAlumnos.Controls.Add(this.btnUltimoAlumno);
            this.grbNavegacionAlumnos.Controls.Add(this.btnAnteriorAlumno);
            this.grbNavegacionAlumnos.Controls.Add(this.btnSiguienteAlumno);
            this.grbNavegacionAlumnos.Controls.Add(this.btnPrimeroAlumno);
            this.grbNavegacionAlumnos.Location = new System.Drawing.Point(12, 247);
            this.grbNavegacionAlumnos.Name = "grbNavegacionAlumnos";
            this.grbNavegacionAlumnos.Size = new System.Drawing.Size(237, 100);
            this.grbNavegacionAlumnos.TabIndex = 9;
            this.grbNavegacionAlumnos.TabStop = false;
            this.grbNavegacionAlumnos.Text = "Navegación";
            // 
            // lblRegistroAlumno
            // 
            this.lblRegistroAlumno.AutoSize = true;
            this.lblRegistroAlumno.Location = new System.Drawing.Point(103, 74);
            this.lblRegistroAlumno.Name = "lblRegistroAlumno";
            this.lblRegistroAlumno.Size = new System.Drawing.Size(37, 13);
            this.lblRegistroAlumno.TabIndex = 4;
            this.lblRegistroAlumno.Text = "1 de 1";
            // 
            // btnUltimoAlumno
            // 
            this.btnUltimoAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoAlumno.Location = new System.Drawing.Point(190, 65);
            this.btnUltimoAlumno.Name = "btnUltimoAlumno";
            this.btnUltimoAlumno.Size = new System.Drawing.Size(41, 29);
            this.btnUltimoAlumno.TabIndex = 3;
            this.btnUltimoAlumno.Text = ">|";
            this.btnUltimoAlumno.UseVisualStyleBackColor = true;
            this.btnUltimoAlumno.Click += new System.EventHandler(this.btnUltimoAlumno_Click);
            // 
            // btnAnteriorAlumno
            // 
            this.btnAnteriorAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorAlumno.Location = new System.Drawing.Point(44, 65);
            this.btnAnteriorAlumno.Name = "btnAnteriorAlumno";
            this.btnAnteriorAlumno.Size = new System.Drawing.Size(41, 29);
            this.btnAnteriorAlumno.TabIndex = 2;
            this.btnAnteriorAlumno.Text = "<";
            this.btnAnteriorAlumno.UseVisualStyleBackColor = true;
            this.btnAnteriorAlumno.Click += new System.EventHandler(this.btnAnteriorAlumno_Click);
            // 
            // btnSiguienteAlumno
            // 
            this.btnSiguienteAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteAlumno.Location = new System.Drawing.Point(156, 65);
            this.btnSiguienteAlumno.Name = "btnSiguienteAlumno";
            this.btnSiguienteAlumno.Size = new System.Drawing.Size(41, 29);
            this.btnSiguienteAlumno.TabIndex = 1;
            this.btnSiguienteAlumno.Text = ">";
            this.btnSiguienteAlumno.UseVisualStyleBackColor = true;
            this.btnSiguienteAlumno.Click += new System.EventHandler(this.btnSiguienteAlumno_Click);
            // 
            // btnPrimeroAlumno
            // 
            this.btnPrimeroAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroAlumno.Location = new System.Drawing.Point(6, 65);
            this.btnPrimeroAlumno.Name = "btnPrimeroAlumno";
            this.btnPrimeroAlumno.Size = new System.Drawing.Size(41, 29);
            this.btnPrimeroAlumno.TabIndex = 0;
            this.btnPrimeroAlumno.Text = "|<";
            this.btnPrimeroAlumno.UseVisualStyleBackColor = true;
            this.btnPrimeroAlumno.Click += new System.EventHandler(this.btnPrimeroAlumno_Click);
            // 
            // grbDatosAlumno
            // 
            this.grbDatosAlumno.Controls.Add(this.txtTelefonoAlumno);
            this.grbDatosAlumno.Controls.Add(this.label5);
            this.grbDatosAlumno.Controls.Add(this.txtDireccionAlumnos);
            this.grbDatosAlumno.Controls.Add(this.txtNombreAlumno);
            this.grbDatosAlumno.Controls.Add(this.txtCodigoAlumno);
            this.grbDatosAlumno.Controls.Add(this.label4);
            this.grbDatosAlumno.Controls.Add(this.label3);
            this.grbDatosAlumno.Controls.Add(this.label1);
            this.grbDatosAlumno.Location = new System.Drawing.Point(12, 24);
            this.grbDatosAlumno.Name = "grbDatosAlumno";
            this.grbDatosAlumno.Size = new System.Drawing.Size(549, 199);
            this.grbDatosAlumno.TabIndex = 8;
            this.grbDatosAlumno.TabStop = false;
            this.grbDatosAlumno.Text = "Datos Alumno";
            // 
            // txtTelefonoAlumno
            // 
            this.txtTelefonoAlumno.Location = new System.Drawing.Point(77, 164);
            this.txtTelefonoAlumno.Name = "txtTelefonoAlumno";
            this.txtTelefonoAlumno.ReadOnly = true;
            this.txtTelefonoAlumno.Size = new System.Drawing.Size(100, 20);
            this.txtTelefonoAlumno.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Teléfono:";
            // 
            // txtDireccionAlumnos
            // 
            this.txtDireccionAlumnos.Location = new System.Drawing.Point(77, 122);
            this.txtDireccionAlumnos.Name = "txtDireccionAlumnos";
            this.txtDireccionAlumnos.ReadOnly = true;
            this.txtDireccionAlumnos.Size = new System.Drawing.Size(271, 20);
            this.txtDireccionAlumnos.TabIndex = 5;
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Location = new System.Drawing.Point(77, 80);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.ReadOnly = true;
            this.txtNombreAlumno.Size = new System.Drawing.Size(271, 20);
            this.txtNombreAlumno.TabIndex = 4;
            // 
            // txtCodigoAlumno
            // 
            this.txtCodigoAlumno.Location = new System.Drawing.Point(77, 36);
            this.txtCodigoAlumno.Name = "txtCodigoAlumno";
            this.txtCodigoAlumno.ReadOnly = true;
            this.txtCodigoAlumno.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoAlumno.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Dirección:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // grdDatosAlumno
            // 
            this.grdDatosAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosAlumno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAlumno,
            this.codigo,
            this.nombre,
            this.direccion,
            this.telefono});
            this.grdDatosAlumno.Location = new System.Drawing.Point(582, 85);
            this.grdDatosAlumno.Name = "grdDatosAlumno";
            this.grdDatosAlumno.Size = new System.Drawing.Size(423, 262);
            this.grdDatosAlumno.TabIndex = 7;
            this.grdDatosAlumno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatosAlumno_CellClick);
            // 
            // idAlumno
            // 
            this.idAlumno.DataPropertyName = "idAlumno";
            this.idAlumno.HeaderText = "ID";
            this.idAlumno.Name = "idAlumno";
            this.idAlumno.ReadOnly = true;
            this.idAlumno.Visible = false;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "CODIGO";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
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
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "TELEFONO";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // Alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 371);
            this.Controls.Add(this.txtBuscarAlumnos);
            this.Controls.Add(this.cboBuscarAlumnos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbrEdicionAlumnos);
            this.Controls.Add(this.grbNavegacionAlumnos);
            this.Controls.Add(this.grbDatosAlumno);
            this.Controls.Add(this.grdDatosAlumno);
            this.Name = "Alumnos";
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.Alumnos_Load);
            this.gbrEdicionAlumnos.ResumeLayout(false);
            this.grbNavegacionAlumnos.ResumeLayout(false);
            this.grbNavegacionAlumnos.PerformLayout();
            this.grbDatosAlumno.ResumeLayout(false);
            this.grbDatosAlumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscarAlumnos;
        private System.Windows.Forms.ComboBox cboBuscarAlumnos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbrEdicionAlumnos;
        private System.Windows.Forms.Button btnEliminarAlumno;
        private System.Windows.Forms.Button btnModificarAlumno;
        private System.Windows.Forms.Button btnNuevoAlumno;
        private System.Windows.Forms.GroupBox grbNavegacionAlumnos;
        private System.Windows.Forms.Label lblRegistroAlumno;
        private System.Windows.Forms.Button btnUltimoAlumno;
        private System.Windows.Forms.Button btnAnteriorAlumno;
        private System.Windows.Forms.Button btnSiguienteAlumno;
        private System.Windows.Forms.Button btnPrimeroAlumno;
        private System.Windows.Forms.GroupBox grbDatosAlumno;
        private System.Windows.Forms.TextBox txtDireccionAlumnos;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.TextBox txtCodigoAlumno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdDatosAlumno;
        private System.Windows.Forms.TextBox txtTelefonoAlumno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
    }
}