using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamientoMedido.Modelos
{
    public class Vehiculo
    {
        public string patente { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string color { get; set; }
        public Cliente Cliente { get; set; }

        public Vehiculo(string patente, string marca, string modelo, string color, Cliente cliente)
        {
            this.patente = patente;
            this.marca = marca;
            this.modelo = modelo;
            this.color = color;
            Cliente = cliente;
        }

        public Vehiculo()
        {

        }


    }
}
