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
        private List<Cliente> lc;
        public FRecorridoCliente(List<Cliente> lc)
        {
            InitializeComponent();
            this.lc = lc;
            if (lc.Count != 0)
            {
                this.bindingSource1.DataSource = lc;
                this.bindingNavigator1.BindingSource = bindingSource1;
                Cliente c = (Cliente) bindingSource1.Current;
                tbDNI.Text = c.Dni;
                tbApellidos.Text = c.Apellido;
                tbImporte.Text = GestionCliente.getPresupuestos(new ClienteDTO1(c.Dni)).ToString();
                tbNombre.Text = c.Nombre;
            }
            else
            {
                MessageBox.Show("No hay clientes en la BD.");
                this.Close();
            }
            
        }
        /// <summary>
        /// Método de respuesta al evento de cambio de Objeto.
        /// Coloca los datos de el Cliente "actual" en los textBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            Cliente c = (Cliente)bindingSource1.Current;
            if (c != null)
            {
                tbDNI.Text = c.Dni;
                tbApellidos.Text = c.Apellido;
                tbImporte.Text=GestionCliente.getPresupuestos(new Implementacion.ClienteDTO1(c.Dni)).ToString();
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
