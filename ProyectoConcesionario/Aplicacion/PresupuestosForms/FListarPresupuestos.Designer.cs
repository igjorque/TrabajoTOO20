namespace Aplicacion.PresupuestosForms
{
    partial class FListarPresupuestos
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
            this.dgPresupuestos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgPresupuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPresupuestos
            // 
            this.dgPresupuestos.AllowUserToAddRows = false;
            this.dgPresupuestos.AllowUserToDeleteRows = false;
            this.dgPresupuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPresupuestos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPresupuestos.Location = new System.Drawing.Point(0, 0);
            this.dgPresupuestos.Name = "dgPresupuestos";
            this.dgPresupuestos.ReadOnly = true;
            this.dgPresupuestos.Size = new System.Drawing.Size(800, 450);
            this.dgPresupuestos.TabIndex = 0;
            // 
            // FListarPresupuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgPresupuestos);
            this.Name = "FListarPresupuestos";
            this.Text = "FListarPresupuestos";
            ((System.ComponentModel.ISupportInitialize)(this.dgPresupuestos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPresupuestos;
    }
}