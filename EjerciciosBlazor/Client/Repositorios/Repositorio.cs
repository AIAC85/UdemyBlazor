using EjerciciosBlazor.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EjerciciosBlazor.Client.Repositorios
{
    public class Repositorio : IRepositorio
    {

        private readonly HttpClient HttpClient;

        public Repositorio(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public async Task<HttpResponseWrapper<object>> Post<T>(string url, T enviar)
        {
            var enviarJSON = JsonSerializer.Serialize(enviar);
            var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            var responseHttp = await HttpClient.PostAsync(url, enviarContent);
            return new HttpResponseWrapper<object>(null, !responseHttp.IsSuccessStatusCode, responseHttp);
        }

        public List<Pelicula> ObtenerPeliculas()
        {
            return new List<Pelicula>()
            {
                new Pelicula(){ Titulo = "Pelicula001", Lanzamiento = new DateTime(2019,7,2), Poster = "https://m.media-amazon.com/images/M/MV5BMTU2NjA1ODgzMF5BMl5BanBnXkFtZTgwMTM2MTI4MjE@._V1_UX182_CR0,0,182,268_AL_.jpg" },
                new Pelicula(){ Titulo = "Pelicula002", Lanzamiento = new DateTime(2019,7,3), Poster = "https://m.media-amazon.com/images/M/MV5BNzQzOTk3OTAtNDQ0Zi00ZTVkLWI0MTEtMDllZjNkYzNjNTc4L2ltYWdlXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX182_CR0,0,182,268_AL_.jpg"},
                new Pelicula(){ Titulo = "Pelicula003", Lanzamiento = new DateTime(2019,7,4), Poster = "https://m.media-amazon.com/images/M/MV5BMjM0ZDM1YzQtMjlmYy00YThlLTk2MmItNTM3NWRiZmUwYWViXkEyXkFqcGdeQXVyNzg5MzIyOA@@._V1_UY268_CR43,0,182,268_AL_.jpg"}
            };
        }
    }
}
