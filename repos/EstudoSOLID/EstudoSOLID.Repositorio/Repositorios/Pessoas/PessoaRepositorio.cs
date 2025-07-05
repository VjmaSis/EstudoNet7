using EstudoSOLID.Dominio.Entidades;
using EstudoSOLID.Infraestrutura.Contexto;
using EstudoSOLID.Repositorio.Contratos.Base;
using EstudoSOLID.Repositorio.Contratos.Pessoas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoSOLID.Repositorio.Repositorios.Pessoas
{
    public class PessoaRepositorio(ProjetoContexto contexto)
                : IAdicionarRepositorio<Pessoa>, IAtualizarRepositorio<Pessoa>,
        IBuscarPorIdRepositorio<Pessoa>, IDeletarRepositorio,
        IBuscarTodosRepositorio<Pessoa>, IBuscarPessoaPorNome
    {
        private readonly ProjetoContexto _contexto = contexto;

        public async Task<Pessoa> Adicionar(Pessoa entidade)
        {
            var result = await _contexto.Pessoas
        }
    }
}
