using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public abstract class Persona : IEquatable<Persona>
    {
        private string dni, nombre, telefono, apellido;

        //PRE: Recibe un los datos necesarios.
        //POST: Crea una Persona con los datos recibidos.
        public Persona(string dni, string nombre, string telefono, string apellido)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.telefono = telefono;
            this.apellido = apellido;
        }
        //PRE: 
        //POST: Devuelve el Apellido.
        public string Apellido
        {
            get { return this.apellido; }
        }
        //PRE: 
        //POST: Devuelve el Dni.
        public string Dni
        {
            get { return dni; }
        }
        //PRE: 
        //POST: Devuelve el Telefono.
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        //PRE: 
        //POST: Devuelve el Nombre.
        public string Nombre
        {
            get { return nombre; }
        }
        //PRE: Introduce un objeto de tipo Persona.
        //POST: Devuelve true si se trata de la misma persona.
        public bool Equals(Persona pe)
        {
            if (pe == null) { return false; }
            if (pe.Dni == this.Dni) { return true; } else { return false; }
        }
    }
}
