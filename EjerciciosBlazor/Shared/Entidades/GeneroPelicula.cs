using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosBlazor.Shared.Entidades
{
    public class GeneroPelicula
    {
        public int PeliculaId { get; set; }
        public int Generoid { get; set; }
        public Genero Genero { get; set; }
        public Pelicula Pelicula { get; set; }
    }
}
