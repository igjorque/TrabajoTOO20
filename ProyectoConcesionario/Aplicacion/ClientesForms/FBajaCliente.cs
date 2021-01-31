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
    public partial class FBajaCliente : Form
    {
        private Cliente client;
        public FBajaCliente(Cliente cliente)
        {
            InitializeComponent();
            this.client = cliente;
            ucDatos.tbDni.Enabled = false;
            ucDatos.tbNombre.Enabled = false;
            ucDatos.tbTelefono.Enabled = false;
            ucDatos.tbApellido.Enabled = false;
            ucDatos.rbCatA.Enabled = false;
            ucDatos.rbCatB.Enabled = false;
            ucDatos.rbCatC.Enabled = false;
            ucDatos.tbDni.Text = cliente.Dni;
            ucDatos.tbNombre.Text = cliente.Nombre;
            ucDatos.tbTelefono.Text = cliente.Telefono;
            ucDatos.tbApellido.Text = cliente.Apellido;
            if (cliente.Categoria == Categoria.A)
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
            ucDatos.btAceptar.Click += new EventHandler(this.EliminarCliente);
            this.ucDatos.btCancelar.Click += new EventHandler(this.CancelarOperacion);
        }
        public Cliente Client
        {
            get
            {
                return this.client;
            }
        }
        public void EliminarCliente(object sender, EventArgs e)
        {
            DialogResult dr=MessageBox.Show("¿Está seguro de que quiere dar de baja a este Cliente?", "¿Está usted seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            this.DialogResult = dr;
        }

        public void CancelarOperacion(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
