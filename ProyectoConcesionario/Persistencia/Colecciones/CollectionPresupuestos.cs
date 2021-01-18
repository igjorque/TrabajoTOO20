using System;
using System.Collections.ObjectModel;
using System.Text;
using Dominio;

namespace Persistencia
{
    public class CollectionPresupuestos : KeyedCollection<string, Presupuesto>
    {
        protected override string GetKeyForItem(Presupuesto item)
        {
            return item.Id;
        }
    }
}
