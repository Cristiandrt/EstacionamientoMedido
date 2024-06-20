using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamientoMedido.Modelos
{
    public class PlazaEstacionamiento
    {
        public string Letra { get; set; }
        public bool EstaOcupada { get; set; }

        public PlazaEstacionamiento(string letra)
        {
            Letra = letra;
            EstaOcupada = false;
        }
    }
}
