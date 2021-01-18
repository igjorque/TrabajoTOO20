using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class LineaPresupuesto : IEquatable<LineaPresupuesto>
    {
        private string idLinea;
        private Vehiculo vehiculoPr;
        private float precio;
        private Estado estadoLinea;

        public LineaPresupuesto(string idLinea, Vehiculo vehiculo, float precio, Estado est)
        {
            this.idLinea = idLinea;
            this.vehiculoPr = vehiculo;
            this.precio = precio;
            this.estadoLinea = est;
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

        public bool Equals(LineaPresupuesto lp)
        {
            if (lp == null) { return false; }
            if (lp.IdLinea == this.IdLinea) { return true; } else { return false; }
        }
    }
}
