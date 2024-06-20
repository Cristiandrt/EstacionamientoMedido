using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamientoMedido.Modelos
{
    public class PlazaEstacionamiento
    {
        public char Letra { get; set; }
        public bool EstaOcupada { get; set; }

        public PlazaEstacionamiento(char letra)
        {
            Letra = letra;
            EstaOcupada = false;
        }
    }
}
