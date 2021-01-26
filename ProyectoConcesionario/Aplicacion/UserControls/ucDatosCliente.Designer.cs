namespace Aplicacion.UserControls
{
    partial class ucDatosCliente
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btCancelar = new System.Windows.Forms.Button();
            this.gbCategoria = new System.Windows.Forms.GroupBox();
            this.rbCatC = new System.Windows.Forms.RadioButton();
            this.rbCatB = new System.Windows.Forms.RadioButton();
            this.rbCatA = new System.Windows.Forms.RadioButton();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btAceptar = new System.Windows.Forms.Button();
            this.gbCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(146, 143);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 17;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // gbCategoria
            // 
            this.gbCategoria.Controls.Add(this.rbCatC);
            this.gbCategoria.Controls.Add(this.rbCatB);
            this.gbCategoria.Controls.Add(this.rbCatA);
            this.gbCategoria.Location = new System.Drawing.Point(60, 91);
            this.gbCategoria.Name = "gbCategoria";
            this.gbCategoria.Size = new System.Drawing.Size(133, 46);
            this.gbCategoria.TabIndex = 16;
            this.gbCategoria.TabStop = false;
            this.gbCategoria.Text = "Categoría";
            // 
            // rbCatC
            // 
            this.rbCatC.AutoSize = true;
            this.rbCatC.Location = new System.Drawing.Point(91, 19);
            this.rbCatC.Name = "rbCatC";
            this.rbCatC.Size = new System.Drawing.Size(32, 17);
            this.rbCatC.TabIndex = 2;
            this.rbCatC.TabStop = true;
            this.rbCatC.Text = "C";
            this.rbCatC.UseVisualStyleBackColor = true;
            // 
            // rbCatB
            // 
            this.rbCatB.AutoSize = true;
            this.rbCatB.Location = new System.Drawing.Point(53, 19);
            this.rbCatB.Name = "rbCatB";
            this.rbCatB.Size = new System.Drawing.Size(32, 17);
            this.rbCatB.TabIndex = 1;
            this.rbCatB.TabStop = true;
            this.rbCatB.Text = "B";
            this.rbCatB.UseVisualStyleBackColor = true;
            // 
            // rbCatA
            // 
            this.rbCatA.AutoSize = true;
            this.rbCatA.Location = new System.Drawing.Point(15, 19);
            this.rbCatA.Name = "rbCatA";
            this.rbCatA.Size = new System.Drawing.Size(32, 17);
            this.rbCatA.TabIndex = 0;
            this.rbCatA.TabStop = true;
            this.rbCatA.Text = "A";
            this.rbCatA.UseVisualStyleBackColor = true;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(95, 65);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(146, 20);
            this.tbTelefono.TabIndex = 15;
            this.tbTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Teléfono:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(95, 39);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(146, 20);
            this.tbNombre.TabIndex = 13;
            this.tbNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre:";
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(96, 13);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(145, 20);
            this.tbDni.TabIndex = 11;
            this.tbDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "DNI:";
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(39, 143);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 9;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            // 
            // ucDatosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.gbCategoria);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAceptar);
            this.Name = "ucDatosCliente";
            this.Size = new System.Drawing.Size(254, 178);
            this.gbCategoria.ResumeLayout(false);
            this.gbCategoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox tbTelefono;
        internal System.Windows.Forms.TextBox tbNombre;
        internal System.Windows.Forms.TextBox tbDni;
        internal System.Windows.Forms.Button btCancelar;
        internal System.Windows.Forms.RadioButton rbCatC;
        internal System.Windows.Forms.RadioButton rbCatB;
        internal System.Windows.Forms.RadioButton rbCatA;
        internal System.Windows.Forms.Button btAceptar;
    }
}
