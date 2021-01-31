using Dominio;
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
    public partial class FListadoOrdenado : Form
    {
        public FListadoOrdenado()
        {
            InitializeComponent();
        }

        private void btnDNI_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            this.listBox2.Items.Clear();
            this.listBox3.Items.Clear();
            List<Cliente> lord = GestionCliente.listarClientes();
            lord.Sort(Cliente.ComparaDNI);
            foreach(Cliente c in lord)
            {
                
                listBox1.Items.Add(c.Dni);
                listBox2.Items.Add(c.Apellido+", "+c.Nombre);
                listBox3.Items.Add(GestionCliente.getPresupuestos(new Implementacion.ClienteDTO1(c.Dni)));
            }
        }

        private void btnNombre_Click(object sender, EventArgs e)
        {

            this.listBox1.Items.Clear();
            this.listBox2.Items.Clear();
            this.listBox3.Items.Clear();
            List<Cliente> lord = GestionCliente.listarClientes();
            lord.Sort(Cliente.ComparaNombre);
            foreach (Cliente c in lord)
            {
                listBox1.Items.Add(c.Dni);
                listBox2.Items.Add(c.Apellido + ", " + c.Nombre);
                listBox3.Items.Add(GestionCliente.getPresupuestos(new Implementacion.ClienteDTO1(c.Dni)));
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static int ComparaPresupuestos(Cliente c1, Cliente c2)
        {
            return GestionCliente.getPresupuestos(new Implementacion.ClienteDTO1(c1.Dni)).CompareTo( GestionCliente.getPresupuestos(new Implementacion.ClienteDTO1(c2.Dni)));
        }

        private void btnImporte_Click(object sender, EventArgs e)
        {


                this.listBox1.Items.Clear();
                this.listBox2.Items.Clear();
                this.listBox3.Items.Clear();
                List<Cliente> lord = GestionCliente.listarClientes();
                lord.Sort(ComparaPresupuestos);
                foreach (Cliente c in lord)
                {
                    listBox1.Items.Add(c.Dni);
                    listBox2.Items.Add(c.Apellido + ", " + c.Nombre);
                    listBox3.Items.Add(GestionCliente.getPresupuestos(new Implementacion.ClienteDTO1(c.Dni)));
                }
                    }
    }
}
