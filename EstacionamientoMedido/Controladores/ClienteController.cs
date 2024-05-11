using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstacionamientoMedido.Modelos;
using EstacionamientoMedido.Helpers;
using EstacionamientoMedido.Vistas;

namespace EstacionamientoMedido.Controladores
{
    public class ClienteController
    {
        Repositorio repo = Repositorio.ObtenerInstancia();
  
        public void GuardarCliente(Cliente c)
        {
            repo.clientes.Add(c);

            //tarea crear controladores que faltan para cliente para estacionamiento y apra repositorio
        }

        public List<Cliente> ObtenerClientes()
        {
            return repo.clientes;
        }

        public Cliente Modificar(Cliente c)
        {
            Cliente clienteAEliminar = repo.clientes.Find(x => x.DNI == c.DNI); //funcion Find para buscar cliente

            repo.clientes.Remove(clienteAEliminar);

            repo.clientes.Add(c);

            return c;

        }

        public void Eliminar(Cliente c)
        {
            Cliente clienteAEliminar = repo.clientes.Find(x => x.DNI == c.DNI);

            repo.clientes.Remove(clienteAEliminar);

        }
        //Metodo para obtener un cliente por dni utilizando un gestor de respuesta
        public GestorRespuesta<Cliente> ObtenerClientePorDNI(string dni)
        {
            Cliente clienteBuscado = repo.clientes.Find(x => x.DNI == dni);

            if (clienteBuscado == null)
            {
                return new GestorRespuesta<Cliente>()
                {
                    HayError = true,
                    MensajeError = "No se encuentra cliente con ese DNI"
                };
            }
            else
            {
                return new GestorRespuesta<Cliente>()
                {
                    HayError = false,
                    respuesta = clienteBuscado,
                };
            }
        }

        public GestorRespuesta<List<Cliente>> ObtenerClientesPorApellido(string filtro)
        {

            List<Cliente> busqueda = repo.clientes
                .Where(x => filtro.Contains(filtro))
                .ToList();

            if (busqueda == null)
            {
                return new GestorRespuesta<List<Cliente>>()
                {
                    HayError = true,
                    MensajeError = "No se encuentra el cliente"
                };
            }
            else
            {
                return new GestorRespuesta<List<Cliente>>() { respuesta = busqueda };
            }
            //TAREA CONPLETAR LOS CONTROLADORES PARA LA PLAZA DE ESTACIONAMIENTO Y LOS VEHICULOS, FILTRAR VEHICULO CON PATENTE SI EXISTE LO BUSCO SI NO EXISTE LO REGISTRO
        }

    }
}
