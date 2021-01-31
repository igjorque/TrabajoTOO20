using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Comercial : Persona
    {
        private string idComercial;

        //PRE: Recibe un los datos necesarios.
        //POST: Crea un Comercial con los datos recibidos.
        public Comercial(string dni, string nombre, string telefono, string apellido, string idComercial) : base(dni, nombre, telefono, apellido)
        {
            this.idComercial = idComercial;
        }

        //PRE: 
        //POST: Devuelve el ID.
        public string IdComercial
        {
            get { return this.idComercial; }
        }
    }
}
