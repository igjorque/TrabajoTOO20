using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Extra : IEquatable<Extra>
    {
        private string nombre;
        private float precio;

        public Extra(string nombre, float precio) {
            this.nombre = nombre;
            this.precio = precio;
        }

        public string Nombre
        {
            get { return this.nombre; }
        }

        public float Precio
        {
            get { return this.precio; }
            set { precio = value; }
        }

        public bool Equals(Extra ex)
        {
            if (ex == null) { return false; }
            if (ex.Nombre == this.Nombre) { return true; } else { return false; }
        }
    }
}
