using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Comercial : Persona
    {
        private string idComercial;

        public Comercial(string dni, string nombre, string telefono, string apellido, string idComercial) : base(dni, nombre, telefono, apellido)
        {
            this.idComercial = idComercial;
        }

        public string IdComercial
        {
            get { return this.idComercial; }
        }
    }
}
