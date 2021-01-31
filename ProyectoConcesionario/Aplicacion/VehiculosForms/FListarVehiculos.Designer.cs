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
            ((System.ComponentModel.ISupportInitialize)(this.dgVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgVehiculos
            // 
            this.dgVehiculos.AllowUserToAddRows = false;
            this.dgVehiculos.AllowUserToDeleteRows = false;
            this.dgVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVehiculos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgVehiculos.Location = new System.Drawing.Point(0, 0);
            this.dgVehiculos.Name = "dgVehiculos";
            this.dgVehiculos.ReadOnly = true;
            this.dgVehiculos.Size = new System.Drawing.Size(643, 442);
            this.dgVehiculos.TabIndex = 0;
            // 
            // FListarVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 442);
            this.Controls.Add(this.dgVehiculos);
            this.Name = "FListarVehiculos";
            this.Text = "FListarVehiculos";
            ((System.ComponentModel.ISupportInitialize)(this.dgVehiculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVehiculos;
    }
}