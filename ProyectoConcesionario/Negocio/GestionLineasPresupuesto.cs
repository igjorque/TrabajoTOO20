using Dominio;
using Persistencia;
using Implementacion;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio
{
    public class GestionLineasPresupuesto
    {
        public void altaLineaPresupuesto(LineaPresupuesto lp)
        {
            BD.ColeccionLineasPresupuesto.Add(lp);
        }

        public bool bajaLineaPresupuesto(LineaPresupuestoDTO1 lp)
        {
            return BD.ColeccionLineasPresupuesto.Remove(lp.IdLinea);
        }
    }
}
