using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstacionamientoMedido.Modelos;

namespace EstacionamientoMedido.Controladores
{
    public class EstacionamientoController
    {
        Repositorio repo = new Repositorio();

        public void GuardarEstacionamiento(Estacionamiento e)
        {
            repo.Estacionamiento.Add(e);
        }

    }
}
