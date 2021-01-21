namespace Aplicacion.UserControls
{
    partial class ucDatosVehiculoUsado
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbMatricula = new System.Windows.Forms.TextBox();
            this.tbFechaMatriculacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrícula:";
            // 
            // tbMatricula
            // 
            this.tbMatricula.Location = new System.Drawing.Point(125, 13);
            this.tbMatricula.Name = "tbMatricula";
            this.tbMatricula.Size = new System.Drawing.Size(120, 20);
            this.tbMatricula.TabIndex = 1;
            // 
            // tbFechaMatriculacion
            // 
            this.tbFechaMatriculacion.Location = new System.Drawing.Point(125, 48);
            this.tbFechaMatriculacion.Name = "tbFechaMatriculacion";
            this.tbFechaMatriculacion.Size = new System.Drawing.Size(120, 20);
            this.tbFechaMatriculacion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha matriculación:";
            // 
            // ucDatosVehiculoUsado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbFechaMatriculacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMatricula);
            this.Controls.Add(this.label1);
            this.Name = "ucDatosVehiculoUsado";
            this.Size = new System.Drawing.Size(258, 79);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox tbMatricula;
        internal System.Windows.Forms.TextBox tbFechaMatriculacion;
    }
}
