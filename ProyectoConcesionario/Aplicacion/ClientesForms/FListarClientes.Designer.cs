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
            this.rbCatTodas = new System.Windows.Forms.RadioButton();
            this.rbCatA = new System.Windows.Forms.RadioButton();
            this.rbCatB = new System.Windows.Forms.RadioButton();
            this.rbCatC = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCategoria
            // 
            this.gbCategoria.Controls.Add(this.rbCatC);
            this.gbCategoria.Controls.Add(this.rbCatB);
            this.gbCategoria.Controls.Add(this.rbCatA);
            this.gbCategoria.Controls.Add(this.rbCatTodas);
            this.gbCategoria.Location = new System.Drawing.Point(429, 27);
            this.gbCategoria.Name = "gbCategoria";
            this.gbCategoria.Size = new System.Drawing.Size(185, 47);
            this.gbCategoria.TabIndex = 0;
            this.gbCategoria.TabStop = false;
            this.gbCategoria.Text = "Categoría";
            // 
            // rbCatTodas
            // 
            this.rbCatTodas.AutoSize = true;
            this.rbCatTodas.Location = new System.Drawing.Point(6, 20);
            this.rbCatTodas.Name = "rbCatTodas";
            this.rbCatTodas.Size = new System.Drawing.Size(55, 17);
            this.rbCatTodas.TabIndex = 0;
            this.rbCatTodas.TabStop = true;
            this.rbCatTodas.Text = "Todas";
            this.rbCatTodas.UseVisualStyleBackColor = true;
            // 
            // rbCatA
            // 
            this.rbCatA.AutoSize = true;
            this.rbCatA.Location = new System.Drawing.Point(67, 19);
            this.rbCatA.Name = "rbCatA";
            this.rbCatA.Size = new System.Drawing.Size(32, 17);
            this.rbCatA.TabIndex = 1;
            this.rbCatA.TabStop = true;
            this.rbCatA.Text = "A";
            this.rbCatA.UseVisualStyleBackColor = true;
            // 
            // rbCatB
            // 
            this.rbCatB.AutoSize = true;
            this.rbCatB.Location = new System.Drawing.Point(105, 20);
            this.rbCatB.Name = "rbCatB";
            this.rbCatB.Size = new System.Drawing.Size(32, 17);
            this.rbCatB.TabIndex = 2;
            this.rbCatB.TabStop = true;
            this.rbCatB.Text = "B";
            this.rbCatB.UseVisualStyleBackColor = true;
            // 
            // rbCatC
            // 
            this.rbCatC.AutoSize = true;
            this.rbCatC.Location = new System.Drawing.Point(143, 20);
            this.rbCatC.Name = "rbCatC";
            this.rbCatC.Size = new System.Drawing.Size(32, 17);
            this.rbCatC.TabIndex = 3;
            this.rbCatC.TabStop = true;
            this.rbCatC.Text = "C";
            this.rbCatC.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DNI,
            this.Nombre,
            this.Telefono,
            this.Categoria});
            this.dataGridView1.Location = new System.Drawing.Point(55, 278);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(511, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoría";
            this.Categoria.Name = "Categoria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(580, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "la idea es usar este control";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(564, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "< clic en la flecha que aparece al seleccionarlo para editar cosas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(631, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "este control es para filtrar por categorías";
            // 
            // FListarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 456);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbCategoria);
            this.Name = "FListarClientes";
            this.Text = "FListarClientes";
            this.gbCategoria.ResumeLayout(false);
            this.gbCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCategoria;
        private System.Windows.Forms.RadioButton rbCatC;
        private System.Windows.Forms.RadioButton rbCatB;
        private System.Windows.Forms.RadioButton rbCatA;
        private System.Windows.Forms.RadioButton rbCatTodas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}