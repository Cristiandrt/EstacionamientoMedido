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

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("► 1 - Iniciar estacionamiento");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("► 2 - Terminar estacionamiento");
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("_________________________________\r\n");
            Console.WriteLine("► 3 - Cargar un cliente");
            Console.WriteLine("► 4 - Ver Clientes Registrados");
            Console.WriteLine("_________________________________\r\n");

            Console.WriteLine("_________________________________\r\n");
            Console.WriteLine("► 5 - Cargar un Vehiculo");
            Console.WriteLine("► 6 - Ver Vehiculos Cargados");
            Console.WriteLine("► 7 - Ver Estacionamientos");
            Console.WriteLine("_________________________________");
            Console.WriteLine("");

            Console.WriteLine("► 8 - Salir");
            Console.WriteLine();
            Console.Write("Opcion: ");
            eleccion = int.Parse(Console.ReadLine());

            switch (eleccion)
            {
                case 3: //cargar un cliente

                    vistacliente.CargarDatosCliente();

                    Console.WriteLine();
                    MostrarMenu();

                    break;

                case 4:

                    vistacliente.MostrarClientesRegistrados();

                    MostrarMenu();
                    break;

                case 5:

                    vistavehiculo.CargarDatosVehiculo();

                    MostrarMenu();
                    break;

                case 6:

                    vistavehiculo.MostrarVehiculosRegistrados();

                    MostrarMenu();
                    break;

                case 8:

                    Environment.Exit(0);
                    break;

                default:
                    Console.Clear();
                    MostrarMenu();
                    break;
            }

        }
    }
}
