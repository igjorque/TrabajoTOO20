namespace Aplicacion
{
    partial class FClave
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
            this.lbClave = new System.Windows.Forms.Label();
            this.tbClave = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbClave
            // 
            this.lbClave.AutoSize = true;
            this.lbClave.Location = new System.Drawing.Point(19, 18);
            this.lbClave.Name = "lbClave";
            this.lbClave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbClave.Size = new System.Drawing.Size(34, 13);
            this.lbClave.TabIndex = 0;
            this.lbClave.Text = "Clave";
            // 
            // tbClave
            // 
            this.tbClave.Location = new System.Drawing.Point(125, 15);
            this.tbClave.Name = "tbClave";
            this.tbClave.Size = new System.Drawing.Size(100, 20);
            this.tbClave.TabIndex = 1;
            // 
            // btBuscar
            // 
            this.btBuscar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btBuscar.Location = new System.Drawing.Point(19, 52);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 2;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Location = new System.Drawing.Point(147, 52);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // FClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 91);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.tbClave);
            this.Controls.Add(this.lbClave);
            this.Name = "FClave";
            this.Text = "FClave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lbClave;
        internal System.Windows.Forms.TextBox tbClave;
        internal System.Windows.Forms.Button btBuscar;
        internal System.Windows.Forms.Button btCancelar;
    }
}