using System;
using Persistencia;

namespace Persistencia
{
    public class BD
    {
        private static CollectionClientes coleccionClientes;
        private static CollectionVehiculos coleccionVehiculos;
        private static CollectionPresupuestos coleccionPresupuestos;
        private BD() { }

        /// <summary>
        /// Devuelve la colección de clientes existente, o una nueva en caso de no existir.
        /// </summary>
        public static CollectionClientes ColeccionClientes
        {
            get
            {
                if (coleccionClientes == null)
                {
                    coleccionClientes = new CollectionClientes();
                }
                return coleccionClientes;
            }
        }

        /// <summary>
        /// Devuelve la colección de vehículos existente, o una nueva en caso de no existir.
        /// </summary>
        public static CollectionVehiculos ColeccionVehiculos
        {
            get
            {
                if (coleccionVehiculos == null)
                {
                    coleccionVehiculos = new CollectionVehiculos();
                }
                return coleccionVehiculos;
            }
        }

        /// <summary>
        /// Devuelve la colección de presupuestos existente, o una nueva en caso de no existir.
        /// </summary>
        public static CollectionPresupuestos ColeccionPresupuestos
        {
            get
            {
                if (coleccionPresupuestos == null)
                {
                    coleccionPresupuestos = new CollectionPresupuestos();
                }
                return coleccionPresupuestos;
            }
        }
    }
}
