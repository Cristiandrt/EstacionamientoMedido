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
        EstacionamientoController estacionamiento = new EstacionamientoController();
        public void IniciarEstacionamiento()
        {
            Console.WriteLine("Ingrese patente para estacionar: ");
            string patente = Console.ReadLine();
            //pregunto si el vehiculo por patente existe
            if (!controladorVehiculo.ExistePatente(patente))
            {
                vistavehiculo.CargarDatosVehiculo();
            }
            
            if (!estacionamiento.YaEstaEstacionado(patente))
            {
                estacionamiento.IniciarEstacionamiento(patente);
            }
            else
            {
                Console.WriteLine("vehiculo creado");
            }

        }
        public void FinalizarEstacionamiento()
        {
            //hacer finalizar estacionamiento 
            Console.WriteLine();
            Console.WriteLine("Ingrese patente de salida: ");
            string patente = Console.ReadLine();

            estacionamiento.FinalizarEstacionamiento(patente);
        }
    }
}
