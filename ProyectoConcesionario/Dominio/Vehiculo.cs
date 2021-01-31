using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public abstract class Vehiculo : IEquatable<Vehiculo>
    {
        private string bastidor, marca, modelo;
        private int potencia;
        private double precioRec;
        private bool stock; // Campo para indicar si el vehículo está disponible o no.

        public Vehiculo(string bastidor, string marca, string modelo, int potencia, double precioRec, bool stock){
            this.bastidor = bastidor;
            this.marca = marca;
            this.modelo = modelo;
            this.potencia = potencia;
            this.precioRec = precioRec;
            this.stock = stock;
        }
        public string Bastidor   
        {
            get { return this.bastidor; }   
        }

        public string Marca
        {
            get { return this.marca; }
            set { this.marca = value; }
        }

        public string Modelo
        {
            get { return this.modelo; }
            set { this.modelo = value; }
        }

        public int Potencia
        {
            get { return this.potencia; }
            set { this.potencia = value; }
        }

        public double PrecioRec
        {
            get { return this.precioRec; }
            set { this.precioRec = value; }
        }

        public bool Stock
        {
            get { return this.stock; }
            set { this.stock = value; }
        }

        public bool Equals(Vehiculo vh)
        {
            if (vh == null) { return false; }
            if (vh.Bastidor == this.Bastidor) { return true; } else { return false; }
        }

        public abstract double getIVA();
        public abstract Tipo getTipo();
    }
}
