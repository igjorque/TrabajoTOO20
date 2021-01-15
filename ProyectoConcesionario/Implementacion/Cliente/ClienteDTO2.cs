using System;
using System.Collections.Generic;
using System.Text;
using Dominio;

namespace Implementacion.Cliente
{
    public class ClienteDTO2
    {
        private Categoria categ;

        public ClienteDTO2(Categoria cat)
        {
            this.categ = cat;
        }

        public Categoria Categ
        {
            get { return this.categ; }
        }

    }
}
