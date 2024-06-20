using EstacionamientoMedido.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamientoMedido.Controladores
{
    public class PlazaController
    {
        Repositorio repo = Repositorio.ObtenerInstancia();

        public List<PlazaEstacionamiento> ObtenerPlazasDisponibles()
        {
            return repo.PlazaEstacionamiento
                .Where(x => !x.EstaOcupada).ToList();
        }

        public void OcuparPlaza(string letra)
        {
            PlazaEstacionamiento plaza = repo.PlazaEstacionamiento.FirstOrDefault(x => x.Letra == letra);

            if(plaza != null)
            {
                plaza.EstaOcupada = true;
            }
        }

        public void LiberarPlaza(string letra)
        {
            PlazaEstacionamiento plaza = repo.PlazaEstacionamiento.FirstOrDefault(x => x.Letra == letra);

            if (plaza != null)
            {
                plaza.EstaOcupada = false;
            }
        }

    }
}
