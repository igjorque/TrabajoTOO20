namespace Aplicacion.ClientesForms
{
    partial class FListarClientes
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
            this.gbCategoria = new System.Windows.Forms.GroupBox();
            this.rbCatC = new System.Windows.Forms.RadioButton();
            this.rbCatB = new System.Windows.Forms.RadioButton();
            this.rbCatA = new System.Windows.Forms.RadioButton();
            this.rbCatTodas = new System.Windows.Forms.RadioButton();
            this.gridClientes = new System.Windows.Forms.DataGridView();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCategoria
            // 
            this.gbCategoria.Controls.Add(this.rbCatC);
            this.gbCategoria.Controls.Add(this.rbCatB);
            this.gbCategoria.Controls.Add(this.rbCatA);
            this.gbCategoria.Controls.Add(this.rbCatTodas);
            this.gbCategoria.Location = new System.Drawing.Point(572, 33);
            this.gbCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.gbCategoria.Name = "gbCategoria";
            this.gbCategoria.Padding = new System.Windows.Forms.Padding(4);
            this.gbCategoria.Size = new System.Drawing.Size(247, 58);
            this.gbCategoria.TabIndex = 0;
            this.gbCategoria.TabStop = false;
            this.gbCategoria.Text = "Categoría";
            // 
            // rbCatC
            // 
            this.rbCatC.AutoSize = true;
            this.rbCatC.Location = new System.Drawing.Point(191, 25);
            this.rbCatC.Margin = new System.Windows.Forms.Padding(4);
            this.rbCatC.Name = "rbCatC";
            this.rbCatC.Size = new System.Drawing.Size(38, 21);
            this.rbCatC.TabIndex = 3;
            this.rbCatC.TabStop = true;
            this.rbCatC.Text = "C";
            this.rbCatC.UseVisualStyleBackColor = true;
            this.rbCatC.Click += new System.EventHandler(this.rbCatC_Click);
            // 
            // rbCatB
            // 
            this.rbCatB.AutoSize = true;
            this.rbCatB.Location = new System.Drawing.Point(140, 25);
            this.rbCatB.Margin = new System.Windows.Forms.Padding(4);
            this.rbCatB.Name = "rbCatB";
            this.rbCatB.Size = new System.Drawing.Size(38, 21);
            this.rbCatB.TabIndex = 2;
            this.rbCatB.TabStop = true;
            this.rbCatB.Text = "B";
            this.rbCatB.UseVisualStyleBackColor = true;
            this.rbCatB.Click += new System.EventHandler(this.rbCatB_Click);
            // 
            // rbCatA
            // 
            this.rbCatA.AutoSize = true;
            this.rbCatA.Location = new System.Drawing.Point(89, 23);
            this.rbCatA.Margin = new System.Windows.Forms.Padding(4);
            this.rbCatA.Name = "rbCatA";
            this.rbCatA.Size = new System.Drawing.Size(38, 21);
            this.rbCatA.TabIndex = 1;
            this.rbCatA.TabStop = true;
            this.rbCatA.Text = "A";
            this.rbCatA.UseVisualStyleBackColor = true;
            this.rbCatA.Click += new System.EventHandler(this.rbCatA_Click);
            // 
            // rbCatTodas
            // 
            this.rbCatTodas.AutoSize = true;
            this.rbCatTodas.Location = new System.Drawing.Point(8, 25);
            this.rbCatTodas.Margin = new System.Windows.Forms.Padding(4);
            this.rbCatTodas.Name = "rbCatTodas";
            this.rbCatTodas.Size = new System.Drawing.Size(69, 21);
            this.rbCatTodas.TabIndex = 0;
            this.rbCatTodas.TabStop = true;
            this.rbCatTodas.Text = "Todas";
            this.rbCatTodas.UseVisualStyleBackColor = true;
            // 
            // gridClientes
            // 
            this.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DNI,
            this.Nombre,
            this.Telefono,
            this.Categoria});
            this.gridClientes.Location = new System.Drawing.Point(73, 342);
            this.gridClientes.Margin = new System.Windows.Forms.Padding(4);
            this.gridClientes.Name = "gridClientes";
            this.gridClientes.ReadOnly = true;
            this.gridClientes.RowHeadersWidth = 51;
            this.gridClientes.Size = new System.Drawing.Size(681, 185);
            this.gridClientes.TabIndex = 1;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.MinimumWidth = 6;
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            this.DNI.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 125;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoría";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 125;
            // 
            // FListarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 561);
            this.Controls.Add(this.gridClientes);
            this.Controls.Add(this.gbCategoria);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FListarClientes";
            this.Text = "FListarClientes";
            this.gbCategoria.ResumeLayout(false);
            this.gbCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCategoria;
        private System.Windows.Forms.RadioButton rbCatC;
        private System.Windows.Forms.RadioButton rbCatB;
        private System.Windows.Forms.RadioButton rbCatA;
        private System.Windows.Forms.RadioButton rbCatTodas;
        private System.Windows.Forms.DataGridView gridClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
    }
}