using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Usado : Vehiculo
    {
        private string matricula;
        private DateTime fechaMatricula;

        public Usado(string bastidor, string marca, string modelo, int potencia, double precioRec, bool stock, string matricula, DateTime fecha) : base(bastidor, marca, modelo, potencia, precioRec, stock)
        {
            this.matricula = matricula;
            this.fechaMatricula = fecha;
        }

        public string Matricula {
            get { return this.matricula; }
            set { this.matricula = value; }
        }
        public DateTime FechaMatricula
        {
            get { return this.fechaMatricula; }
            set { this.fechaMatricula = value; }
        }

        public override double getIVA()
        {
            return 0.21;
        }
        public override Tipo getTipo()
        {
            return Tipo.Usado;
        }
    }
}
