using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamientoMedido.Modelos
{
    //patron de sisenio SINGLETONE
    /*Reglas a aplicar
        1- Constructor privado
        2-Metodo para obtener instancia
        2.1 -> Si no existe la crea, si existe devuelve la misma
        3-> El metodo y la instancia tiene que ser esattico*/
    public class Repositorio
    {  
        //reservorios para guardar todos los objetos creados
        public List<Cliente> clientes = new List<Cliente>();
        public List<Vehiculo> vehiculos = new List<Vehiculo>();
        public List<PlazaEstacionamiento> PlazaEstacionamiento = new List<PlazaEstacionamiento>();
        public List<Estacionamiento> Estacionamientos = new List<Estacionamiento>();

        private static Repositorio instancia;

        private Repositorio()
        {
            PrecargarDatos();
        }

        private void PrecargarDatos()
        {
            //CLIENTES
            clientes.Add(new Cliente()
            {
                Nombre = "Cristian",
                Apellido = "Duarte",
                DNI = "35752152",
                Telefono = "3482567382",
                Correo = "cristiandrt.17@gmail.com",
            });

            clientes.Add(new Cliente()
            {
                Nombre = "Betun",
                Apellido = "Duarte",
                DNI = "36013768",
                Telefono = "3482222222",
                Correo = "betunardo@gmail.com",
            });

            //VEHÍCULOS
            vehiculos.Add(new Vehiculo() { 
                Patente = "AAA 111",
                Marca = "VolksWagen",
                Modelo = "2016",
                Color = "Rojo",
                });

            vehiculos.Add(new Vehiculo()
            {
                Patente = "GHK 666",
                Marca = "VolksWagen",
                Modelo = "2017",
                Color = "Azul",
            });

            PlazaEstacionamiento.Add(new PlazaEstacionamiento("A"));
            PlazaEstacionamiento.Add(new PlazaEstacionamiento("B"));
            PlazaEstacionamiento.Add(new PlazaEstacionamiento("C"));
            PlazaEstacionamiento.Add(new PlazaEstacionamiento("D"));
            PlazaEstacionamiento.Add(new PlazaEstacionamiento("E"));
        }

        public static Repositorio ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new Repositorio();
                return instancia;
            }
            else
            {
                return instancia;
            }
        }
    }
}
