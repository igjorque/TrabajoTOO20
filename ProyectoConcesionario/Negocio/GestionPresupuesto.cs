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
        public static void altaPresupuesto(Presupuesto p)
        {
            BD.ColeccionPresupuestos.Add(p);
        }

        public static Cliente clientePresupuesto(PresupuestoDTO1 p)
        {
            return BD.ColeccionPresupuestos[p.IdPres].Client;
        }

        public static Estado estadoPresupuesto(PresupuestoDTO1 p)
        {
            return BD.ColeccionPresupuestos[p.IdPres].EstadoPr;
        }

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

        public static List<Presupuesto> presupuestosCliente(ClienteDTO1 c)
        {
            List<Presupuesto> lista = null;
            Cliente cli = null;
            if (GestionCliente.existeCliente(c))
            {
                cli = GestionCliente.consultarCliente(c);
                lista = new List<Presupuesto>();
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
