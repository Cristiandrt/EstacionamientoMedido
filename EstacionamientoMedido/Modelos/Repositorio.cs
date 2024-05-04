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
                Nombre = "Cristian",
                Apellido = "Duarte",
                DNI = "35752152",
                Telefono = "3482567382",
                Correo = "cristiandrt.17@gmail.com",
            }) ; 

            clientes.Add(new Cliente()
            {
                Nombre = "Betun",
                Apellido = "Duarte",
                DNI = "36013768",
                Telefono = "3482222222",
                Correo = "betunardo@gmail.com",
            }); 
        }

    }
}
