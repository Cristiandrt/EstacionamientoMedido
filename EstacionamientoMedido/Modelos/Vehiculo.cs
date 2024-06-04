using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamientoMedido.Modelos
{
    public class Vehiculo
    {
        public string Patente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public Cliente Cliente { get; set; }

        public Vehiculo(string patente, string marca, string modelo, string color, Cliente cliente)
        {
            this.Patente = patente;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Color = color;
            Cliente = cliente;
        }

        public Vehiculo()
        {

        }


    }
}
