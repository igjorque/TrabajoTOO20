using Dominio;
using Implementacion;
using Negocio;
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
    public partial class FRecorridoCliente : Form
    {
        public FRecorridoCliente()
        {
            InitializeComponent();
            List<Cliente> list = GestionCliente.listarClientes();
            if (list.Count != 0)
            {
                this.bindingSource1.DataSource = list;
                this.bindingNavigator1.BindingSource = bindingSource1;
                Cliente c = (Cliente)bindingSource1.Current;
                tbDNI.Text = c.Dni;
                tbApellidos.Text = c.Apellido;
                //tbImporte.Text=
                tbNombre.Text = c.Nombre;
            }
            else
            {
                MessageBox.Show("No hay clientes en la BD.");
                this.Close();
            }
            
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            Cliente c = (Cliente)bindingSource1.Current;
            if (c != null)
            {
                tbDNI.Text = c.Dni;
                tbApellidos.Text = c.Apellido;
                //tbImporte.Text=
                tbNombre.Text = c.Nombre;
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
