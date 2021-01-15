using System;

namespace Implementacion
{
    public class ClienteDTO1
    {
        private string dni;

        public ClienteDTO1(string dni)
        {
            this.dni = dni;
        }

        public string Dni
        {
            get { return this.dni; }
        }
    }
}
