using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class LineaPresupuesto
    {
        private string idPresupuesto;
        private string idLinea;
        private Vehiculo vehiculoPr;
        private float precio;
        private Estado estadoLinea;

        public LineaPresupuesto(string idPresupuesto, string idLinea, Vehiculo vehiculo, float precio, Estado est)
        {
            this.idPresupuesto = idPresupuesto;
            this.idLinea = idLinea;
            this.vehiculoPr = vehiculo;
            this.precio = precio;
            this.estadoLinea = est;
        }

        public string IdPresupuesto
        {
            get { return this.idPresupuesto; }
        }

        public string IdLinea
        {
            get { return this.idLinea; }
        }

        public Vehiculo VehiculoPr
        {
            get { return this.vehiculoPr; }
            set { this.vehiculoPr = value; }
        }

        public float Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }

        public Estado EstadoLinea
        {
            get { return this.estadoLinea; }
            set { this.estadoLinea = value; }
        }
    }
}
