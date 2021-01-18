using Dominio;
using Implementacion;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio
{
    public class GestionVehiculo
    {
        public void altaVehiculo(Vehiculo v)
        {
            BD.ColeccionVehiculos.Add(v);
        }

        public bool bajaVehiculo(VehiculoDTO1 v)
        {
            return BD.ColeccionVehiculos.Remove(v.Bastidor);
        }

        public Vehiculo consultarVehiculo(VehiculoDTO1 v)
        {
            return BD.ColeccionVehiculos[v.Bastidor];
        }

        public List<Vehiculo> listarVehiculos()
        {
            List<Vehiculo> lista = new List<Vehiculo>();
            foreach (Vehiculo v in BD.ColeccionVehiculos)
            {
                lista.Add(v);
            }
            return lista;
        }

        public List<Vehiculo> listarUsados()
        {
            List<Vehiculo> lista = new List<Vehiculo>();
            foreach (Vehiculo v in BD.ColeccionVehiculos)
            {
                if (v.getTipo() == Tipo.Usado) { lista.Add(v); }
            }
            return lista;
        }

        public List<Vehiculo> listarNuevos()
        {
            List<Vehiculo> lista = new List<Vehiculo>();
            foreach (Vehiculo v in BD.ColeccionVehiculos)
            {
                if (v.getTipo() == Tipo.Nuevo) { lista.Add(v); }
            }
            return lista;
        }
    }
}
