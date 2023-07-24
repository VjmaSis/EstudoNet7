using EstudoBlazor.Server.Contexto;
using EstudoBlazor.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace EstudoBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ContextoPrincipal _principal;
        public CategoriaController(ContextoPrincipal principal)
        {
            _principal = principal;
        }

        [HttpGet]
        public async Task<ActionResult<List<Categoria>>> Get()
        {
            return await _principal.Categorias.AsNoTracking().ToListAsync();
        }

        [HttpGet("{id}", Name = "GetCategoria")]
        public async Task<ActionResult<Categoria>> Get(int id)
        {
            return await _principal.Categorias.FirstOrDefaultAsync(c => c.Id == id);
        }

        [HttpPost]
        public async Task<ActionResult<Categoria>> Post(Categoria categoria)
        {
            _principal.Add(categoria);
            await _principal.SaveChangesAsync();
            return new CreatedAtRouteResult("GetCategoria", new  { id = categoria.Id }, categoria);
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<Categoria>> Delete(int id)
        {
            var categoria = await _principal.Categorias.FirstOrDefaultAsync(x => x.Id == id);
            if (categoria != null)
            {
                _principal.Remove(categoria);
                await _principal.SaveChangesAsync();
            }

            return Ok(categoria);
        }

        [HttpPut]
        public async Task<ActionResult> Put(Categoria categoria)
        {
            _principal.Entry(categoria).State = EntityState.Modified;
            await _principal.SaveChangesAsync();
            return Ok();
        }

    }
}
