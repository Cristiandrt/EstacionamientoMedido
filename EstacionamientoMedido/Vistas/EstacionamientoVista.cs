using EstacionamientoMedido.Controladores;
using EstacionamientoMedido.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamientoMedido.Vistas
{
    public class EstacionamientoVista
    {
        VehiculoController controladorVehiculo = new VehiculoController();
        VehiculoVista vistavehiculo = new VehiculoVista();
        EstacionamientoController controladorEstacionamiento = new EstacionamientoController();
        public void IniciarEstacionamiento()
        {
            Console.WriteLine("Ingrese patente para estacionar: ");
            string patente = Console.ReadLine();
            
            if (!controladorVehiculo.ExistePatente(patente))
            {
                Console.WriteLine("Debe Registrar Vehiculo para Estacionar");
                vistavehiculo.CargarDatosVehiculo();
            }

            if (!controladorEstacionamiento.YaEstaEstacionado(patente))
            {
                controladorEstacionamiento.IniciarEstacionamiento(patente);

                Console.WriteLine("Estacionamiento Iniciado Correctamente");
                MostrarDatosEstacionamiento(patente);
            }
            else
            {
                Console.WriteLine("El vehículo ya está estacionado.");
                MostrarDatosEstacionamiento(patente);
            }

        }
        public void FinalizarEstacionamiento()
        {
            //hacer finalizar estacionamiento 
            Console.WriteLine();
            Console.WriteLine("Ingrese patente de salida: ");
            string patente = Console.ReadLine();

            controladorEstacionamiento.FinalizarEstacionamiento(patente);
        }

        public void MostrarDatosEstacionamiento(string patente)
        {
            Estacionamiento estacionamiento = controladorEstacionamiento.ObtenerEstacionamientoPorPatente(patente);

            if (estacionamiento != null) 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("_________________________________\r\n");
                Console.WriteLine($"Vehiculo {estacionamiento.VehiculoEstacionado.Patente} Estacionado:");
                Console.WriteLine($"Hora de Entrada: {estacionamiento.horaEntrada}");
                Console.WriteLine($"Precio por Hora: {estacionamiento.precioHora}");
                Console.WriteLine("_________________________________\r\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                Console.WriteLine("No se encontró registro de estacionamiento para el vehículo.");
            }
        }
        
    }
}
