using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Comercial : Persona
    {
        private string idComercial;

        public Comercial(string dni, string nombre, string telefono, string idComercial) : base(dni, nombre, telefono)
        {
            this.idComercial = idComercial;
        }

        public string IdComercial
        {
            get { return this.idComercial; }
        }
    }
}
