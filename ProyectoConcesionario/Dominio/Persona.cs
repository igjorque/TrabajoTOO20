using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public abstract class Persona
    {
        private string dni, nombre, telefono;

        public Persona(string dni, string nombre, string telefono)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.telefono = telefono;
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
    }
}
