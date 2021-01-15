using System;
using Dominio;
using Implementacion.Cliente;
using System.Collections.Generic;

namespace Negocio
{
    public class GestionCliente
    {
        //PRE: Recibe un cliente
        //POST: devuelve un bool en función de si ha podido añadir un cliente correctamente.
        public bool altaCliente(Cliente c)
        {
            return true;
        }

        //PRE: Recibe un cliente
        //POST: devuelve un bool en función de si ha podido eliminar un cliente correctamente.
        public bool bajaCliente(Cliente c)
        {
            return true;
        }

        //PRE: Recibe un clienteDTO1 (tan solo conocemos su dni)
        //POST: devuelve un Cliente con el dni del CLienteDTO1 introducido.
        public Cliente consultarCliente(ClienteDTO1 c)
        {
            return null;
        }

        //PRE: Recibe un clienteDTO1 (tan solo conocemos su dni).
        //POST: devuelve una lista de sus presupuestos.
        public List<Presupuesto> presupuestosCliente(ClienteDTO1 c)
        {
            return null;
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
            return null;
        }

        //PRE: Recibe un clienteDTO2 (tan solo conocemos su categoría).
        //POST: devuelve una lista de clientes con la categoría del CLienteDTO2 introducido.
        public List<Cliente> clientesCategoria(ClienteDTO2 c)
        {
            return null;
        }
    }
}
