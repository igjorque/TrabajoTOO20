namespace Aplicacion.VehiculosForms
{
    partial class FListarVehiculos
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
            this.dgVehiculos = new System.Windows.Forms.DataGridView();
            this.clBastidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPotencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPvp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgVehiculos
            // 
            this.dgVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clBastidor,
            this.clMarca,
            this.clModelo,
            this.clPotencia,
            this.clPrecio,
            this.clPvp});
            this.dgVehiculos.Location = new System.Drawing.Point(12, 12);
            this.dgVehiculos.Name = "dgVehiculos";
            this.dgVehiculos.Size = new System.Drawing.Size(643, 420);
            this.dgVehiculos.TabIndex = 0;
            // 
            // clBastidor
            // 
            this.clBastidor.HeaderText = "Número de bastidor";
            this.clBastidor.Name = "clBastidor";
            // 
            // clMarca
            // 
            this.clMarca.HeaderText = "Marca";
            this.clMarca.Name = "clMarca";
            // 
            // clModelo
            // 
            this.clModelo.HeaderText = "Modelo";
            this.clModelo.Name = "clModelo";
            // 
            // clPotencia
            // 
            this.clPotencia.HeaderText = "Potencia";
            this.clPotencia.Name = "clPotencia";
            // 
            // clPrecio
            // 
            this.clPrecio.HeaderText = "Precio recomendado";
            this.clPrecio.Name = "clPrecio";
            // 
            // clPvp
            // 
            this.clPvp.HeaderText = "PVP";
            this.clPvp.Name = "clPvp";
            // 
            // FListarVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 442);
            this.Controls.Add(this.dgVehiculos);
            this.Name = "FListarVehiculos";
            this.Text = "FListarVehiculos";
            ((System.ComponentModel.ISupportInitialize)(this.dgVehiculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVehiculos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBastidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPotencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPvp;
    }
}