using Dominio;
using Implementacion;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio
{
    public static class GestionVehiculo
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        public static void altaVehiculo(Vehiculo v)
        {
            BD.ColeccionVehiculos.Add(v);
        }

        /// <summary>
        /// Baja lógica de un vehículo. Establece stock como false (no disponible).
        /// </summary>
        /// <param name="v">Vehículo a modificar</param>
        /// <returns>TRUE si se ha modificado, FALSE en caso contrario.</returns>
        public static bool bajaVehiculo(VehiculoDTO1 v)
        {
            if (BD.ColeccionVehiculos.Contains(v.Bastidor))
            {
                Vehiculo vaux = BD.ColeccionVehiculos[v.Bastidor];
                BD.ColeccionVehiculos.Remove(v.Bastidor);
                vaux.Stock = false;
                BD.ColeccionVehiculos.Add(vaux);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static Vehiculo consultarVehiculo(VehiculoDTO1 v)
        {
            if (BD.ColeccionVehiculos.Contains(v.Bastidor))
            {
                Vehiculo vaux = BD.ColeccionVehiculos[v.Bastidor];
                return vaux;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static bool existeVehiculo(VehiculoDTO1 v)
        {
            return BD.ColeccionVehiculos.Contains(v.Bastidor);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<Vehiculo> listarVehiculos()
        {
            List<Vehiculo> lista = new List<Vehiculo>();
            foreach (Vehiculo v in BD.ColeccionVehiculos)
            {
                lista.Add(v);
            }
            return lista;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<Vehiculo> listarUsados()
        {
            List<Vehiculo> lista = new List<Vehiculo>();
            foreach (Vehiculo v in BD.ColeccionVehiculos)
            {
                if (v.getTipo() == Tipo.Usado) { lista.Add(v); }
            }
            return lista;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<Vehiculo> listarNuevos()
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
