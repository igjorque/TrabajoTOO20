using System;
using Dominio;
using Implementacion;
using System.Collections.Generic;
using Persistencia;

namespace Negocio
{
    public static class GestionCliente
    {
        //PRE: Recibe un cliente
        //POST: devuelve un bool en función de si ha podido añadir un cliente correctamente.
        public static bool altaCliente(Cliente c)
        {
            BD.ColeccionClientes.Add(c);
            if (consultarCliente(new ClienteDTO1(c.Dni)) != null)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        //PRE: Recibe un cliente
        //POST: devuelve un bool en función de si ha podido eliminar un cliente correctamente.
        public static bool bajaCliente(Cliente c)
        {
            return BD.ColeccionClientes.Remove(c);
        }
        //PRE: Recibe un clienteDTO1 (tan solo conocemos su dni)
        //POST: devuelve true si dicho cliente está en la BD.
        public static bool existeCliente(ClienteDTO1 c) {
            return BD.ColeccionClientes.Contains(c.Dni);
        }
        //PRE: Recibe un clienteDTO1 (tan solo conocemos su dni)
        //POST: devuelve un Cliente con el dni del CLienteDTO1 introducido.
        public static Cliente consultarCliente(ClienteDTO1 c)
        {
            if (existeCliente(c))
            {
                return BD.ColeccionClientes[c.Dni];
            }
            else
            {
                return null;
            }
            
        }

        //PRE: Recibe un clienteDTO1 (tan solo conocemos su dni).
        //POST: devuelve una lista de sus presupuestos.
        public static List<Presupuesto> presupuestosCliente(ClienteDTO1 c)
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
        public static List<Presupuesto> comprasCliente()
        {
            return null;
        }

        //PRE:
        //POST: devuelve una lista de los clientes dados de alta.
        public static List<Cliente> listarClientes()
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
        public static List<Cliente> clientesCategoria(ClienteDTO2 c)
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

        //PRE: Recibe un clienteDTO1 (tan solo conocemos su DNI).
        //POST: devuelve la cantidad del importe de este cliente.
        public static double getPresupuestos(ClienteDTO1 c)
        {
            double sum = 0;
            List<LineaPresupuesto> llp = null;
            List<Presupuesto> lp = null;
            if ((lp = GestionPresupuesto.presupuestosCliente(c)) != null) // controlo que el cliente tenga presupuestos. Si los tiene...
            {
                foreach (Presupuesto p in lp)
                {
                    llp = p.Lineas;
                    foreach (LineaPresupuesto pp in llp)
                    {
                        if (pp.EstadoLinea == Estado.Aceptado) // tomo únicamente los valores de las líneas que estén aceptadas, el resto están rechazadas o pendientes
                        {
                            sum = sum + pp.Precio;
                        }
                    }
                }
            }
            return sum;
        }
    }
}
