using Dominio;
using Persistencia;
using Implementacion;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio
{
    public static class GestionLineasPresupuesto
    {
        public static void altaLineaPresupuesto(LineaPresupuesto lp)
        {
            BD.ColeccionLineasPresupuesto.Add(lp);
        }

        public static bool bajaLineaPresupuesto(LineaPresupuestoDTO1 lp)
        {
            return BD.ColeccionLineasPresupuesto.Remove(lp.IdLinea);
        }
    }
}
