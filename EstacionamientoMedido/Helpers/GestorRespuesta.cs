using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamientoMedido.Helpers
{
    public class GestorRespuesta<T> //generico T como universal
    {
        public T respuesta;
        public bool HayError;
        public string MensajeError;
    }
}
