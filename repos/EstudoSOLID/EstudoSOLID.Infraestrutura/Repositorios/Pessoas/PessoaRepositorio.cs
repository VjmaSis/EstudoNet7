using EstudoSOLID.Dominio.Entidades;
using EstudoSOLID.Infraestrutura.Contexto;
using EstudoSOLID.Infraestrutura.Contratos.Pessoas;
using Microsoft.EntityFrameworkCore;

namespace EstudoSOLID.Repositorio.Repositorios.Pessoas
{
    public class PessoaRepositorio(ProjetoContexto contexto) : IPessoaRepositorio
    {
        private readonly ProjetoContexto _contexto = contexto;

        public async Task<Pessoa> Adicionar(Pessoa entidade)
        {
            var result = await _contexto.Pessoas.AddAsync(entidade);
            await _contexto.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Pessoa> Atualizar(Pessoa entidade)
        {
            var result = _contexto.Pessoas.Update(entidade);
            await _contexto.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Pessoa?> BuscarPorId(int id)
        {
            return await _contexto.Pessoas.FindAsync(id);
        }

        public async Task<Pessoa?> BuscarPorNome(string nome)
        {
            return await _contexto.Pessoas.FirstOrDefaultAsync(x => x.Nome.ToLower() == nome.ToLower());
        }

        public async Task<IEnumerable<Pessoa>> BuscarTodos()
        {
            return await _contexto.Pessoas.ToListAsync();
        }

        public async Task Deletar(int id)
        {
            var pessoa = await BuscarPorId(id);
            if (pessoa is not null)
            {
                _contexto.Pessoas.Remove(pessoa);
                await _contexto.SaveChangesAsync();
            }
        }
    }
}
