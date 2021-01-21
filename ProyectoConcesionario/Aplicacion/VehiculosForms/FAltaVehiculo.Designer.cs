namespace Aplicacion.VehiculosForms
{
    partial class FAltaVehiculo
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
            this.ucDatosVehiculo1 = new Aplicacion.UserControls.ucDatosVehiculo();
            this.SuspendLayout();
            // 
            // ucDatosVehiculo1
            // 
            this.ucDatosVehiculo1.Location = new System.Drawing.Point(12, 12);
            this.ucDatosVehiculo1.Name = "ucDatosVehiculo1";
            this.ucDatosVehiculo1.Size = new System.Drawing.Size(570, 250);
            this.ucDatosVehiculo1.TabIndex = 0;
            // 
            // FAltaVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 271);
            this.Controls.Add(this.ucDatosVehiculo1);
            this.Name = "FAltaVehiculo";
            this.Text = "FAltaVehiculo";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ucDatosVehiculo ucDatosVehiculo1;
    }
}