using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstacionamientoMedido.Enumeraciones;

namespace EstacionamientoMedido.Modelos
{
    public class Estacionamiento
    {
        public int precioHora { get; set; }
        public DateTime horaEntrada { get; set; }
        public DateTime horaSalida { get; set; }
        public int totalEstacionamiento { get; set; }
        public Vehiculo VehiculoEstacionado { get; set; }
        public PlazaEstacionamiento plaza { get; set; }
        public EstadoEstacionamiento estado { get; set; }

        public Estacionamiento(int precioHora, DateTime horaEntrada, DateTime horaSalida, int totalEstacionamiento, Vehiculo vehiculoEstacionado, PlazaEstacionamiento plaza)
        {
            this.precioHora = precioHora;
            this.horaEntrada = horaEntrada;
            this.horaSalida = horaSalida;
            this.totalEstacionamiento = totalEstacionamiento;
            VehiculoEstacionado = vehiculoEstacionado;
            this.plaza = plaza;
            this.estado = EstadoEstacionamiento.Activo;
        }

        public Estacionamiento()
        {

        }
    }
}
