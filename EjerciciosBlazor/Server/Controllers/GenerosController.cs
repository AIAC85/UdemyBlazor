using EjerciciosBlazor.Shared.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjerciciosBlazor.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenerosController : ControllerBase
    {

        private readonly ApplicationDbContext Context;

        public GenerosController(ApplicationDbContext context)
        {
            Context = context;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Genero genero)
        {
            Context.Add(genero);
            await Context.SaveChangesAsync();
            return genero.Id;
        }
    }
}
