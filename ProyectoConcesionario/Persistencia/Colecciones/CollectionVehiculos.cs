using System;
using System.Collections.ObjectModel;
using System.Text;
using Dominio;

namespace Persistencia
{
    public class CollectionVehiculos : KeyedCollection<string,Vehiculo>
    {
        protected override string GetKeyForItem(Vehiculo item)
        {
            return item.Bastidor;
        }
    }
}
