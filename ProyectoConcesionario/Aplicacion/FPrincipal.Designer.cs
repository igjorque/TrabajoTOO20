﻿namespace Aplicacion
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
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tsClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAltaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBajaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsConsultarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsListarClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsVehiculos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAltaVehiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBajaVehiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsConsultarVehiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsListarVehiculos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPresupuestos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAltaPresupuesto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsConsultarPresupuesto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsListarPresupuestos = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsClientes,
            this.tsVehiculos,
            this.tsPresupuestos});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.msMenu.Size = new System.Drawing.Size(800, 24);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // tsClientes
            // 
            this.tsClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAltaCliente,
            this.tsBajaCliente,
            this.tsConsultarCliente,
            this.tsListarClientes});
            this.tsClientes.Name = "tsClientes";
            this.tsClientes.Size = new System.Drawing.Size(61, 20);
            this.tsClientes.Text = "Clientes";
            // 
            // tsAltaCliente
            // 
            this.tsAltaCliente.Name = "tsAltaCliente";
            this.tsAltaCliente.Size = new System.Drawing.Size(180, 22);
            this.tsAltaCliente.Text = "Alta Cliente";
            this.tsAltaCliente.Click += new System.EventHandler(this.tsAltaCliente_Click);
            // 
            // tsBajaCliente
            // 
            this.tsBajaCliente.Name = "tsBajaCliente";
            this.tsBajaCliente.Size = new System.Drawing.Size(180, 22);
            this.tsBajaCliente.Text = "Baja Cliente";
            this.tsBajaCliente.Click += new System.EventHandler(this.tsBajaCliente_Click);
            // 
            // tsConsultarCliente
            // 
            this.tsConsultarCliente.Name = "tsConsultarCliente";
            this.tsConsultarCliente.Size = new System.Drawing.Size(180, 22);
            this.tsConsultarCliente.Text = "Consultar Cliente";
            this.tsConsultarCliente.Click += new System.EventHandler(this.tsConsultarCliente_Click);
            // 
            // tsListarClientes
            // 
            this.tsListarClientes.Name = "tsListarClientes";
            this.tsListarClientes.Size = new System.Drawing.Size(180, 22);
            this.tsListarClientes.Text = "Listar Clientes";
            this.tsListarClientes.Click += new System.EventHandler(this.tsListarClientes_Click);
            // 
            // tsVehiculos
            // 
            this.tsVehiculos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAltaVehiculo,
            this.tsBajaVehiculo,
            this.tsConsultarVehiculo,
            this.tsListarVehiculos});
            this.tsVehiculos.Name = "tsVehiculos";
            this.tsVehiculos.Size = new System.Drawing.Size(69, 20);
            this.tsVehiculos.Text = "Vehículos";
            // 
            // tsAltaVehiculo
            // 
            this.tsAltaVehiculo.Name = "tsAltaVehiculo";
            this.tsAltaVehiculo.Size = new System.Drawing.Size(180, 22);
            this.tsAltaVehiculo.Text = "Alta Vehículo";
            this.tsAltaVehiculo.Click += new System.EventHandler(this.tsAltaVehiculo_Click);
            // 
            // tsBajaVehiculo
            // 
            this.tsBajaVehiculo.Name = "tsBajaVehiculo";
            this.tsBajaVehiculo.Size = new System.Drawing.Size(180, 22);
            this.tsBajaVehiculo.Text = "Baja Vehículo";
            this.tsBajaVehiculo.Click += new System.EventHandler(this.tsBajaVehiculo_Click);
            // 
            // tsConsultarVehiculo
            // 
            this.tsConsultarVehiculo.Name = "tsConsultarVehiculo";
            this.tsConsultarVehiculo.Size = new System.Drawing.Size(180, 22);
            this.tsConsultarVehiculo.Text = "Consultar Vehículo";
            this.tsConsultarVehiculo.Click += new System.EventHandler(this.tsConsultarVehiculo_Click);
            // 
            // tsListarVehiculos
            // 
            this.tsListarVehiculos.Name = "tsListarVehiculos";
            this.tsListarVehiculos.Size = new System.Drawing.Size(180, 22);
            this.tsListarVehiculos.Text = "Listar Vehículos";
            this.tsListarVehiculos.Click += new System.EventHandler(this.tsListarVehiculos_Click);
            // 
            // tsPresupuestos
            // 
            this.tsPresupuestos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAltaPresupuesto,
            this.tsConsultarPresupuesto,
            this.tsListarPresupuestos});
            this.tsPresupuestos.Name = "tsPresupuestos";
            this.tsPresupuestos.Size = new System.Drawing.Size(89, 20);
            this.tsPresupuestos.Text = "Presupuestos";
            // 
            // tsAltaPresupuesto
            // 
            this.tsAltaPresupuesto.Name = "tsAltaPresupuesto";
            this.tsAltaPresupuesto.Size = new System.Drawing.Size(193, 22);
            this.tsAltaPresupuesto.Text = "Alta Presupuesto";
            // 
            // tsConsultarPresupuesto
            // 
            this.tsConsultarPresupuesto.Name = "tsConsultarPresupuesto";
            this.tsConsultarPresupuesto.Size = new System.Drawing.Size(193, 22);
            this.tsConsultarPresupuesto.Text = "Consultar Presupuesto";
            // 
            // tsListarPresupuestos
            // 
            this.tsListarPresupuestos.Name = "tsListarPresupuestos";
            this.tsListarPresupuestos.Size = new System.Drawing.Size(193, 22);
            this.tsListarPresupuestos.Text = "Listar Presupuestos";
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msMenu);
            this.MainMenuStrip = this.msMenu;
            this.Name = "FPrincipal";
            this.Text = "Gestión Concesionario";
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem tsClientes;
        private System.Windows.Forms.ToolStripMenuItem tsAltaCliente;
        private System.Windows.Forms.ToolStripMenuItem tsBajaCliente;
        private System.Windows.Forms.ToolStripMenuItem tsConsultarCliente;
        private System.Windows.Forms.ToolStripMenuItem tsVehiculos;
        private System.Windows.Forms.ToolStripMenuItem tsAltaVehiculo;
        private System.Windows.Forms.ToolStripMenuItem tsBajaVehiculo;
        private System.Windows.Forms.ToolStripMenuItem tsPresupuestos;
        private System.Windows.Forms.ToolStripMenuItem tsAltaPresupuesto;
        private System.Windows.Forms.ToolStripMenuItem tsConsultarPresupuesto;
        private System.Windows.Forms.ToolStripMenuItem tsListarPresupuestos;
        private System.Windows.Forms.ToolStripMenuItem tsListarClientes;
        private System.Windows.Forms.ToolStripMenuItem tsConsultarVehiculo;
        private System.Windows.Forms.ToolStripMenuItem tsListarVehiculos;
    }
}

