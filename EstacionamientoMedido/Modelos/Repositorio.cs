using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamientoMedido.Modelos
{
    public class Repositorio
    {
        //reservorios para guardar todos los objetos creados
        public List<Cliente> clientes = new List<Cliente>();
        public List<Vehiculo> vehiculos = new List<Vehiculo>();
        public List<PlazaEstacionamiento> PlazaEstacionamiento = new List<PlazaEstacionamiento>();
        public List<Estacionamiento> Estacionamiento = new List<Estacionamiento>();

        public Repositorio()
        {
            clientes.Add(new Cliente()
            {
                nombre = "Cristian",
                apellido = "Duarte",
                telefono = "3482567382",
                correo = "cristiandrt.17@gmail.com",
            });

            clientes.Add(new Cliente()
            {
                nombre = "Betun",
                apellido = "Duarte",
                telefono = "3482222222",
                correo = "betunardo@gmail.com",
            });
        }












    }
}
