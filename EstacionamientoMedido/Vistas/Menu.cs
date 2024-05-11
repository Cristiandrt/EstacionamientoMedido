using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstacionamientoMedido.Controladores;
using EstacionamientoMedido.Modelos;
using EstacionamientoMedido.Vistas;

namespace EstacionamientoMedido.Vistas
{
    public class Menu
    {
        ClienteVista vistacliente = new ClienteVista();
        VehiculoVista vistavehiculo = new VehiculoVista();
        EstacionamientoVista vistaestacionamiento = new EstacionamientoVista();
        public void MostrarMenu()
        {

            int eleccion;

            Console.WriteLine("1 - Cargar un cliente");
            Console.WriteLine("2 - Ver Clientes Registrados");
            Console.WriteLine("3 - Cargar un Vehiculo");
            Console.WriteLine("4 - Cargar un Estacionamiento");
            Console.WriteLine();
            Console.Write("Opcion: ");
            eleccion = int.Parse(Console.ReadLine());

            switch (eleccion)
            {
                case 1: //cargar un cliente


                    vistacliente.CargarDatosCliente();

                    Console.WriteLine();
                    MostrarMenu();

                    break;

                case 2:

                    vistacliente.MostrarClientesRegistrados();

                    MostrarMenu();
                    break;

                case 3:

                    vistavehiculo.CargarDatosVehiculo();

                    MostrarMenu();
                    break;

                //    Console.WriteLine();
                //    break;
                case 4:


                    break;
                default:
                    Console.Clear();
                    MostrarMenu();
                    break;
            }

        }
    }
}
