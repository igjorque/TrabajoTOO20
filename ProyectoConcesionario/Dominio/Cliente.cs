using System;

namespace Dominio
{
    public class Cliente : Persona
    {
        private Categoria categoria;
        
        public Cliente(string dni, string nombre, string telefono, string apellido, Categoria categoria) : base(dni, nombre, telefono,apellido)
        {
            this.categoria = categoria;
        }
        public Categoria Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public  double getDescuento()
        {
            return ((double)categoria) / 100.0;
        }

        public static int ComparaDNI(Cliente c1, Cliente c2)
        {
            return String.Compare(c1.Dni, c2.Dni);
        }
        public static int ComparaNombre(Cliente c1, Cliente c2)
        {
            return String.Compare(c1.Nombre, c2.Nombre);
        }
    }
}
