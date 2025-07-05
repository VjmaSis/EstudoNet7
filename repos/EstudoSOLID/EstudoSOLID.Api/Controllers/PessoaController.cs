using EstudoSOLID.Servico.Dtos;
using EstudoSOLID.Servico.Servico;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace EstudoSOLID.Api.Controllers
{
    /// <summary>
    /// Reponsavel por controlar pessoa
    /// </summary>
    /// <param name="pessoaService"></param>
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController(IPessoaService pessoaService) : ControllerBase
    {
        private readonly IPessoaService _pessoaService = pessoaService;

        /// <summary>
        /// Responsavel por buscar todas as pessoas
        /// </summary>
        /// <returns>Lista de pessoas</returns>
        [HttpGet]
        [ProducesResponseType<List<PessoaDto>>((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public async Task<ActionResult<List<PessoaDto>>> Get()
        {
            var pessoas = await _pessoaService.GetAllAsync();

            return Ok(pessoas);
        }
    }
}
