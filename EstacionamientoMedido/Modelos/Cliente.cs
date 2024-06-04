using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamientoMedido.Modelos
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        public Cliente(string nombre, string apellido, string DNI, string telefono, string correo)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.DNI = DNI;
            this.Telefono = telefono;
            this.Correo = correo;
        }
        public Cliente()
        {

        }
    }
}
