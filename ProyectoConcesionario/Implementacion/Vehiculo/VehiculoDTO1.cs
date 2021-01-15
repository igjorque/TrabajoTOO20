using System;
using System.Collections.Generic;
using System.Text;

namespace Implementacion.Vehiculo
{
    public class VehiculoDTO1
    {
        private string bastidor;

        public VehiculoDTO1(string bastidor)
        {
            this.bastidor = bastidor;
        }
        
        public string Bastidor
        {
            get { return this.bastidor; }
        }
    }
}
