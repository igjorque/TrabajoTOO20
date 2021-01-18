using System;
using System.Collections.ObjectModel;
using System.Text;
using Dominio;

namespace Persistencia
{
    public class CollectionClientes : KeyedCollection<string,Cliente>
    {
        protected override string GetKeyForItem(Cliente item)
        {
            return item.Dni;
        }
    }
}
