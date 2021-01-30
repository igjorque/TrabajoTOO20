namespace Aplicacion
{
    partial class FPrincipal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAltaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBajaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsConsultarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsListarClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.vehículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAltaVehiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBajaVehiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsConsultarVehiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsListarVehiculos = new System.Windows.Forms.ToolStripMenuItem();
            this.presupuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAltaPresupuesto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsConsultarPresupuesto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsListarPresupuestos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsClientes,
            this.vehículosToolStripMenuItem,
            this.presupuestosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsClientes
            // 
            this.tsClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAltaCliente,
            this.tsBajaCliente,
            this.tsConsultarCliente,
            this.tsListarClientes});
            this.tsClientes.Name = "tsClientes";
            this.tsClientes.Size = new System.Drawing.Size(75, 24);
            this.tsClientes.Text = "Clientes";
            // 
            // tsAltaCliente
            // 
            this.tsAltaCliente.Name = "tsAltaCliente";
            this.tsAltaCliente.Size = new System.Drawing.Size(224, 26);
            this.tsAltaCliente.Text = "Alta Cliente";
            this.tsAltaCliente.Click += new System.EventHandler(this.tsAltaCliente_Click);
            // 
            // tsBajaCliente
            // 
            this.tsBajaCliente.Name = "tsBajaCliente";
            this.tsBajaCliente.Size = new System.Drawing.Size(224, 26);
            this.tsBajaCliente.Text = "Baja Cliente";
            this.tsBajaCliente.Click += new System.EventHandler(this.tsBajaCliente_Click);
            // 
            // tsConsultarCliente
            // 
            this.tsConsultarCliente.Name = "tsConsultarCliente";
            this.tsConsultarCliente.Size = new System.Drawing.Size(224, 26);
            this.tsConsultarCliente.Text = "Consultar Cliente";
            this.tsConsultarCliente.Click += new System.EventHandler(this.tsConsultarCliente_Click);
            // 
            // tsListarClientes
            // 
            this.tsListarClientes.Name = "tsListarClientes";
            this.tsListarClientes.Size = new System.Drawing.Size(224, 26);
            this.tsListarClientes.Text = "Listar Clientes";
            this.tsListarClientes.Click += new System.EventHandler(this.tsListarClientes_Click);
            // 
            // vehículosToolStripMenuItem
            // 
            this.vehículosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAltaVehiculo,
            this.tsBajaVehiculo,
            this.tsConsultarVehiculo,
            this.tsListarVehiculos});
            this.vehículosToolStripMenuItem.Name = "vehículosToolStripMenuItem";
            this.vehículosToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.vehículosToolStripMenuItem.Text = "Vehículos";
            // 
            // tsAltaVehiculo
            // 
            this.tsAltaVehiculo.Name = "tsAltaVehiculo";
            this.tsAltaVehiculo.Size = new System.Drawing.Size(214, 26);
            this.tsAltaVehiculo.Text = "Alta Vehículo";
            this.tsAltaVehiculo.Click += new System.EventHandler(this.tsAltaVehiculo_Click);
            // 
            // tsBajaVehiculo
            // 
            this.tsBajaVehiculo.Name = "tsBajaVehiculo";
            this.tsBajaVehiculo.Size = new System.Drawing.Size(214, 26);
            this.tsBajaVehiculo.Text = "Baja Vehículo";
            this.tsBajaVehiculo.Click += new System.EventHandler(this.tsBajaVehiculo_Click);
            // 
            // tsConsultarVehiculo
            // 
            this.tsConsultarVehiculo.Name = "tsConsultarVehiculo";
            this.tsConsultarVehiculo.Size = new System.Drawing.Size(214, 26);
            this.tsConsultarVehiculo.Text = "Consultar Vehículo";
            this.tsConsultarVehiculo.Click += new System.EventHandler(this.tsConsultarVehiculo_Click);
            // 
            // tsListarVehiculos
            // 
            this.tsListarVehiculos.Name = "tsListarVehiculos";
            this.tsListarVehiculos.Size = new System.Drawing.Size(214, 26);
            this.tsListarVehiculos.Text = "Listar Vehículos";
            this.tsListarVehiculos.Click += new System.EventHandler(this.tsListarVehiculos_Click);
            // 
            // presupuestosToolStripMenuItem
            // 
            this.presupuestosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAltaPresupuesto,
            this.tsConsultarPresupuesto,
            this.tsListarPresupuestos});
            this.presupuestosToolStripMenuItem.Name = "presupuestosToolStripMenuItem";
            this.presupuestosToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.presupuestosToolStripMenuItem.Text = "Presupuestos";
            // 
            // tsAltaPresupuesto
            // 
            this.tsAltaPresupuesto.Name = "tsAltaPresupuesto";
            this.tsAltaPresupuesto.Size = new System.Drawing.Size(238, 26);
            this.tsAltaPresupuesto.Text = "Alta Presupuesto";
            // 
            // tsConsultarPresupuesto
            // 
            this.tsConsultarPresupuesto.Name = "tsConsultarPresupuesto";
            this.tsConsultarPresupuesto.Size = new System.Drawing.Size(238, 26);
            this.tsConsultarPresupuesto.Text = "Consultar Presupuesto";
            // 
            // tsListarPresupuestos
            // 
            this.tsListarPresupuestos.Name = "tsListarPresupuestos";
            this.tsListarPresupuestos.Size = new System.Drawing.Size(238, 26);
            this.tsListarPresupuestos.Text = "Listar Presupuestos";
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FPrincipal";
            this.Text = "Gestión Concesionario";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsClientes;
        private System.Windows.Forms.ToolStripMenuItem tsAltaCliente;
        private System.Windows.Forms.ToolStripMenuItem tsBajaCliente;
        private System.Windows.Forms.ToolStripMenuItem tsConsultarCliente;
        private System.Windows.Forms.ToolStripMenuItem vehículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsAltaVehiculo;
        private System.Windows.Forms.ToolStripMenuItem tsBajaVehiculo;
        private System.Windows.Forms.ToolStripMenuItem presupuestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsAltaPresupuesto;
        private System.Windows.Forms.ToolStripMenuItem tsConsultarPresupuesto;
        private System.Windows.Forms.ToolStripMenuItem tsListarPresupuestos;
        private System.Windows.Forms.ToolStripMenuItem tsListarClientes;
        private System.Windows.Forms.ToolStripMenuItem tsConsultarVehiculo;
        private System.Windows.Forms.ToolStripMenuItem tsListarVehiculos;
    }
}

