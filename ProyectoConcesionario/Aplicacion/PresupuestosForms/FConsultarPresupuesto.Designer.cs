namespace Aplicacion.PresupuestosForms
{
    partial class FConsultarPresupuesto
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
            this.btAceptar = new System.Windows.Forms.Button();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbIDCliente = new System.Windows.Forms.Label();
            this.lbIDPresupuesto = new System.Windows.Forms.Label();
            this.dgLineas = new System.Windows.Forms.DataGridView();
            this.tbFecha = new System.Windows.Forms.TextBox();
            this.tbIDCliente = new System.Windows.Forms.TextBox();
            this.tbIDPresupuesto = new System.Windows.Forms.TextBox();
            this.clIdLinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIdVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgLineas)).BeginInit();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(81, 213);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 19;
            this.btAceptar.Text = "Cerrar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(10, 160);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(37, 13);
            this.lbFecha.TabIndex = 18;
            this.lbFecha.Text = "Fecha";
            // 
            // lbIDCliente
            // 
            this.lbIDCliente.AutoSize = true;
            this.lbIDCliente.Location = new System.Drawing.Point(10, 100);
            this.lbIDCliente.Name = "lbIDCliente";
            this.lbIDCliente.Size = new System.Drawing.Size(84, 13);
            this.lbIDCliente.TabIndex = 17;
            this.lbIDCliente.Text = "ID Cliente (DNI):";
            // 
            // lbIDPresupuesto
            // 
            this.lbIDPresupuesto.AutoSize = true;
            this.lbIDPresupuesto.Location = new System.Drawing.Point(10, 40);
            this.lbIDPresupuesto.Name = "lbIDPresupuesto";
            this.lbIDPresupuesto.Size = new System.Drawing.Size(83, 13);
            this.lbIDPresupuesto.TabIndex = 16;
            this.lbIDPresupuesto.Text = "ID Presupuesto:";
            // 
            // dgLineas
            // 
            this.dgLineas.AllowUserToAddRows = false;
            this.dgLineas.AllowUserToDeleteRows = false;
            this.dgLineas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLineas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clIdLinea,
            this.clIdVehiculo,
            this.clPrecio,
            this.clEstado});
            this.dgLineas.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgLineas.Location = new System.Drawing.Point(246, 0);
            this.dgLineas.Name = "dgLineas";
            this.dgLineas.ReadOnly = true;
            this.dgLineas.Size = new System.Drawing.Size(443, 260);
            this.dgLineas.TabIndex = 15;
            // 
            // tbFecha
            // 
            this.tbFecha.Enabled = false;
            this.tbFecha.Location = new System.Drawing.Point(112, 157);
            this.tbFecha.Name = "tbFecha";
            this.tbFecha.Size = new System.Drawing.Size(119, 20);
            this.tbFecha.TabIndex = 14;
            // 
            // tbIDCliente
            // 
            this.tbIDCliente.Enabled = false;
            this.tbIDCliente.Location = new System.Drawing.Point(112, 97);
            this.tbIDCliente.Name = "tbIDCliente";
            this.tbIDCliente.Size = new System.Drawing.Size(119, 20);
            this.tbIDCliente.TabIndex = 13;
            // 
            // tbIDPresupuesto
            // 
            this.tbIDPresupuesto.Enabled = false;
            this.tbIDPresupuesto.Location = new System.Drawing.Point(112, 37);
            this.tbIDPresupuesto.Name = "tbIDPresupuesto";
            this.tbIDPresupuesto.Size = new System.Drawing.Size(119, 20);
            this.tbIDPresupuesto.TabIndex = 12;
            // 
            // clIdLinea
            // 
            this.clIdLinea.HeaderText = "ID Línea";
            this.clIdLinea.Name = "clIdLinea";
            this.clIdLinea.ReadOnly = true;
            // 
            // clIdVehiculo
            // 
            this.clIdVehiculo.HeaderText = "Núm. Bastidor";
            this.clIdVehiculo.Name = "clIdVehiculo";
            this.clIdVehiculo.ReadOnly = true;
            // 
            // clPrecio
            // 
            this.clPrecio.HeaderText = "Precio";
            this.clPrecio.Name = "clPrecio";
            this.clPrecio.ReadOnly = true;
            // 
            // clEstado
            // 
            this.clEstado.HeaderText = "Estado";
            this.clEstado.Name = "clEstado";
            this.clEstado.ReadOnly = true;
            // 
            // FConsultarPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 260);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.lbIDCliente);
            this.Controls.Add(this.lbIDPresupuesto);
            this.Controls.Add(this.dgLineas);
            this.Controls.Add(this.tbFecha);
            this.Controls.Add(this.tbIDCliente);
            this.Controls.Add(this.tbIDPresupuesto);
            this.Name = "FConsultarPresupuesto";
            this.Text = "FConsultarPresupuesto";
            ((System.ComponentModel.ISupportInitialize)(this.dgLineas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbIDCliente;
        private System.Windows.Forms.Label lbIDPresupuesto;
        private System.Windows.Forms.DataGridView dgLineas;
        private System.Windows.Forms.TextBox tbFecha;
        private System.Windows.Forms.TextBox tbIDCliente;
        private System.Windows.Forms.TextBox tbIDPresupuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIdLinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIdVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEstado;
    }
}