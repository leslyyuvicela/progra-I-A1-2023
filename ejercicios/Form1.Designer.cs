
namespace ejercicios
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDeConversores = new System.Windows.Forms.Label();
            this.cboDeConversores = new System.Windows.Forms.ComboBox();
            this.cboAConversores = new System.Windows.Forms.ComboBox();
            this.lblAConversores = new System.Windows.Forms.Label();
            this.btnConvertirConversores = new System.Windows.Forms.Button();
            this.lblRespuestaConversores = new System.Windows.Forms.Label();
            this.lblCantidadConversores = new System.Windows.Forms.Label();
            this.txtCantidadConversores = new System.Windows.Forms.TextBox();
            this.cboTipoConversor = new System.Windows.Forms.ComboBox();
            this.lblTipoConversor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDeConversores
            // 
            this.lblDeConversores.AutoSize = true;
            this.lblDeConversores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeConversores.Location = new System.Drawing.Point(225, 150);
            this.lblDeConversores.Name = "lblDeConversores";
            this.lblDeConversores.Size = new System.Drawing.Size(39, 20);
            this.lblDeConversores.TabIndex = 0;
            this.lblDeConversores.Text = "DE:";
            // 
            // cboDeConversores
            // 
            this.cboDeConversores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeConversores.FormattingEnabled = true;
            this.cboDeConversores.Location = new System.Drawing.Point(280, 152);
            this.cboDeConversores.Name = "cboDeConversores";
            this.cboDeConversores.Size = new System.Drawing.Size(141, 21);
            this.cboDeConversores.TabIndex = 1;
            // 
            // cboAConversores
            // 
            this.cboAConversores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAConversores.FormattingEnabled = true;
            this.cboAConversores.Location = new System.Drawing.Point(280, 193);
            this.cboAConversores.Name = "cboAConversores";
            this.cboAConversores.Size = new System.Drawing.Size(141, 21);
            this.cboAConversores.TabIndex = 3;
            // 
            // lblAConversores
            // 
            this.lblAConversores.AutoSize = true;
            this.lblAConversores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAConversores.Location = new System.Drawing.Point(225, 194);
            this.lblAConversores.Name = "lblAConversores";
            this.lblAConversores.Size = new System.Drawing.Size(26, 20);
            this.lblAConversores.TabIndex = 2;
            this.lblAConversores.Text = "A:";
            // 
            // btnConvertirConversores
            // 
            this.btnConvertirConversores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertirConversores.Location = new System.Drawing.Point(229, 350);
            this.btnConvertirConversores.Name = "btnConvertirConversores";
            this.btnConvertirConversores.Size = new System.Drawing.Size(177, 33);
            this.btnConvertirConversores.TabIndex = 4;
            this.btnConvertirConversores.Text = "Convertir";
            this.btnConvertirConversores.UseVisualStyleBackColor = true;
            this.btnConvertirConversores.Click += new System.EventHandler(this.btnConvertirConversores_Click);
            // 
            // lblRespuestaConversores
            // 
            this.lblRespuestaConversores.AutoSize = true;
            this.lblRespuestaConversores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuestaConversores.Location = new System.Drawing.Point(225, 305);
            this.lblRespuestaConversores.Name = "lblRespuestaConversores";
            this.lblRespuestaConversores.Size = new System.Drawing.Size(116, 20);
            this.lblRespuestaConversores.TabIndex = 5;
            this.lblRespuestaConversores.Text = "Respuesta: ?";
            // 
            // lblCantidadConversores
            // 
            this.lblCantidadConversores.AutoSize = true;
            this.lblCantidadConversores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadConversores.Location = new System.Drawing.Point(225, 254);
            this.lblCantidadConversores.Name = "lblCantidadConversores";
            this.lblCantidadConversores.Size = new System.Drawing.Size(86, 20);
            this.lblCantidadConversores.TabIndex = 6;
            this.lblCantidadConversores.Text = "Cantidad:";
            // 
            // txtCantidadConversores
            // 
            this.txtCantidadConversores.Location = new System.Drawing.Point(321, 254);
            this.txtCantidadConversores.Name = "txtCantidadConversores";
            this.txtCantidadConversores.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadConversores.TabIndex = 7;
            // 
            // cboTipoConversor
            // 
            this.cboTipoConversor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoConversor.FormattingEnabled = true;
            this.cboTipoConversor.Items.AddRange(new object[] {
            "Moneda",
            "Masa",
            "Volumen",
            "Longitud",
            "Almacenamiento",
            "Tiempo"});
            this.cboTipoConversor.Location = new System.Drawing.Point(280, 115);
            this.cboTipoConversor.Name = "cboTipoConversor";
            this.cboTipoConversor.Size = new System.Drawing.Size(141, 21);
            this.cboTipoConversor.TabIndex = 9;
            this.cboTipoConversor.TextChanged += new System.EventHandler(this.cboTipoConversor_TextChanged);
            // 
            // lblTipoConversor
            // 
            this.lblTipoConversor.AutoSize = true;
            this.lblTipoConversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoConversor.Location = new System.Drawing.Point(225, 116);
            this.lblTipoConversor.Name = "lblTipoConversor";
            this.lblTipoConversor.Size = new System.Drawing.Size(49, 20);
            this.lblTipoConversor.TabIndex = 8;
            this.lblTipoConversor.Text = "TIPO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 477);
            this.Controls.Add(this.cboTipoConversor);
            this.Controls.Add(this.lblTipoConversor);
            this.Controls.Add(this.txtCantidadConversores);
            this.Controls.Add(this.lblCantidadConversores);
            this.Controls.Add(this.lblRespuestaConversores);
            this.Controls.Add(this.btnConvertirConversores);
            this.Controls.Add(this.cboAConversores);
            this.Controls.Add(this.lblAConversores);
            this.Controls.Add(this.cboDeConversores);
            this.Controls.Add(this.lblDeConversores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeConversores;
        private System.Windows.Forms.ComboBox cboDeConversores;
        private System.Windows.Forms.ComboBox cboAConversores;
        private System.Windows.Forms.Label lblAConversores;
        private System.Windows.Forms.Button btnConvertirConversores;
        private System.Windows.Forms.Label lblRespuestaConversores;
        private System.Windows.Forms.Label lblCantidadConversores;
        private System.Windows.Forms.TextBox txtCantidadConversores;
        private System.Windows.Forms.ComboBox cboTipoConversor;
        private System.Windows.Forms.Label lblTipoConversor;
    }
}

