﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstacionamientoMedido.Modelos;

namespace EstacionamientoMedido.Controladores
{
    public class EstacionamientoController
    {
        Repositorio repo = Repositorio.ObtenerInstancia();
        VehiculoController controladorVehiculo = new VehiculoController();
        public void GuardarEstacionamiento(Estacionamiento e)
        {
            repo.Estacionamientos.Add(e);
        }

        public void IniciarEstacionamiento(string patente)
        {
            Vehiculo vehiculo = controladorVehiculo.ObtenerVehiculoPorPatente(patente);

            Estacionamiento estacionamiento = new Estacionamiento();

            estacionamiento.horaEntrada=DateTime.Now;
            estacionamiento.VehiculoEstacionado = vehiculo;
            estacionamiento.precioHora = 2000;

            repo.Estacionamientos.Add(estacionamiento);
        }

        public void FinalizarEstacionamiento(string patente)
        {//linQ
            Estacionamiento salida = repo.Estacionamientos
               // .Where(x => x.VehiculoEstacionado.patente == patente)
                .OrderBy(x => x.horaEntrada)
                .Single();//con todo esto toma el primero que existe

            repo.Estacionamientos.Remove(salida);

            salida.horaSalida = DateTime.Now;
            //tarea calculo del precio total
            salida.totalEstacionamiento = 0; //calcular valor total del estacionamiento
            //modifiar el estacionamiento actual

            repo.Estacionamientos.Add(salida);
        }

        public bool YaEstaEstacionado(string petente)
        {
            bool resultado;

            resultado = repo.Estacionamientos
                .Where(x => x.VehiculoEstacionado.Patente == petente)
                .Any();

            return resultado;
        }

        public List<Estacionamiento> ObtenerTodos()
        {
            return repo.Estacionamientos;
        }

    }
}
