
namespace ejercicios
{
    partial class Materias
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
            this.grdDatosMateria = new System.Windows.Forms.DataGridView();
            this.idMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbDatosMateria = new System.Windows.Forms.GroupBox();
            this.txtUvMateria = new System.Windows.Forms.TextBox();
            this.txtNombreMateria = new System.Windows.Forms.TextBox();
            this.txtCodigoMateria = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbNavegacionMaterias = new System.Windows.Forms.GroupBox();
            this.lblRegistroMateria = new System.Windows.Forms.Label();
            this.btnUltimoMateria = new System.Windows.Forms.Button();
            this.btnAnteriorMateria = new System.Windows.Forms.Button();
            this.btnSiguienteMateria = new System.Windows.Forms.Button();
            this.btnPrimeroMateria = new System.Windows.Forms.Button();
            this.gbrEdicionMaterias = new System.Windows.Forms.GroupBox();
            this.btnEliminarMateria = new System.Windows.Forms.Button();
            this.btnModificarMateria = new System.Windows.Forms.Button();
            this.btnNuevoMateria = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboBuscarMaterias = new System.Windows.Forms.ComboBox();
            this.txtBuscarMaterias = new System.Windows.Forms.TextBox();
            this.erpMaterias = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosMateria)).BeginInit();
            this.grbDatosMateria.SuspendLayout();
            this.grbNavegacionMaterias.SuspendLayout();
            this.gbrEdicionMaterias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDatosMateria
            // 
            this.grdDatosMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosMateria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMateria,
            this.codigo,
            this.nombre,
            this.uv});
            this.grdDatosMateria.Location = new System.Drawing.Point(582, 97);
            this.grdDatosMateria.Name = "grdDatosMateria";
            this.grdDatosMateria.Size = new System.Drawing.Size(342, 262);
            this.grdDatosMateria.TabIndex = 0;
            this.grdDatosMateria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatosMateria_CellClick);
            // 
            // idMateria
            // 
            this.idMateria.DataPropertyName = "idMateria";
            this.idMateria.HeaderText = "ID";
            this.idMateria.Name = "idMateria";
            this.idMateria.ReadOnly = true;
            this.idMateria.Visible = false;
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
            this.nombre.DataPropertyName = "materia";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // uv
            // 
            this.uv.DataPropertyName = "uv";
            this.uv.HeaderText = "UV";
            this.uv.Name = "uv";
            this.uv.ReadOnly = true;
            // 
            // grbDatosMateria
            // 
            this.grbDatosMateria.Controls.Add(this.txtUvMateria);
            this.grbDatosMateria.Controls.Add(this.txtNombreMateria);
            this.grbDatosMateria.Controls.Add(this.txtCodigoMateria);
            this.grbDatosMateria.Controls.Add(this.label4);
            this.grbDatosMateria.Controls.Add(this.label3);
            this.grbDatosMateria.Controls.Add(this.label1);
            this.grbDatosMateria.Location = new System.Drawing.Point(12, 36);
            this.grbDatosMateria.Name = "grbDatosMateria";
            this.grbDatosMateria.Size = new System.Drawing.Size(549, 199);
            this.grbDatosMateria.TabIndex = 1;
            this.grbDatosMateria.TabStop = false;
            this.grbDatosMateria.Text = "Datos Materia";
            // 
            // txtUvMateria
            // 
            this.txtUvMateria.Location = new System.Drawing.Point(77, 122);
            this.txtUvMateria.Name = "txtUvMateria";
            this.txtUvMateria.ReadOnly = true;
            this.txtUvMateria.Size = new System.Drawing.Size(63, 20);
            this.txtUvMateria.TabIndex = 5;
            // 
            // txtNombreMateria
            // 
            this.txtNombreMateria.Location = new System.Drawing.Point(77, 80);
            this.txtNombreMateria.Name = "txtNombreMateria";
            this.txtNombreMateria.ReadOnly = true;
            this.txtNombreMateria.Size = new System.Drawing.Size(271, 20);
            this.txtNombreMateria.TabIndex = 4;
            // 
            // txtCodigoMateria
            // 
            this.txtCodigoMateria.Location = new System.Drawing.Point(77, 36);
            this.txtCodigoMateria.Name = "txtCodigoMateria";
            this.txtCodigoMateria.ReadOnly = true;
            this.txtCodigoMateria.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoMateria.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "UV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "MATERIA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CÓDIGO:";
            // 
            // grbNavegacionMaterias
            // 
            this.grbNavegacionMaterias.Controls.Add(this.lblRegistroMateria);
            this.grbNavegacionMaterias.Controls.Add(this.btnUltimoMateria);
            this.grbNavegacionMaterias.Controls.Add(this.btnAnteriorMateria);
            this.grbNavegacionMaterias.Controls.Add(this.btnSiguienteMateria);
            this.grbNavegacionMaterias.Controls.Add(this.btnPrimeroMateria);
            this.grbNavegacionMaterias.Location = new System.Drawing.Point(12, 259);
            this.grbNavegacionMaterias.Name = "grbNavegacionMaterias";
            this.grbNavegacionMaterias.Size = new System.Drawing.Size(237, 100);
            this.grbNavegacionMaterias.TabIndex = 2;
            this.grbNavegacionMaterias.TabStop = false;
            this.grbNavegacionMaterias.Text = "Navegación";
            // 
            // lblRegistroMateria
            // 
            this.lblRegistroMateria.AutoSize = true;
            this.lblRegistroMateria.Location = new System.Drawing.Point(103, 74);
            this.lblRegistroMateria.Name = "lblRegistroMateria";
            this.lblRegistroMateria.Size = new System.Drawing.Size(37, 13);
            this.lblRegistroMateria.TabIndex = 4;
            this.lblRegistroMateria.Text = "1 de 1";
            // 
            // btnUltimoMateria
            // 
            this.btnUltimoMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoMateria.Location = new System.Drawing.Point(190, 65);
            this.btnUltimoMateria.Name = "btnUltimoMateria";
            this.btnUltimoMateria.Size = new System.Drawing.Size(41, 29);
            this.btnUltimoMateria.TabIndex = 3;
            this.btnUltimoMateria.Text = ">|";
            this.btnUltimoMateria.UseVisualStyleBackColor = true;
            this.btnUltimoMateria.Click += new System.EventHandler(this.btnUltimoMateria_Click);
            // 
            // btnAnteriorMateria
            // 
            this.btnAnteriorMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorMateria.Location = new System.Drawing.Point(44, 65);
            this.btnAnteriorMateria.Name = "btnAnteriorMateria";
            this.btnAnteriorMateria.Size = new System.Drawing.Size(41, 29);
            this.btnAnteriorMateria.TabIndex = 2;
            this.btnAnteriorMateria.Text = "<";
            this.btnAnteriorMateria.UseVisualStyleBackColor = true;
            this.btnAnteriorMateria.Click += new System.EventHandler(this.btnAnteriorMateria_Click);
            // 
            // btnSiguienteMateria
            // 
            this.btnSiguienteMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteMateria.Location = new System.Drawing.Point(156, 65);
            this.btnSiguienteMateria.Name = "btnSiguienteMateria";
            this.btnSiguienteMateria.Size = new System.Drawing.Size(41, 29);
            this.btnSiguienteMateria.TabIndex = 1;
            this.btnSiguienteMateria.Text = ">";
            this.btnSiguienteMateria.UseVisualStyleBackColor = true;
            this.btnSiguienteMateria.Click += new System.EventHandler(this.btnSiguienteMateria_Click);
            // 
            // btnPrimeroMateria
            // 
            this.btnPrimeroMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroMateria.Location = new System.Drawing.Point(6, 65);
            this.btnPrimeroMateria.Name = "btnPrimeroMateria";
            this.btnPrimeroMateria.Size = new System.Drawing.Size(41, 29);
            this.btnPrimeroMateria.TabIndex = 0;
            this.btnPrimeroMateria.Text = "|<";
            this.btnPrimeroMateria.UseVisualStyleBackColor = true;
            this.btnPrimeroMateria.Click += new System.EventHandler(this.btnPrimeroMateria_Click);
            // 
            // gbrEdicionMaterias
            // 
            this.gbrEdicionMaterias.Controls.Add(this.btnEliminarMateria);
            this.gbrEdicionMaterias.Controls.Add(this.btnModificarMateria);
            this.gbrEdicionMaterias.Controls.Add(this.btnNuevoMateria);
            this.gbrEdicionMaterias.Location = new System.Drawing.Point(266, 259);
            this.gbrEdicionMaterias.Name = "gbrEdicionMaterias";
            this.gbrEdicionMaterias.Size = new System.Drawing.Size(295, 100);
            this.gbrEdicionMaterias.TabIndex = 3;
            this.gbrEdicionMaterias.TabStop = false;
            this.gbrEdicionMaterias.Text = "Edición";
            // 
            // btnEliminarMateria
            // 
            this.btnEliminarMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMateria.ForeColor = System.Drawing.Color.Red;
            this.btnEliminarMateria.Location = new System.Drawing.Point(215, 69);
            this.btnEliminarMateria.Name = "btnEliminarMateria";
            this.btnEliminarMateria.Size = new System.Drawing.Size(74, 23);
            this.btnEliminarMateria.TabIndex = 2;
            this.btnEliminarMateria.Text = "Eliminar";
            this.btnEliminarMateria.UseVisualStyleBackColor = true;
            this.btnEliminarMateria.Click += new System.EventHandler(this.btnEliminarMateria_Click);
            // 
            // btnModificarMateria
            // 
            this.btnModificarMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMateria.Location = new System.Drawing.Point(105, 69);
            this.btnModificarMateria.Name = "btnModificarMateria";
            this.btnModificarMateria.Size = new System.Drawing.Size(84, 23);
            this.btnModificarMateria.TabIndex = 1;
            this.btnModificarMateria.Text = "Modificar";
            this.btnModificarMateria.UseVisualStyleBackColor = true;
            this.btnModificarMateria.Click += new System.EventHandler(this.btnModificarMateria_Click);
            // 
            // btnNuevoMateria
            // 
            this.btnNuevoMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoMateria.Location = new System.Drawing.Point(11, 69);
            this.btnNuevoMateria.Name = "btnNuevoMateria";
            this.btnNuevoMateria.Size = new System.Drawing.Size(70, 23);
            this.btnNuevoMateria.TabIndex = 0;
            this.btnNuevoMateria.Text = "Nuevo";
            this.btnNuevoMateria.UseVisualStyleBackColor = true;
            this.btnNuevoMateria.Click += new System.EventHandler(this.btnNuevoMateria_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(567, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Buscar:";
            // 
            // cboBuscarMaterias
            // 
            this.cboBuscarMaterias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscarMaterias.FormattingEnabled = true;
            this.cboBuscarMaterias.Items.AddRange(new object[] {
            "Nombre",
            "Código"});
            this.cboBuscarMaterias.Location = new System.Drawing.Point(628, 64);
            this.cboBuscarMaterias.Name = "cboBuscarMaterias";
            this.cboBuscarMaterias.Size = new System.Drawing.Size(121, 21);
            this.cboBuscarMaterias.TabIndex = 5;
            // 
            // txtBuscarMaterias
            // 
            this.txtBuscarMaterias.Location = new System.Drawing.Point(755, 64);
            this.txtBuscarMaterias.Name = "txtBuscarMaterias";
            this.txtBuscarMaterias.Size = new System.Drawing.Size(182, 20);
            this.txtBuscarMaterias.TabIndex = 6;
            this.txtBuscarMaterias.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarMaterias_KeyUp);
            // 
            // erpMaterias
            // 
            this.erpMaterias.ContainerControl = this;
            // 
            // Materias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 371);
            this.Controls.Add(this.txtBuscarMaterias);
            this.Controls.Add(this.cboBuscarMaterias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbrEdicionMaterias);
            this.Controls.Add(this.grbNavegacionMaterias);
            this.Controls.Add(this.grbDatosMateria);
            this.Controls.Add(this.grdDatosMateria);
            this.Name = "Materias";
            this.Text = "Materias";
            this.Load += new System.EventHandler(this.Materias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosMateria)).EndInit();
            this.grbDatosMateria.ResumeLayout(false);
            this.grbDatosMateria.PerformLayout();
            this.grbNavegacionMaterias.ResumeLayout(false);
            this.grbNavegacionMaterias.PerformLayout();
            this.gbrEdicionMaterias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erpMaterias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdDatosMateria;
        private System.Windows.Forms.GroupBox grbDatosMateria;
        private System.Windows.Forms.GroupBox grbNavegacionMaterias;
        private System.Windows.Forms.GroupBox gbrEdicionMaterias;
        private System.Windows.Forms.Button btnUltimoMateria;
        private System.Windows.Forms.Button btnAnteriorMateria;
        private System.Windows.Forms.Button btnSiguienteMateria;
        private System.Windows.Forms.Button btnPrimeroMateria;
        private System.Windows.Forms.Label lblRegistroMateria;
        private System.Windows.Forms.Button btnEliminarMateria;
        private System.Windows.Forms.Button btnModificarMateria;
        private System.Windows.Forms.Button btnNuevoMateria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboBuscarMaterias;
        private System.Windows.Forms.TextBox txtBuscarMaterias;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn uv;
        private System.Windows.Forms.TextBox txtUvMateria;
        private System.Windows.Forms.TextBox txtNombreMateria;
        private System.Windows.Forms.TextBox txtCodigoMateria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider erpMaterias;
    }
}