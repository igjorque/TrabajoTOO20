using Dominio;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Persistencia
{
    public class CollectionLineasPresupuesto : KeyedCollection<string, LineaPresupuesto>
    {
        protected override string GetKeyForItem(LineaPresupuesto item)
        {
            return (item.IdLinea);
        }
    }
}
