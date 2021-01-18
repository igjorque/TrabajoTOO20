using System;
using Persistencia;

namespace Persistencia
{
    public class BD
    {
        private static CollectionClientes coleccionClientes;
        private static CollectionVehiculos coleccionVehiculos;
        private static CollectionPresupuestos coleccionPresupuestos;
        private static CollectionLineasPresupuesto coleccionLineasPresupuesto;
        private BD() { }

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

        public static CollectionLineasPresupuesto ColeccionLineasPresupuesto
        {
            get
            {
                if (coleccionLineasPresupuesto == null)
                {
                    coleccionLineasPresupuesto = new CollectionLineasPresupuesto();
                }
                return coleccionLineasPresupuesto;
            }
        }
    }
}
