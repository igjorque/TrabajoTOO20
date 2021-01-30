namespace Aplicacion.PresupuestosForms
{
    partial class FAltaPresupuesto
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
            this.tbIDPresupuesto = new System.Windows.Forms.TextBox();
            this.tbIDCliente = new System.Windows.Forms.TextBox();
            this.tbFecha = new System.Windows.Forms.TextBox();
            this.dgLineas = new System.Windows.Forms.DataGridView();
            this.clIDLinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIDVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEstado = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lbIDPresupuesto = new System.Windows.Forms.Label();
            this.lbIDCliente = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.epFecha = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgLineas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFecha)).BeginInit();
            this.SuspendLayout();
            // 
            // tbIDPresupuesto
            // 
            this.tbIDPresupuesto.Location = new System.Drawing.Point(122, 37);
            this.tbIDPresupuesto.Name = "tbIDPresupuesto";
            this.tbIDPresupuesto.Size = new System.Drawing.Size(119, 20);
            this.tbIDPresupuesto.TabIndex = 0;
            // 
            // tbIDCliente
            // 
            this.tbIDCliente.Location = new System.Drawing.Point(122, 97);
            this.tbIDCliente.Name = "tbIDCliente";
            this.tbIDCliente.Size = new System.Drawing.Size(119, 20);
            this.tbIDCliente.TabIndex = 1;
            // 
            // tbFecha
            // 
            this.tbFecha.Location = new System.Drawing.Point(122, 157);
            this.tbFecha.Name = "tbFecha";
            this.tbFecha.Size = new System.Drawing.Size(119, 20);
            this.tbFecha.TabIndex = 3;
            this.tbFecha.Validating += new System.ComponentModel.CancelEventHandler(this.tbFecha_Validating);
            this.tbFecha.Validated += new System.EventHandler(this.tbFecha_Validated);
            // 
            // dgLineas
            // 
            this.dgLineas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLineas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clIDLinea,
            this.clIDVehiculo,
            this.clPrecio,
            this.clEstado});
            this.dgLineas.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgLineas.Location = new System.Drawing.Point(293, 0);
            this.dgLineas.Name = "dgLineas";
            this.dgLineas.Size = new System.Drawing.Size(444, 260);
            this.dgLineas.TabIndex = 5;
            // 
            // clIDLinea
            // 
            this.clIDLinea.HeaderText = "ID";
            this.clIDLinea.Name = "clIDLinea";
            // 
            // clIDVehiculo
            // 
            this.clIDVehiculo.HeaderText = "Número de bastidor";
            this.clIDVehiculo.Name = "clIDVehiculo";
            // 
            // clPrecio
            // 
            this.clPrecio.HeaderText = "Precio";
            this.clPrecio.Name = "clPrecio";
            // 
            // clEstado
            // 
            this.clEstado.HeaderText = "Estado";
            this.clEstado.Items.AddRange(new object[] {
            "Aceptado",
            "Pendiente",
            "Desestimado"});
            this.clEstado.Name = "clEstado";
            this.clEstado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clEstado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // lbIDPresupuesto
            // 
            this.lbIDPresupuesto.AutoSize = true;
            this.lbIDPresupuesto.Location = new System.Drawing.Point(20, 40);
            this.lbIDPresupuesto.Name = "lbIDPresupuesto";
            this.lbIDPresupuesto.Size = new System.Drawing.Size(83, 13);
            this.lbIDPresupuesto.TabIndex = 6;
            this.lbIDPresupuesto.Text = "ID Presupuesto:";
            // 
            // lbIDCliente
            // 
            this.lbIDCliente.AutoSize = true;
            this.lbIDCliente.Location = new System.Drawing.Point(20, 100);
            this.lbIDCliente.Name = "lbIDCliente";
            this.lbIDCliente.Size = new System.Drawing.Size(84, 13);
            this.lbIDCliente.TabIndex = 7;
            this.lbIDCliente.Text = "ID Cliente (DNI):";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(20, 160);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(37, 13);
            this.lbFecha.TabIndex = 9;
            this.lbFecha.Text = "Fecha";
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(57, 225);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 10;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(166, 225);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 11;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // epFecha
            // 
            this.epFecha.ContainerControl = this;
            // 
            // FAltaPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 260);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.lbIDCliente);
            this.Controls.Add(this.lbIDPresupuesto);
            this.Controls.Add(this.dgLineas);
            this.Controls.Add(this.tbFecha);
            this.Controls.Add(this.tbIDCliente);
            this.Controls.Add(this.tbIDPresupuesto);
            this.Name = "FAltaPresupuesto";
            this.Text = "FAltaPresupuesto";
            ((System.ComponentModel.ISupportInitialize)(this.dgLineas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFecha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIDPresupuesto;
        private System.Windows.Forms.TextBox tbIDCliente;
        private System.Windows.Forms.TextBox tbFecha;
        private System.Windows.Forms.DataGridView dgLineas;
        private System.Windows.Forms.Label lbIDPresupuesto;
        private System.Windows.Forms.Label lbIDCliente;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIDLinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIDVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrecio;
        private System.Windows.Forms.DataGridViewComboBoxColumn clEstado;
        private System.Windows.Forms.ErrorProvider epFecha;
    }
}