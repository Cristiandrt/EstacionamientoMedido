using EstacionamientoMedido.Controladores;
using EstacionamientoMedido.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EstacionamientoMedido.Vistas
{
    public class VehiculoVista
    {
        VehiculoController controladorVehiculos = new VehiculoController();
        public void CargarDatosVehiculo()
        {
            Vehiculo vehiculonuevo = new Vehiculo();

            Console.Write("Patente: ");
            vehiculonuevo.Patente = Console.ReadLine();
            Console.Write("Marca: ");
            vehiculonuevo.Marca = Console.ReadLine();
            Console.Write("Modelo: ");
            vehiculonuevo.Modelo = Console.ReadLine();
            Console.Write("Color: ");
            vehiculonuevo.Color = Console.ReadLine();

            controladorVehiculos.GuardarVehiculo(vehiculonuevo);
        }

        public void MostrarVehiculosRegistrados()
        {
            List<Vehiculo> vehiculos = controladorVehiculos.ObtenerVehiculos();

            Console.WriteLine("lista de Vehiculos Registrados en el sistema");

            foreach (var item in vehiculos)
            {
                Console.WriteLine($" Patente: {item.Patente} - Marca: {item.Marca} - Modelo {item.Modelo} - Color: {item.Color}");
            }
        }
    }
}
