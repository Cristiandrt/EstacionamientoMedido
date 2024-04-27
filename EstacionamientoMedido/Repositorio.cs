using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamientoMedido
{
    public class Repositorio
    {
        //reservorios para guardar todos los objetos creados
        public List<Cliente> clientes = new List<Cliente>();
        public List<Vehiculo> vehiculos = new List<Vehiculo>();
        public List<PlazaEstacionamiento> estacionamientos = new List<PlazaEstacionamiento>();

    }
}
