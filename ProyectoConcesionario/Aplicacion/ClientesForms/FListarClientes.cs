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
    // El objetivo de este formulario es mostrar todos los clientes del concesionario, y para tener toda la
    // funcionalidad solicitada, establecer un filtro (listar todos o listar por categoría)

    public partial class FListarClientes : Form
    {
        public FListarClientes()
        {
            InitializeComponent();
            rbCatTodas.Click += new EventHandler(cambioCheck);
        }
        public void cambioCheck(object sender, EventArgs e)
        {
            gridClientes.Rows.Clear();
            List<Cliente> lista = GestionCliente.listarClientes();
            int n;
            foreach(Cliente c in lista)
            {
                n=gridClientes.Rows.Add();
                gridClientes.Rows[n].Cells[0].Value = c.Dni;
                gridClientes.Rows[n].Cells[1].Value = c.Nombre;
                gridClientes.Rows[n].Cells[2].Value = c.Telefono;
                gridClientes.Rows[n].Cells[3].Value = c.Categoria;
            }
        }

        private void rbCatA_Click(object sender, EventArgs e)
        {
            gridClientes.Rows.Clear();
            List<Cliente> lista = GestionCliente.clientesCategoria(new Implementacion.ClienteDTO2(Dominio.Categoria.A));
            int n;
            foreach (Cliente c in lista)
            {
                n = gridClientes.Rows.Add();
                gridClientes.Rows[n].Cells[0].Value = c.Dni;
                gridClientes.Rows[n].Cells[1].Value = c.Nombre;
                gridClientes.Rows[n].Cells[2].Value = c.Telefono;
                gridClientes.Rows[n].Cells[3].Value = c.Categoria;
            }
        }

        private void rbCatB_Click(object sender, EventArgs e)
        {
            gridClientes.Rows.Clear();
            List<Cliente> lista = GestionCliente.clientesCategoria(new Implementacion.ClienteDTO2(Dominio.Categoria.B));
            int n;
            foreach (Cliente c in lista)
            {
                n = gridClientes.Rows.Add();
                gridClientes.Rows[n].Cells[0].Value = c.Dni;
                gridClientes.Rows[n].Cells[1].Value = c.Nombre;
                gridClientes.Rows[n].Cells[2].Value = c.Telefono;
                gridClientes.Rows[n].Cells[3].Value = c.Categoria;
            }
        }

        private void rbCatC_Click(object sender, EventArgs e)
        {
            gridClientes.Rows.Clear();
            List<Cliente> lista = GestionCliente.clientesCategoria(new Implementacion.ClienteDTO2(Dominio.Categoria.C));
            int n;
            foreach (Cliente c in lista)
            {
                n = gridClientes.Rows.Add();
                gridClientes.Rows[n].Cells[0].Value = c.Dni;
                gridClientes.Rows[n].Cells[1].Value = c.Nombre;
                gridClientes.Rows[n].Cells[2].Value = c.Telefono;
                gridClientes.Rows[n].Cells[3].Value = c.Categoria;
            }
        }
    }
}
