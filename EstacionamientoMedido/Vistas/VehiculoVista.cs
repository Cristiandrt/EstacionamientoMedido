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
         public Vehiculo CargarDatosVehiculo()
        {
            Vehiculo vehiculonuevo = new Vehiculo();

            Console.Write("Patente: ");
            vehiculonuevo.patente = Console.ReadLine();
            Console.Write("Marca: ");
            vehiculonuevo.marca = Console.ReadLine();
            Console.Write("Modelo: ");
            vehiculonuevo.modelo = Console.ReadLine();
            Console.Write("Color: ");
            vehiculonuevo.color = Console.ReadLine();
            //como cargo el cliente?

            return vehiculonuevo;
        }


    }
}
