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
        /// Alta de un nuevo vehículo en la BD.
        /// </summary>
        /// <param name="v">Objeto vehículo a almacenar.</param>
        public static void altaVehiculo(Vehiculo v)
        {
            BD.ColeccionVehiculos.Add(v);
        }

        /// <summary>
        /// Baja lógica de un vehículo. Establece stock como false (no disponible).
        /// </summary>
        /// <param name="v">Vehículo a modificar.</param>
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
        /// Obtiene los datos de un vehículo a partir de su clave.
        /// </summary>
        /// <param name="v">Clave del vehículo.</param>
        /// <returns>Objeto Vehículo en caso de existir, NULL en caso contrario.</returns>
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
        /// Comprueba si existe un vehículo a partir de su clave.
        /// </summary>
        /// <param name="v">Clave del vehículo.</param>
        /// <returns>TRUE si existe, FALSE en caso contrario.</returns>
        public static bool existeVehiculo(VehiculoDTO1 v)
        {
            return BD.ColeccionVehiculos.Contains(v.Bastidor);
        }

        /// <summary>
        /// Obtiene una lista de todos los vehículos almacenados que puede ser vacía.
        /// </summary>
        /// <returns>Lista de todos los vehículos almacenados. Puede ser una lista vacía.</returns>
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
        /// Obtiene una lista de todos los vehículos de tipo Usado, que puede ser vacía.
        /// </summary>
        /// <returns>Lista de todos los vehículos Usados. Puede ser una lista vacía.</returns>
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
        /// Obtiene una lista de todos los vehículos de tipo Nuevo, que puede ser vacía.
        /// </summary>
        /// <returns>Lista de todos los vehículos Nuevos. Puede ser una lista vacía.</returns>
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
