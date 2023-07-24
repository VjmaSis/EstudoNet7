using EstudoBlazor.Server.Contexto;
using EstudoBlazor.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EstudoBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly ContextoPrincipal _principal;

        public ProdutoController(ContextoPrincipal principal)
        {
            _principal = principal;
        }

        [HttpGet]
        public async Task<ActionResult<List<Produto>>> GetProdutos()
        {
            var produtos = await _principal.Produtos.Include(p => p.Categoria).ToListAsync();
            return Ok(produtos);
        }

        [HttpPost]
        public async Task<ActionResult<Produto>> Post(Produto produto)
        {
            await _principal.Produtos.AddAsync(produto);
            await _principal.SaveChangesAsync();
            return Ok(produto);
        }

    }
}
