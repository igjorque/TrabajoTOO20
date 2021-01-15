using System;

namespace Dominio
{
    public class Cliente : Persona
    {
        private Categoria categoria;
        
        public Cliente(string dni, string nombre, string telefono, Categoria categoria) : base(dni, nombre, telefono)
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
    }
}
