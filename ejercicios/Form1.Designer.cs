
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
            this.txtCantidadImpuesto = new System.Windows.Forms.TextBox();
            this.lblCantidadImpuesto = new System.Windows.Forms.Label();
            this.btnCalcularImpuesto = new System.Windows.Forms.Button();
            this.lblTituloImpuesto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblValorAPagarImpuesto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCantidadImpuesto
            // 
            this.txtCantidadImpuesto.Location = new System.Drawing.Point(218, 142);
            this.txtCantidadImpuesto.Name = "txtCantidadImpuesto";
            this.txtCantidadImpuesto.Size = new System.Drawing.Size(136, 20);
            this.txtCantidadImpuesto.TabIndex = 0;
            // 
            // lblCantidadImpuesto
            // 
            this.lblCantidadImpuesto.AutoSize = true;
            this.lblCantidadImpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadImpuesto.Location = new System.Drawing.Point(99, 137);
            this.lblCantidadImpuesto.Name = "lblCantidadImpuesto";
            this.lblCantidadImpuesto.Size = new System.Drawing.Size(113, 25);
            this.lblCantidadImpuesto.TabIndex = 1;
            this.lblCantidadImpuesto.Text = "Cantidad:";
            // 
            // btnCalcularImpuesto
            // 
            this.btnCalcularImpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularImpuesto.Location = new System.Drawing.Point(403, 130);
            this.btnCalcularImpuesto.Name = "btnCalcularImpuesto";
            this.btnCalcularImpuesto.Size = new System.Drawing.Size(123, 39);
            this.btnCalcularImpuesto.TabIndex = 2;
            this.btnCalcularImpuesto.Text = "Calcular";
            this.btnCalcularImpuesto.UseVisualStyleBackColor = true;
            this.btnCalcularImpuesto.Click += new System.EventHandler(this.btnCalcularImpuesto_Click);
            // 
            // lblTituloImpuesto
            // 
            this.lblTituloImpuesto.AutoSize = true;
            this.lblTituloImpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloImpuesto.Location = new System.Drawing.Point(83, 33);
            this.lblTituloImpuesto.Name = "lblTituloImpuesto";
            this.lblTituloImpuesto.Size = new System.Drawing.Size(547, 25);
            this.lblTituloImpuesto.TabIndex = 3;
            this.lblTituloImpuesto.Text = "Cálculo de Impuesto a las Actividades Económicas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // lblValorAPagarImpuesto
            // 
            this.lblValorAPagarImpuesto.AutoSize = true;
            this.lblValorAPagarImpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorAPagarImpuesto.Location = new System.Drawing.Point(100, 203);
            this.lblValorAPagarImpuesto.Name = "lblValorAPagarImpuesto";
            this.lblValorAPagarImpuesto.Size = new System.Drawing.Size(190, 24);
            this.lblValorAPagarImpuesto.TabIndex = 5;
            this.lblValorAPagarImpuesto.Text = "El valor a pagar es:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 407);
            this.Controls.Add(this.lblValorAPagarImpuesto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTituloImpuesto);
            this.Controls.Add(this.btnCalcularImpuesto);
            this.Controls.Add(this.lblCantidadImpuesto);
            this.Controls.Add(this.txtCantidadImpuesto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCantidadImpuesto;
        private System.Windows.Forms.Label lblCantidadImpuesto;
        private System.Windows.Forms.Button btnCalcularImpuesto;
        private System.Windows.Forms.Label lblTituloImpuesto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblValorAPagarImpuesto;
    }
}

