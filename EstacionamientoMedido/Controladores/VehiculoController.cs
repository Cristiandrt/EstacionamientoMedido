using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using EstacionamientoMedido.Modelos;
using EstacionamientoMedido.Validaciones;
using FluentValidation.Results;

namespace EstacionamientoMedido.Controladores
{
    public class VehiculoController
    {
        Repositorio repo = Repositorio.ObtenerInstancia(); //Patron Singleton

        public void GuardarVehiculo(Vehiculo v)
        {  
            //validacion con libreria fluentvalidation
            VehiculoValidator valida = new VehiculoValidator();

            ValidationResult resultadoValidacion = valida.Validate(v);

            if (resultadoValidacion.IsValid)
            {
               repo.vehiculos.Add(v);             
            }
            else
            {
                foreach(var item in resultadoValidacion.Errors)
                {
                    Console.WriteLine(item.ErrorMessage);
                }
            }

        }

        public bool ExistePatente(string patente)
        {
            //Version corta 
            //return repo.vehiculos.Any(x => x.patente == patente);

            bool Resultado;

            Resultado = repo.vehiculos.Any(x => x.Patente == patente);

            return Resultado;
        }

        public Vehiculo ObtenerVehiculoPorPatente(string patente)
        {
            //esto es sin usar linQ
            Vehiculo vehiculoBuscado = repo.vehiculos.Where(x => x.Patente == patente).FirstOrDefault();

            return vehiculoBuscado;
        }

        public List<Vehiculo> ObtenerVehiculos()
        {
            return repo.vehiculos;
        }
    }
}
