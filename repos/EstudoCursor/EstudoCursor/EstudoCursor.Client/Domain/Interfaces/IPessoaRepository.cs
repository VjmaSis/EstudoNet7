using EstudoCursor.Client.Domain.Entities;

namespace EstudoCursor.Client.Domain.Interfaces;

public interface IPessoaRepository
{
    Task<IEnumerable<Pessoa>> ObterTodasAsync();
    Task<Pessoa?> ObterPorIdAsync(Guid id);
    Task<Pessoa> AdicionarAsync(Pessoa pessoa);
    Task<Pessoa> AtualizarAsync(Pessoa pessoa);
    Task<bool> RemoverAsync(Guid id);
    Task<bool> ExistePorCPFAsync(string cpf, Guid? idExcluir = null);
    Task<bool> ExistePorEmailAsync(string email, Guid? idExcluir = null);
} 