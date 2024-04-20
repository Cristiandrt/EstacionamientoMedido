using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamientoMedido
{
    internal class Vehiculo
    {
        private string patente;
        private string marca;
        private string modelo;
        private string color;

        public Vehiculo(string patente, string marca, string modelo, string color)
        {
            this.patente=patente;
            this.marca=marca;
            this.modelo=modelo;
            this.color=color;
        }
    }
}
