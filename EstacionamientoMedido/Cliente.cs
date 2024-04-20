using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamientoMedido
{
    internal class Cliente
    {
        private string nombre;
        private string apellido;
        private string telefono;
        private string correo;

        public Cliente(string nombre, string apellido, string telefono, string correo)
        {
            this.nombre=nombre;
            this.apellido=apellido;
            this.telefono=telefono;
            this.correo=correo;
        }
    }
}
