using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public abstract class Persona : IEquatable<Persona>
    {
        private string dni, nombre, telefono, apellido;

        public Persona(string dni, string nombre, string telefono, string apellido)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.telefono = telefono;
            this.apellido = apellido;
        }
        public string Apellido
        {
            get { return this.apellido; }
        }
        public string Dni
        {
            get { return dni; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Nombre
        {
            get { return nombre; }
        }

        public bool Equals(Persona pe)
        {
            if (pe == null) { return false; }
            if (pe.Dni == this.Dni) { return true; } else { return false; }
        }
    }
}
