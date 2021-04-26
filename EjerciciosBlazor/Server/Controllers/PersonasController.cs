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
    public class PersonasController : ControllerBase
    {
        private readonly ApplicationDbContext Context;

        public PersonasController(ApplicationDbContext context)
        {
            Context = context;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Persona persona)
        {
            Context.Add(persona);
            await Context.SaveChangesAsync();
            return persona.Id;
        }
    }
}
