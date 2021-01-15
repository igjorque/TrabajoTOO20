using System;
using System.Collections.Generic;
using System.Text;

namespace Implementacion.Presupuesto
{
    public class PresupuestoDTO1
    {
        private string idPres;

        public PresupuestoDTO1(string idpres)
        {
            this.idPres = idpres;
        }

        public string IdPres
        {
            get { return this.idPres; }
        }
    }
}
