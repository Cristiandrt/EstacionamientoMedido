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
        PlazaController controladorPlazas = new PlazaController();
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
                var plazasDisponibles = controladorPlazas.ObtenerPlazasDisponibles();
                if(plazasDisponibles.Count == 0)
                {
                    Console.WriteLine("No hay plazas Disponibles.");
                    return;
                }

                Console.WriteLine("Plazas Disponibles: ");
                foreach(var plaza in plazasDisponibles)
                {
                    Console.WriteLine(plaza.Letra);
                }

                Console.Write("Seleccione una plaza para estacionar: ");
                string letraPlaza = Console.ReadLine().ToUpper();

                if (plazasDisponibles.Any(x => x.Letra == letraPlaza))
                {
                    controladorEstacionamiento.IniciarEstacionamiento(patente, letraPlaza);
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine("Estacionamiento Iniciado Correctamente");
                    var estacionamientoActual = controladorEstacionamiento.ObtenerEstacionamientoPorPatente(patente);
                    if (estacionamientoActual != null)
                    {
                        Console.WriteLine($"Hora de Entrada: {estacionamientoActual.horaEntrada}");
                        Console.WriteLine($"Plaza Asignada: {estacionamientoActual.plaza.Letra}");
                        Console.WriteLine($"Vehículo: {estacionamientoActual.VehiculoEstacionado.Marca} {estacionamientoActual.VehiculoEstacionado.Modelo}");
                    }

                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else
                {
                    Console.WriteLine("Plaza seleccionada no válida.");
                }


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
