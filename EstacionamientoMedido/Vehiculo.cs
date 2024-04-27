using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamientoMedido
{
    internal class Vehiculo
    {
        public string patente;
        public string marca;
        public string modelo;
        public string color;
        public Cliente Cliente;

        public Vehiculo(string patente, string marca, string modelo, string color, Cliente cliente)
        {
            this.patente=patente;
            this.marca=marca;
            this.modelo=modelo;
            this.color=color;
            Cliente=cliente;
        }
    }
}
