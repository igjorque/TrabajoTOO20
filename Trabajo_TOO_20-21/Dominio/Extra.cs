using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    class Extra
    {
        private string nombre;
        private float precio;

        public Extra(string nombre, float precio) {
            this.nombre = nombre;
            this.precio = precio;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }
    }
}
