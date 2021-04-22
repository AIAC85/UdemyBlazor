﻿using EjerciciosBlazor.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjerciciosBlazor.Client.Repositorios
{
    public interface IRepositorio
    {
        List<Pelicula> ObtenerPeliculas();
    }
}
