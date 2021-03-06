﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Aplicacion.ClientesForms
{
    public partial class FBuscarClienteOtro : Form
    {
        /// <summary>
        /// Coloca todos los DNIs conocidos en el comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public FBuscarClienteOtro()
        {
            InitializeComponent();
            foreach(Cliente c in GestionCliente.listarClientes())
            {
                this.comboBox1.Items.Add(c.Dni);
            }
        }
        /// <summary>
        /// Coloca todos los datos del cliente con el DNI elegido en el comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            Cliente c = GestionCliente.consultarCliente(new Implementacion.ClienteDTO1(comboBox1.SelectedItem.ToString()));
            tbNombre.Text = c.Nombre;
            tbApellidos.Text = c.Apellido;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
