using System;

namespace Dominio
{
    public class Cliente : Persona
    {
        private Categoria categoria;

        //PRE: Recibe un los datos necesarios.
        //POST: Crea un Cliente con los datos recibidos.
        public Cliente(string dni, string nombre, string telefono, string apellido, Categoria categoria) : base(dni, nombre, telefono,apellido)
        {
            this.categoria = categoria;
        }
        //PRE: 
        //POST: Devuelve la Categoria.
        public Categoria Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        //PRE: 
        //POST: Devuelve el Descuento asociado al cliente.
        public double getDescuento()
        {
            return ((double)categoria) / 100.0;
        }
        //PRE: Dos clientes diferentes.
        //POST: devuelve un entero que indica su posición relativa en el criterio de ordenación según el DNI.
        public static int ComparaDNI(Cliente c1, Cliente c2)
        {
            return String.Compare(c1.Dni, c2.Dni);
        }
        //PRE: Dos clientes diferentes.
        //POST: devuelve un entero que indica su posición relativa en el criterio de ordenación según el Nombre.
        public static int ComparaNombre(Cliente c1, Cliente c2)
        {
            return String.Compare(c1.Nombre, c2.Nombre);
        }
    }
}
