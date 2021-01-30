using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Aplicacion.ClientesForms
{
    public partial class FAltaCliente : Form
    {
        private Cliente client;
        public FAltaCliente(string dni)
        {
            InitializeComponent();
            this.ucDatos.btAceptar.Click += new EventHandler(this.CrearCliente);
            this.ucDatos.btCancelar.Click += new EventHandler(this.CancelarOperacion);
            ucDatos.tbDni.Text = dni;
        }
        public Cliente Client
        {
            get
            {
                return this.client;
            }
        }
        public void CrearCliente(object sender, EventArgs e)
        {
            bool valido = false;
            Categoria cat = new Categoria();
            if (this.ucDatos.rbCatA.Checked) { cat = Categoria.A; valido = true; }
            if (this.ucDatos.rbCatB.Checked) { cat = Categoria.B; valido = true; }
            if (this.ucDatos.rbCatC.Checked) { cat = Categoria.C; valido = true; }
            if (this.ucDatos.tbDni.Text == "" || this.ucDatos.tbNombre.Text == "" || this.ucDatos.tbTelefono.Text == "") { valido = false; }
            if (valido == true)
            {
                Cliente c = new Cliente(this.ucDatos.tbDni.Text, this.ucDatos.tbNombre.Text, this.ucDatos.tbTelefono.Text, cat);
                this.client = c;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Debe rellenar todos los campos.");
            }
            
        }

        public void CancelarOperacion(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
