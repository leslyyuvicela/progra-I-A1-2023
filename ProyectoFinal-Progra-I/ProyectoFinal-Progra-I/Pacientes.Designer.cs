
namespace ProyectoFinal_Progra_I
{
    partial class Pacientes
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
            this.cboOpcionBuscarPaciente = new System.Windows.Forms.ComboBox();
            this.txtBuscarPaciente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdDatosPacientes = new System.Windows.Forms.DataGridView();
            this.idPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbDatosPaciente = new System.Windows.Forms.GroupBox();
            this.txtDescripcionPaciente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEstaturaPaciente = new System.Windows.Forms.TextBox();
            this.txtPesoPaciente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEspeciePaciente = new System.Windows.Forms.TextBox();
            this.txtRazaPaciente = new System.Windows.Forms.TextBox();
            this.txtColorPaciente = new System.Windows.Forms.TextBox();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.dtpNacimietoPaciente = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpRegistroPaciente = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grbNavegacionPaciente = new System.Windows.Forms.GroupBox();
            this.btnPrimeroPaciente = new System.Windows.Forms.Button();
            this.btnAnteriorPaciente = new System.Windows.Forms.Button();
            this.btnUltimoPaciente = new System.Windows.Forms.Button();
            this.btnSiguientePaciente = new System.Windows.Forms.Button();
            this.lblPosicionPaciente = new System.Windows.Forms.Label();
            this.grbEdicionPaciente = new System.Windows.Forms.GroupBox();
            this.btnNuevoPaciente = new System.Windows.Forms.Button();
            this.btnModificarPaciente = new System.Windows.Forms.Button();
            this.btnEliminarPaciente = new System.Windows.Forms.Button();
            this.erpPacientes = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosPacientes)).BeginInit();
            this.grbDatosPaciente.SuspendLayout();
            this.grbNavegacionPaciente.SuspendLayout();
            this.grbEdicionPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // cboOpcionBuscarPaciente
            // 
            this.cboOpcionBuscarPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOpcionBuscarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOpcionBuscarPaciente.FormattingEnabled = true;
            this.cboOpcionBuscarPaciente.Items.AddRange(new object[] {
            "Nombre",
            "Especie",
            "Raza",
            "Color",
            "Estatura",
            "Peso",
            "Descripcion"});
            this.cboOpcionBuscarPaciente.Location = new System.Drawing.Point(94, 56);
            this.cboOpcionBuscarPaciente.Name = "cboOpcionBuscarPaciente";
            this.cboOpcionBuscarPaciente.Size = new System.Drawing.Size(154, 28);
            this.cboOpcionBuscarPaciente.TabIndex = 19;
            // 
            // txtBuscarPaciente
            // 
            this.txtBuscarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPaciente.Location = new System.Drawing.Point(263, 56);
            this.txtBuscarPaciente.Name = "txtBuscarPaciente";
            this.txtBuscarPaciente.Size = new System.Drawing.Size(249, 26);
            this.txtBuscarPaciente.TabIndex = 18;
            this.txtBuscarPaciente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarPaciente_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Buscar";
            // 
            // grdDatosPacientes
            // 
            this.grdDatosPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPaciente,
            this.nombre,
            this.especie,
            this.raza,
            this.color,
            this.estatura,
            this.peso,
            this.fechaRegistro,
            this.fechaNacimiento,
            this.descripcion});
            this.grdDatosPacientes.Location = new System.Drawing.Point(22, 96);
            this.grdDatosPacientes.Name = "grdDatosPacientes";
            this.grdDatosPacientes.Size = new System.Drawing.Size(490, 540);
            this.grdDatosPacientes.TabIndex = 16;
            this.grdDatosPacientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatosPacientes_CellClick);
            // 
            // idPaciente
            // 
            this.idPaciente.DataPropertyName = "idPaciente";
            this.idPaciente.HeaderText = "ID";
            this.idPaciente.Name = "idPaciente";
            this.idPaciente.ReadOnly = true;
            this.idPaciente.Visible = false;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // especie
            // 
            this.especie.DataPropertyName = "especie";
            this.especie.HeaderText = "Especie";
            this.especie.Name = "especie";
            this.especie.ReadOnly = true;
            // 
            // raza
            // 
            this.raza.DataPropertyName = "raza";
            this.raza.HeaderText = "Raza";
            this.raza.Name = "raza";
            this.raza.ReadOnly = true;
            // 
            // color
            // 
            this.color.DataPropertyName = "color";
            this.color.HeaderText = "Color";
            this.color.Name = "color";
            this.color.ReadOnly = true;
            // 
            // estatura
            // 
            this.estatura.DataPropertyName = "estatura";
            this.estatura.HeaderText = "Estatura (cm)";
            this.estatura.Name = "estatura";
            this.estatura.ReadOnly = true;
            this.estatura.Width = 50;
            // 
            // peso
            // 
            this.peso.DataPropertyName = "peso";
            this.peso.HeaderText = "Peso (kg)";
            this.peso.Name = "peso";
            this.peso.ReadOnly = true;
            this.peso.Width = 50;
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
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripción adicional";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 500;
            // 
            // grbDatosPaciente
            // 
            this.grbDatosPaciente.Controls.Add(this.txtDescripcionPaciente);
            this.grbDatosPaciente.Controls.Add(this.label10);
            this.grbDatosPaciente.Controls.Add(this.txtEstaturaPaciente);
            this.grbDatosPaciente.Controls.Add(this.txtPesoPaciente);
            this.grbDatosPaciente.Controls.Add(this.label9);
            this.grbDatosPaciente.Controls.Add(this.label8);
            this.grbDatosPaciente.Controls.Add(this.txtEspeciePaciente);
            this.grbDatosPaciente.Controls.Add(this.txtRazaPaciente);
            this.grbDatosPaciente.Controls.Add(this.txtColorPaciente);
            this.grbDatosPaciente.Controls.Add(this.txtNombrePaciente);
            this.grbDatosPaciente.Controls.Add(this.dtpNacimietoPaciente);
            this.grbDatosPaciente.Controls.Add(this.label7);
            this.grbDatosPaciente.Controls.Add(this.label6);
            this.grbDatosPaciente.Controls.Add(this.dtpRegistroPaciente);
            this.grbDatosPaciente.Controls.Add(this.label5);
            this.grbDatosPaciente.Controls.Add(this.label2);
            this.grbDatosPaciente.Controls.Add(this.label4);
            this.grbDatosPaciente.Controls.Add(this.label3);
            this.grbDatosPaciente.Location = new System.Drawing.Point(529, 56);
            this.grbDatosPaciente.Name = "grbDatosPaciente";
            this.grbDatosPaciente.Size = new System.Drawing.Size(657, 472);
            this.grbDatosPaciente.TabIndex = 27;
            this.grbDatosPaciente.TabStop = false;
            this.grbDatosPaciente.Text = "Datos del paciente";
            // 
            // txtDescripcionPaciente
            // 
            this.txtDescripcionPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionPaciente.Location = new System.Drawing.Point(195, 440);
            this.txtDescripcionPaciente.Name = "txtDescripcionPaciente";
            this.txtDescripcionPaciente.ReadOnly = true;
            this.txtDescripcionPaciente.Size = new System.Drawing.Size(430, 26);
            this.txtDescripcionPaciente.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 443);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(179, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Descripción adicional";
            // 
            // txtEstaturaPaciente
            // 
            this.txtEstaturaPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstaturaPaciente.Location = new System.Drawing.Point(195, 259);
            this.txtEstaturaPaciente.Name = "txtEstaturaPaciente";
            this.txtEstaturaPaciente.ReadOnly = true;
            this.txtEstaturaPaciente.Size = new System.Drawing.Size(430, 26);
            this.txtEstaturaPaciente.TabIndex = 17;
            this.txtEstaturaPaciente.TextChanged += new System.EventHandler(this.txtEstaturaPaciente_TextChanged);
            // 
            // txtPesoPaciente
            // 
            this.txtPesoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoPaciente.Location = new System.Drawing.Point(195, 306);
            this.txtPesoPaciente.Name = "txtPesoPaciente";
            this.txtPesoPaciente.ReadOnly = true;
            this.txtPesoPaciente.Size = new System.Drawing.Size(430, 26);
            this.txtPesoPaciente.TabIndex = 16;
            this.txtPesoPaciente.TextChanged += new System.EventHandler(this.txtPesoPaciente_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(131, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Peso";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(104, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Estatura";
            // 
            // txtEspeciePaciente
            // 
            this.txtEspeciePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspeciePaciente.Location = new System.Drawing.Point(195, 120);
            this.txtEspeciePaciente.Name = "txtEspeciePaciente";
            this.txtEspeciePaciente.ReadOnly = true;
            this.txtEspeciePaciente.Size = new System.Drawing.Size(430, 26);
            this.txtEspeciePaciente.TabIndex = 11;
            // 
            // txtRazaPaciente
            // 
            this.txtRazaPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazaPaciente.Location = new System.Drawing.Point(195, 167);
            this.txtRazaPaciente.Name = "txtRazaPaciente";
            this.txtRazaPaciente.ReadOnly = true;
            this.txtRazaPaciente.Size = new System.Drawing.Size(430, 26);
            this.txtRazaPaciente.TabIndex = 10;
            // 
            // txtColorPaciente
            // 
            this.txtColorPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColorPaciente.Location = new System.Drawing.Point(195, 213);
            this.txtColorPaciente.Name = "txtColorPaciente";
            this.txtColorPaciente.ReadOnly = true;
            this.txtColorPaciente.Size = new System.Drawing.Size(430, 26);
            this.txtColorPaciente.TabIndex = 9;
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePaciente.Location = new System.Drawing.Point(195, 73);
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.ReadOnly = true;
            this.txtNombrePaciente.Size = new System.Drawing.Size(430, 26);
            this.txtNombrePaciente.TabIndex = 8;
            // 
            // dtpNacimietoPaciente
            // 
            this.dtpNacimietoPaciente.Enabled = false;
            this.dtpNacimietoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNacimietoPaciente.Location = new System.Drawing.Point(195, 351);
            this.dtpNacimietoPaciente.Name = "dtpNacimietoPaciente";
            this.dtpNacimietoPaciente.Size = new System.Drawing.Size(336, 26);
            this.dtpNacimietoPaciente.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Fecha de registro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fecha de nacimiento";
            // 
            // dtpRegistroPaciente
            // 
            this.dtpRegistroPaciente.Enabled = false;
            this.dtpRegistroPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRegistroPaciente.Location = new System.Drawing.Point(195, 394);
            this.dtpRegistroPaciente.Name = "dtpRegistroPaciente";
            this.dtpRegistroPaciente.Size = new System.Drawing.Size(336, 26);
            this.dtpRegistroPaciente.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(131, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Especie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Raza";
            // 
            // grbNavegacionPaciente
            // 
            this.grbNavegacionPaciente.BackColor = System.Drawing.SystemColors.Control;
            this.grbNavegacionPaciente.Controls.Add(this.btnPrimeroPaciente);
            this.grbNavegacionPaciente.Controls.Add(this.btnAnteriorPaciente);
            this.grbNavegacionPaciente.Controls.Add(this.btnUltimoPaciente);
            this.grbNavegacionPaciente.Controls.Add(this.btnSiguientePaciente);
            this.grbNavegacionPaciente.Controls.Add(this.lblPosicionPaciente);
            this.grbNavegacionPaciente.Location = new System.Drawing.Point(906, 554);
            this.grbNavegacionPaciente.Name = "grbNavegacionPaciente";
            this.grbNavegacionPaciente.Size = new System.Drawing.Size(280, 82);
            this.grbNavegacionPaciente.TabIndex = 29;
            this.grbNavegacionPaciente.TabStop = false;
            this.grbNavegacionPaciente.Text = "Navegación";
            // 
            // btnPrimeroPaciente
            // 
            this.btnPrimeroPaciente.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPrimeroPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroPaciente.Location = new System.Drawing.Point(14, 31);
            this.btnPrimeroPaciente.Name = "btnPrimeroPaciente";
            this.btnPrimeroPaciente.Size = new System.Drawing.Size(37, 30);
            this.btnPrimeroPaciente.TabIndex = 19;
            this.btnPrimeroPaciente.Text = "|<";
            this.btnPrimeroPaciente.UseVisualStyleBackColor = false;
            this.btnPrimeroPaciente.Click += new System.EventHandler(this.btnPrimeroPaciente_Click);
            // 
            // btnAnteriorPaciente
            // 
            this.btnAnteriorPaciente.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAnteriorPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorPaciente.Location = new System.Drawing.Point(57, 31);
            this.btnAnteriorPaciente.Name = "btnAnteriorPaciente";
            this.btnAnteriorPaciente.Size = new System.Drawing.Size(37, 30);
            this.btnAnteriorPaciente.TabIndex = 22;
            this.btnAnteriorPaciente.Text = "<";
            this.btnAnteriorPaciente.UseVisualStyleBackColor = false;
            this.btnAnteriorPaciente.Click += new System.EventHandler(this.btnAnteriorPaciente_Click);
            // 
            // btnUltimoPaciente
            // 
            this.btnUltimoPaciente.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnUltimoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoPaciente.Location = new System.Drawing.Point(231, 31);
            this.btnUltimoPaciente.Name = "btnUltimoPaciente";
            this.btnUltimoPaciente.Size = new System.Drawing.Size(37, 30);
            this.btnUltimoPaciente.TabIndex = 20;
            this.btnUltimoPaciente.Text = ">|";
            this.btnUltimoPaciente.UseVisualStyleBackColor = false;
            this.btnUltimoPaciente.Click += new System.EventHandler(this.btnUltimoPaciente_Click);
            // 
            // btnSiguientePaciente
            // 
            this.btnSiguientePaciente.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSiguientePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguientePaciente.Location = new System.Drawing.Point(188, 31);
            this.btnSiguientePaciente.Name = "btnSiguientePaciente";
            this.btnSiguientePaciente.Size = new System.Drawing.Size(37, 30);
            this.btnSiguientePaciente.TabIndex = 21;
            this.btnSiguientePaciente.Text = ">";
            this.btnSiguientePaciente.UseVisualStyleBackColor = false;
            this.btnSiguientePaciente.Click += new System.EventHandler(this.btnSiguientePaciente_Click);
            // 
            // lblPosicionPaciente
            // 
            this.lblPosicionPaciente.AutoSize = true;
            this.lblPosicionPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicionPaciente.Location = new System.Drawing.Point(107, 36);
            this.lblPosicionPaciente.Name = "lblPosicionPaciente";
            this.lblPosicionPaciente.Size = new System.Drawing.Size(57, 20);
            this.lblPosicionPaciente.TabIndex = 23;
            this.lblPosicionPaciente.Text = "x de n";
            // 
            // grbEdicionPaciente
            // 
            this.grbEdicionPaciente.Controls.Add(this.btnNuevoPaciente);
            this.grbEdicionPaciente.Controls.Add(this.btnModificarPaciente);
            this.grbEdicionPaciente.Controls.Add(this.btnEliminarPaciente);
            this.grbEdicionPaciente.Location = new System.Drawing.Point(529, 554);
            this.grbEdicionPaciente.Name = "grbEdicionPaciente";
            this.grbEdicionPaciente.Size = new System.Drawing.Size(320, 82);
            this.grbEdicionPaciente.TabIndex = 28;
            this.grbEdicionPaciente.TabStop = false;
            this.grbEdicionPaciente.Text = "Edición";
            // 
            // btnNuevoPaciente
            // 
            this.btnNuevoPaciente.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnNuevoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPaciente.Location = new System.Drawing.Point(17, 19);
            this.btnNuevoPaciente.Name = "btnNuevoPaciente";
            this.btnNuevoPaciente.Size = new System.Drawing.Size(90, 55);
            this.btnNuevoPaciente.TabIndex = 18;
            this.btnNuevoPaciente.Text = "Nuevo paciente";
            this.btnNuevoPaciente.UseVisualStyleBackColor = false;
            this.btnNuevoPaciente.Click += new System.EventHandler(this.btnNuevoPaciente_Click);
            // 
            // btnModificarPaciente
            // 
            this.btnModificarPaciente.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnModificarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarPaciente.Location = new System.Drawing.Point(112, 19);
            this.btnModificarPaciente.Name = "btnModificarPaciente";
            this.btnModificarPaciente.Size = new System.Drawing.Size(90, 55);
            this.btnModificarPaciente.TabIndex = 16;
            this.btnModificarPaciente.Text = "Modificar datos";
            this.btnModificarPaciente.UseVisualStyleBackColor = false;
            this.btnModificarPaciente.Click += new System.EventHandler(this.btnModificarPaciente_Click);
            // 
            // btnEliminarPaciente
            // 
            this.btnEliminarPaciente.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEliminarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPaciente.Location = new System.Drawing.Point(208, 19);
            this.btnEliminarPaciente.Name = "btnEliminarPaciente";
            this.btnEliminarPaciente.Size = new System.Drawing.Size(90, 55);
            this.btnEliminarPaciente.TabIndex = 17;
            this.btnEliminarPaciente.Text = "Eliminar paciente";
            this.btnEliminarPaciente.UseVisualStyleBackColor = false;
            this.btnEliminarPaciente.Click += new System.EventHandler(this.btnEliminarPaciente_Click);
            // 
            // erpPacientes
            // 
            this.erpPacientes.ContainerControl = this;
            // 
            // Pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.ControlBox = false;
            this.Controls.Add(this.grbNavegacionPaciente);
            this.Controls.Add(this.grbEdicionPaciente);
            this.Controls.Add(this.grbDatosPaciente);
            this.Controls.Add(this.cboOpcionBuscarPaciente);
            this.Controls.Add(this.txtBuscarPaciente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdDatosPacientes);
            this.Name = "Pacientes";
            this.Text = "Pacientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Pacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosPacientes)).EndInit();
            this.grbDatosPaciente.ResumeLayout(false);
            this.grbDatosPaciente.PerformLayout();
            this.grbNavegacionPaciente.ResumeLayout(false);
            this.grbNavegacionPaciente.PerformLayout();
            this.grbEdicionPaciente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erpPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboOpcionBuscarPaciente;
        private System.Windows.Forms.TextBox txtBuscarPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdDatosPacientes;
        private System.Windows.Forms.GroupBox grbDatosPaciente;
        private System.Windows.Forms.TextBox txtEspeciePaciente;
        private System.Windows.Forms.TextBox txtRazaPaciente;
        private System.Windows.Forms.TextBox txtColorPaciente;
        private System.Windows.Forms.TextBox txtNombrePaciente;
        private System.Windows.Forms.DateTimePicker dtpNacimietoPaciente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpRegistroPaciente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grbNavegacionPaciente;
        private System.Windows.Forms.Button btnPrimeroPaciente;
        private System.Windows.Forms.Button btnAnteriorPaciente;
        private System.Windows.Forms.Button btnUltimoPaciente;
        private System.Windows.Forms.Button btnSiguientePaciente;
        private System.Windows.Forms.Label lblPosicionPaciente;
        private System.Windows.Forms.GroupBox grbEdicionPaciente;
        private System.Windows.Forms.Button btnNuevoPaciente;
        private System.Windows.Forms.Button btnModificarPaciente;
        private System.Windows.Forms.Button btnEliminarPaciente;
        private System.Windows.Forms.TextBox txtDescripcionPaciente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEstaturaPaciente;
        private System.Windows.Forms.TextBox txtPesoPaciente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider erpPacientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn especie;
        private System.Windows.Forms.DataGridViewTextBoxColumn raza;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
    }
}