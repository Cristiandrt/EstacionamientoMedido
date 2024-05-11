using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstacionamientoMedido.Modelos;

namespace EstacionamientoMedido.Controladores
{
    public class VehiculoController
    {
        Repositorio repo = Repositorio.ObtenerInstancia();
        public void GuardarVehiculo(Vehiculo v)
        {
            repo.vehiculos.Add(v);
        }

        public bool ExistePatente(string patente)
        {
            //Version corta 
            //return repo.vehiculos.Any(x => x.patente == patente);

            bool Resultado;

            Resultado = repo.vehiculos.Any(x => x.patente == patente);

            return Resultado;
        }

        public Vehiculo ObtenerVehiculoPorPatente(string patente)
        {
            //esto es sin usar linQ
            Vehiculo vehiculoBuscado = repo.vehiculos.Where(x => x.patente == patente).FirstOrDefault();

            return vehiculoBuscado;
        }

    }
}
