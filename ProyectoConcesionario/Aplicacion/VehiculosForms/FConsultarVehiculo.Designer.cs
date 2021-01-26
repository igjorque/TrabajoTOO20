namespace Aplicacion.VehiculosForms
{
    partial class FConsultarVehiculo
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
            this.ucDatos = new Aplicacion.UserControls.ucDatosVehiculo();
            this.SuspendLayout();
            // 
            // ucDatos
            // 
            this.ucDatos.Location = new System.Drawing.Point(12, 12);
            this.ucDatos.Name = "ucDatos";
            this.ucDatos.Size = new System.Drawing.Size(570, 250);
            this.ucDatos.TabIndex = 0;
            // 
            // FConsultarVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 271);
            this.Controls.Add(this.ucDatos);
            this.Name = "FConsultarVehiculo";
            this.Text = "FConsultarVehiculo";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ucDatosVehiculo ucDatos;
    }
}