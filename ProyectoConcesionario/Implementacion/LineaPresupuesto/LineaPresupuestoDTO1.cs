using System;
using System.Collections.Generic;
using System.Text;

namespace Implementacion
{
    public class LineaPresupuestoDTO1
    {
        private string idLinea;

        public LineaPresupuestoDTO1(string idlinea)
        {
            this.idLinea = idlinea;
        }

        public string IdLinea
        {
            get { return this.idLinea; }
        }
    }
}
