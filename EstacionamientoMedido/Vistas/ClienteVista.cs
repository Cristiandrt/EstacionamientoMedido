using EstacionamientoMedido.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstacionamientoMedido.Controladores;
using EstacionamientoMedido.Vistas;

namespace EstacionamientoMedido.Vistas
{
    public class ClienteVista
    {
        ClienteController controladorClientes = new ClienteController();
        public void CargarDatosCliente()
        {        
            Cliente clientenuevo = new Cliente(); //instanciamos el cliente para cargar datos

            Console.Write("Nombre: ");
            clientenuevo.Nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            clientenuevo.Apellido = Console.ReadLine();
            Console.Write("DNI: ");
            clientenuevo.DNI = Console.ReadLine();
            Console.Write("Telefono: ");
            clientenuevo.Telefono = Console.ReadLine();
            Console.Write("Email: ");
            clientenuevo.Correo = Console.ReadLine();

            controladorClientes.GuardarCliente(clientenuevo);
        }

        public void MostrarClientesRegistrados()
        {
            List<Cliente> listadoClientes = controladorClientes.ObtenerClientes();

            Console.WriteLine("Listado de clientes cargados en el sistema");

            foreach (var item in listadoClientes)
            {
                Console.WriteLine($">Nombre: {item.Nombre} {item.Apellido} -DNI: {item.DNI} -Tel: {item.Telefono} -Email: {item.Correo}");
            }
        }
    }
}
