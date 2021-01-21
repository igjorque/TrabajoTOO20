namespace Aplicacion.VehiculosForms
{
    partial class FBajaVehiculo
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
            this.ucDatosVehiculo = new Aplicacion.UserControls.ucDatosVehiculo();
            this.SuspendLayout();
            // 
            // ucDatosVehiculo
            // 
            this.ucDatosVehiculo.Location = new System.Drawing.Point(12, 12);
            this.ucDatosVehiculo.Name = "ucDatosVehiculo";
            this.ucDatosVehiculo.Size = new System.Drawing.Size(570, 250);
            this.ucDatosVehiculo.TabIndex = 0;
            // 
            // FBajaVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 271);
            this.Controls.Add(this.ucDatosVehiculo);
            this.Name = "FBajaVehiculo";
            this.Text = "FBajaVehiculo";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ucDatosVehiculo ucDatosVehiculo;
    }
}