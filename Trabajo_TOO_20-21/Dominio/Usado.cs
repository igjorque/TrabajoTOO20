using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    class Usado : Vehiculo
    {
        private string matricula;

        public Usado(string bastidor, string marca, string modelo, int potencia, double precioRec, string matricula) : base(bastidor, marca, modelo, potencia, precioRec)
        {
            this.matricula = matricula;
        }

        public string Matricula {
            get { return matricula; }
            set { matricula = value; }
        }
        public override double getIVA()
        {
            return 0.21;
        }
    }
}
