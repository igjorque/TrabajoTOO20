namespace Aplicacion.UserControls
{
    partial class ucDatosVehiculo
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbBastidor = new System.Windows.Forms.TextBox();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPotencia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPrecioRec = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbVehiculo = new System.Windows.Forms.GroupBox();
            this.rbUsado = new System.Windows.Forms.RadioButton();
            this.rbNuevo = new System.Windows.Forms.RadioButton();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.gbVehiculo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número bastidor:";
            // 
            // tbBastidor
            // 
            this.tbBastidor.Location = new System.Drawing.Point(139, 27);
            this.tbBastidor.Name = "tbBastidor";
            this.tbBastidor.Size = new System.Drawing.Size(120, 20);
            this.tbBastidor.TabIndex = 1;
            this.tbBastidor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(139, 62);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(120, 20);
            this.tbMarca.TabIndex = 3;
            this.tbMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marca:";
            // 
            // tbModelo
            // 
            this.tbModelo.Location = new System.Drawing.Point(139, 97);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(120, 20);
            this.tbModelo.TabIndex = 5;
            this.tbModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Modelo:";
            // 
            // tbPotencia
            // 
            this.tbPotencia.Location = new System.Drawing.Point(139, 132);
            this.tbPotencia.Name = "tbPotencia";
            this.tbPotencia.Size = new System.Drawing.Size(120, 20);
            this.tbPotencia.TabIndex = 7;
            this.tbPotencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Potencia:";
            // 
            // tbPrecioRec
            // 
            this.tbPrecioRec.Location = new System.Drawing.Point(139, 167);
            this.tbPrecioRec.Name = "tbPrecioRec";
            this.tbPrecioRec.Size = new System.Drawing.Size(120, 20);
            this.tbPrecioRec.TabIndex = 9;
            this.tbPrecioRec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Precio recomendado:";
            // 
            // gbVehiculo
            // 
            this.gbVehiculo.Controls.Add(this.rbUsado);
            this.gbVehiculo.Controls.Add(this.rbNuevo);
            this.gbVehiculo.Location = new System.Drawing.Point(340, 27);
            this.gbVehiculo.Name = "gbVehiculo";
            this.gbVehiculo.Size = new System.Drawing.Size(157, 51);
            this.gbVehiculo.TabIndex = 10;
            this.gbVehiculo.TabStop = false;
            this.gbVehiculo.Text = "Vehículo";
            // 
            // rbUsado
            // 
            this.rbUsado.AutoSize = true;
            this.rbUsado.Location = new System.Drawing.Point(88, 23);
            this.rbUsado.Name = "rbUsado";
            this.rbUsado.Size = new System.Drawing.Size(56, 17);
            this.rbUsado.TabIndex = 1;
            this.rbUsado.TabStop = true;
            this.rbUsado.Text = "Usado";
            this.rbUsado.UseVisualStyleBackColor = true;
            // 
            // rbNuevo
            // 
            this.rbNuevo.AutoSize = true;
            this.rbNuevo.Location = new System.Drawing.Point(25, 23);
            this.rbNuevo.Name = "rbNuevo";
            this.rbNuevo.Size = new System.Drawing.Size(57, 17);
            this.rbNuevo.TabIndex = 0;
            this.rbNuevo.TabStop = true;
            this.rbNuevo.Text = "Nuevo";
            this.rbNuevo.UseVisualStyleBackColor = true;
            // 
            // btAceptar
            // 
            this.btAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btAceptar.Location = new System.Drawing.Point(37, 210);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 11;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Location = new System.Drawing.Point(162, 210);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 12;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // ucDatosVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.gbVehiculo);
            this.Controls.Add(this.tbPrecioRec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPotencia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbModelo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbBastidor);
            this.Controls.Add(this.label1);
            this.Name = "ucDatosVehiculo";
            this.Size = new System.Drawing.Size(570, 250);
            this.gbVehiculo.ResumeLayout(false);
            this.gbVehiculo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox tbBastidor;
        internal System.Windows.Forms.TextBox tbMarca;
        internal System.Windows.Forms.TextBox tbModelo;
        internal System.Windows.Forms.TextBox tbPotencia;
        internal System.Windows.Forms.TextBox tbPrecioRec;
        internal System.Windows.Forms.GroupBox gbVehiculo;
        internal System.Windows.Forms.Button btAceptar;
        internal System.Windows.Forms.Button btCancelar;
        public System.Windows.Forms.RadioButton rbUsado;
        public System.Windows.Forms.RadioButton rbNuevo;
    }
}
