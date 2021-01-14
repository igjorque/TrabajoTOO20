using System;

namespace Dominio
{
    public class Cliente
    {
        private string dni, telefono, nombre;
        private Categoria categoria;
        
        public Cliente(string dni, string nombre, string telefono, Categoria categoria)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.telefono = telefono;
            this.categoria = categoria;
        }
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
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
