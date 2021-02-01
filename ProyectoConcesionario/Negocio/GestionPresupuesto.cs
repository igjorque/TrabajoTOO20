using Dominio;
using Implementacion;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio
{
    public static class GestionPresupuesto
    {
        /// <summary>
        /// Alta de un nuevo presupuesto en la BD
        /// </summary>
        /// <param name="p">Objeto Presupuesto a añadir.</param>
        public static void altaPresupuesto(Presupuesto p)
        {
            BD.ColeccionPresupuestos.Add(p);
        }

        /// <summary>
        /// Obtiene el cliente asociado a un presupuesto, a partir de la clave del presupuesto.
        /// </summary>
        /// <param name="p">Clave del presupuesto.</param>
        /// <returns>Cliente asociado al presupuesto.</returns>
        public static Cliente clientePresupuesto(PresupuestoDTO1 p)
        {
            return BD.ColeccionPresupuestos[p.IdPres].Client;
        }

        /// <summary>
        /// Obtiene el estado del presupuesto a partir de su clave.
        /// </summary>
        /// <param name="p">Clave del presupuesto.</param>
        /// <returns>Estado del presupuesto.</returns>
        public static Estado estadoPresupuesto(PresupuestoDTO1 p)
        {
            return BD.ColeccionPresupuestos[p.IdPres].EstadoPr;
        }

        /*
        public static Vehiculo presupuestoAceptado_(PresupuestoDTO1 p)
        {
            if (estadoPresupuesto(p) == Estado.Aceptado) 
            { 
                foreach (LineaPresupuesto lp in BD.ColeccionPresupuestos[p.IdPres].Lineas)
                {
                    if(lp.EstadoLinea == Estado.Aceptado)
                    {
                        return lp.VehiculoPr;
                    }
                }
            }
            return null;
        }
        */

        /// <summary>
        /// Obtiene los datos de un presupuesto a partir de su clave.
        /// </summary>
        /// <param name="p">Clave del presupuesto.</param>
        /// <returns>Objeto Presupuesto, o NULL si no existe en la BD.</returns>
        public static Presupuesto consultarPresupuesto(PresupuestoDTO1 p)
        {
            if (BD.ColeccionPresupuestos.Contains(p.IdPres))
            {
                return BD.ColeccionPresupuestos[p.IdPres];
            }
            else
            {
                return null;
            }
            
        }

        /// <summary>
        /// Obtiene todos los presupuestos asociados a un cliente a partir de la clave de éste.
        /// </summary>
        /// <param name="c">Clave del cliente.</param>
        /// <returns>Listado de presupuestos del cliente. Puede ser vacío.</returns>
        public static List<Presupuesto> presupuestosCliente(ClienteDTO1 c)
        {
            List<Presupuesto> lista = new List<Presupuesto>();
            Cliente cli = null;
            if (GestionCliente.existeCliente(c))
            {
                cli = GestionCliente.consultarCliente(c);
                foreach (Presupuesto p in BD.ColeccionPresupuestos)
                {
                    if (p.Client.Equals(cli))
                    {
                        lista.Add(p);
                    }
                }
            }
            return lista;
        }

        /*
        public static List<Presupuesto> presupuestosComercial(ComercialDTO1 c)
        {
            List<Presupuesto> lista = new List<Presupuesto>();
            foreach (Presupuesto p in BD.ColeccionPresupuestos)
            {
                if (p.Comerc.Dni == c.IdComercial)
                {
                    lista.Add(p);
                }
            }
            return lista;
        }
        */
        /// <summary>
        /// Obtiene un listado de presupuestos para un determinado vehículo, a partir de la clave de éste.
        /// </summary>
        /// <param name="v">Clave del vehículo.</param>
        /// <returns>Listado de presupuestos. Puede ser vacío.</returns>
        public static List<Presupuesto> presupuestosVehiculo(VehiculoDTO1 v)
        {
            List<Presupuesto> lista = new List<Presupuesto>();
            foreach (Presupuesto p in BD.ColeccionPresupuestos)
            {
                foreach(LineaPresupuesto lp in p.Lineas)
                {
                    if(lp.VehiculoPr.Bastidor == v.Bastidor)
                    {
                        lista.Add(p);
                    }
                }
            }
            return lista;
        }

        /// <summary>
        /// Obtiene un listado de todos los presupuestos con un determinado estado.
        /// </summary>
        /// <param name="e">Estado de los presupuestos.</param>
        /// <returns>Listado de todos los presupuestos con el estado 'e'. Puede ser vacío.</returns>
        public static List<Presupuesto> presupuestosEstado(Estado e)
        {
            List<Presupuesto> lista = new List<Presupuesto>();
            foreach (Presupuesto p in BD.ColeccionPresupuestos)
            {
                if (p.EstadoPr == e)
                {
                    lista.Add(p);
                }
            }
            return lista;
        }
        /// <summary>
        /// Obtiene un listado de todos los presupuestos.
        /// </summary>
        /// <returns>Lista de todos los presupuestos. Puede ser vacío.</returns>
        public static List<Presupuesto> listarPresupuestos()
        {
            List<Presupuesto> lista = new List<Presupuesto>();
            foreach (Presupuesto p in BD.ColeccionPresupuestos)
            {
                lista.Add(p);
            }
            return lista;
        }
    }
}
