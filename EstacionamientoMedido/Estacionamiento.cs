using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamientoMedido
{
    internal class Estacionamiento
    {
        private int plaza;
        private DateTime horaEntrada;
        private DateTime horaSalida;

        public Estacionamiento(int plaza, DateTime horaEntrada, DateTime horaSalida)
        {
            this.plaza=plaza;
            this.horaEntrada=horaEntrada;
            this.horaSalida=horaSalida;
        }
    }
}
