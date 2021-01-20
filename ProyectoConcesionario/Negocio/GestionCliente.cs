using System;
using Dominio;
using Implementacion;
using System.Collections.Generic;
using Persistencia;

namespace Negocio
{
    public class GestionCliente
    {
        //PRE: Recibe un cliente
        //POST: devuelve un bool en función de si ha podido añadir un cliente correctamente.
        public bool altaCliente(Cliente c)
        {
            BD.ColeccionClientes.Add(c);
            if (this.consultarCliente(new ClienteDTO1(c.Dni)) != null)
            {
                return true;
            }
            else {
                return false;
            }
            
        }

        //PRE: Recibe un cliente
        //POST: devuelve un bool en función de si ha podido eliminar un cliente correctamente.
        public bool bajaCliente(Cliente c)
        {
            return BD.ColeccionClientes.Remove(c);
        }

        //PRE: Recibe un clienteDTO1 (tan solo conocemos su dni)
        //POST: devuelve un Cliente con el dni del CLienteDTO1 introducido.
        public Cliente consultarCliente(ClienteDTO1 c)
        {
            return BD.ColeccionClientes[c.Dni];
        }

        //PRE: Recibe un clienteDTO1 (tan solo conocemos su dni).
        //POST: devuelve una lista de sus presupuestos.
        public List<Presupuesto> presupuestosCliente(ClienteDTO1 c)
        {
            List<Presupuesto> presupuestos = new List<Presupuesto>();
            foreach (Presupuesto p in BD.ColeccionPresupuestos)
            {
                if (p.Client.Dni.Equals(c.Dni))
                {
                    presupuestos.Add(p);
                }
            }
            return presupuestos;
        }

        //PRE: Recibe un clienteDTO1 (tan solo conocemos su dni).
        //POST: ??
        public List<Presupuesto> comprasCliente()
        {
            return null;
        }

        //PRE:
        //POST: devuelve una lista de los clientes dados de alta.
        public List<Cliente> listarClientes()
        {
            List<Cliente> lista = new List<Cliente>();
            foreach (Cliente c in BD.ColeccionClientes)
            {
                lista.Add(c);
            }
            return lista;
        }

        //PRE: Recibe un clienteDTO2 (tan solo conocemos su categoría).
        //POST: devuelve una lista de clientes con la categoría del CLienteDTO2 introducido.
        public List<Cliente> clientesCategoria(ClienteDTO2 c)
        {
            List<Cliente> lista = new List<Cliente>();
            foreach (Cliente cliente in BD.ColeccionClientes)
            {
                if (c.Categ == cliente.Categoria)
                {
                    lista.Add(cliente);
                }
            }
            return lista;

        }
    }
}
