using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Nuevo : Vehiculo
    {
        private List<Extra> extra;
        
        public Nuevo(string bastidor, string marca, string modelo, int potencia, double precioRec, bool stock, List<Extra> extra) : base(bastidor, marca, modelo, potencia, precioRec, stock)
        {
            this.extra = extra;
        }

        public List<Extra> Extra
        {
            get { return this.extra; }
            set { extra = value; }
        }

        public override double getIVA()
        {
            return 0.1;
        }
        public override Tipo getTipo()
        {
            return Tipo.Nuevo;
        }
    }
}
