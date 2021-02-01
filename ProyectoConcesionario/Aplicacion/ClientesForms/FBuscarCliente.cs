using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion.ClientesForms
{
    public partial class FBuscarCliente : Form
    {
        /// <summary>
        /// Método que coloca los datos del cliente deseado en los respectivos textBox, que serán solo de lectura.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public FBuscarCliente(Cliente cliente)
        {
            InitializeComponent();
            ucDatos.Enabled = false;
            ucDatos.tbDni.Text = cliente.Dni;
            ucDatos.tbNombre.Text = cliente.Nombre;
            ucDatos.tbTelefono.Text = cliente.Telefono;
            ucDatos.tbApellido.Text = cliente.Apellido;
            if(cliente.Categoria == Categoria.A)
            {
                ucDatos.rbCatA.Checked = true;
            }
            if (cliente.Categoria == Categoria.B)
            {
                ucDatos.rbCatB.Checked = true;
            }
            if (cliente.Categoria == Categoria.C)
            {
                ucDatos.rbCatC.Checked = true;
            }
        }
    }
}
