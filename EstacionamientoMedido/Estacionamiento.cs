using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamientoMedido
{
    internal class Estacionamiento
    {
        public int precioHora;
        public DateTime horaEntrada;
        public DateTime horaSalida;
        public int totalEstacionamiento;
        public Vehiculo VehiculoEstacionado;
        public PlazaEstacionamiento plaza;

        public Estacionamiento(int precioHora, DateTime horaEntrada, DateTime horaSalida, int totalEstacionamiento, Vehiculo vehiculoEstacionado, PlazaEstacionamiento plaza)
        {
            this.precioHora=precioHora;
            this.horaEntrada=horaEntrada;
            this.horaSalida=horaSalida;
            this.totalEstacionamiento=totalEstacionamiento;
            VehiculoEstacionado=vehiculoEstacionado;
            this.plaza=plaza;
        }
    }
}
