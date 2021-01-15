using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Presupuesto
    {
        private string id;
        private DateTime fecha;
        private List<LineaPresupuesto> lineas;
        private Estado estadoPr;

        public Presupuesto(string id, DateTime fechaCreacion, List<LineaPresupuesto> lineas, Estado estado)
        {
            this.id = id;
            this.fecha = fechaCreacion;
            this.lineas = lineas;
            this.estadoPr = estado;
        }

        public string Id
        {
            get { return this.id; }
        }

        public DateTime Fecha
        {
            get { return this.fecha; }
        }

        public List<LineaPresupuesto> Lineas
        {
            get { return this.lineas; }
        }

        public Estado EstadoPr
        {
            get { return this.estadoPr; }
            set { this.estadoPr = value; }
        }
    }
}
