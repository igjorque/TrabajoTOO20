using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    class Nuevo : Vehiculo
    {
        private List<Extra> extra;
        
        public Nuevo(string bastidor, string marca, string modelo, int potencia, double precioRec, List<Extra> extra) : base(bastidor, marca, modelo, potencia, precioRec)
        {
            this.extra = extra;
        }

        public List<Extra> Extra
        {
            get { return extra; }
            set { extra = value; }
        }

        public override double getIVA()
        {
            return 0.1;
        }
    }
}
