using System;
using System.Collections.Generic;
using System.Text;

namespace Implementacion
{
    public class ComercialDTO1
    {
        private string idComercial;

        public ComercialDTO1(string idComercial)
        {
            this.idComercial = idComercial;
        }

        public string IdComercial
        {
            get { return this.idComercial; }
        }
    }
}
