using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Presupuesto : IEquatable<Presupuesto>
    {
        private string idPresu;
        private Cliente client;
        //private Comercial comerc;
        private DateTime fecha;
        private List<LineaPresupuesto> lineas;
        private Estado estadoPr;

        public Presupuesto(string id, Cliente cl, /*Comercial co,*/ DateTime fechaCreacion, List<LineaPresupuesto> lineas, Estado estado)
        {
            this.idPresu = id;
            this.client = cl;
            //this.comerc = co;
            this.fecha = fechaCreacion;
            this.lineas = lineas;
            this.estadoPr = estado;
        }

        public string Id
        {
            get { return this.idPresu; }
        }

        public Cliente Client
        {
            get { return this.client; }
        }
        /*
        public Comercial Comerc
        {
            get { return this.comerc; }
        }
        */
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

        public bool Equals(Presupuesto pr)
        {
            if (pr == null) { return false; }
            if (pr.Id == this.Id) { return true; } else { return false; }
        }
    }
}
