﻿namespace Aplicacion.ClientesForms
{
    partial class FAltaCliente
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
            this.ucDatos.Location = new System.Drawing.Point(10, 11);
            this.ucDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucDatos.Name = "ucDatos";
            this.ucDatos.Size = new System.Drawing.Size(283, 214);
            this.ucDatos.TabIndex = 0;
            // 
            // FAltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 236);
            this.Controls.Add(this.ucDatos);
            this.Name = "FAltaCliente";
            this.Text = "FAltaCliente";
            this.ResumeLayout(false);

        }

        #endregion

        internal UserControls.ucDatosCliente ucDatos;
    }
}