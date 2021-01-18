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

        public Vehiculo(string bastidor, string marca, string modelo, int potencia, double precioRec){
            this.bastidor = bastidor;
            this.marca = marca;
            this.modelo = modelo;
            this.potencia = potencia;
            this.precioRec = precioRec;
        }
        public string Bastidor   
        {
            get { return bastidor; }   
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public int Potencia
        {
            get { return potencia; }
            set { potencia = value; }
        }

        public double PrecioRec
        {
            get { return precioRec; }
            set { precioRec = value; }
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
