﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamientoMedido
{
    internal class PlazaEstacionamiento
    {
        public string Nombre { get; set; }

        public PlazaEstacionamiento(string nombre)
        {
            Nombre=nombre;
        }
    }
}