using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamientoMedido
{
    internal class Cliente
    {
        public string nombre;
        public string apellido;
        public string telefono;
        public string correo;
        

        public Cliente(string nombre, string apellido, string telefono, string correo)
        {
            this.nombre=nombre;
            this.apellido=apellido;
            this.telefono=telefono;
            this.correo=correo;
        }
    }
}
