﻿namespace Aplicacion.ClientesForms
{
    partial class FBajaCliente
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
            this.ucDatos = new Aplicacion.UserControls.ucDatosCliente();
            this.SuspendLayout();
            // 
            // ucDatos
            // 
            this.ucDatos.Location = new System.Drawing.Point(16, 15);
            this.ucDatos.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucDatos.Name = "ucDatos";
            this.ucDatos.Size = new System.Drawing.Size(379, 267);
            this.ucDatos.TabIndex = 0;
            // 
            // FBajaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 296);
            this.Controls.Add(this.ucDatos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FBajaCliente";
            this.Text = "FBajaCliente";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ucDatosCliente ucDatos;
    }
}