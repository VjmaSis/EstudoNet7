using EstudoCursor.Client.Domain.Entities;
using EstudoCursor.Client.Domain.Interfaces;

namespace EstudoCursor.Client.Infrastructure.Repositories;

public class PessoaRepositoryInMemory : IPessoaRepository
{
    private readonly List<Pessoa> _pessoas = new();
    private readonly object _lock = new();

    public Task<IEnumerable<Pessoa>> ObterTodasAsync()
    {
        lock (_lock)
        {
            return Task.FromResult(_pessoas.AsEnumerable());
        }
    }

    public Task<Pessoa?> ObterPorIdAsync(Guid id)
    {
        lock (_lock)
        {
            var pessoa = _pessoas.FirstOrDefault(p => p.Id == id);
            return Task.FromResult(pessoa);
        }
    }

    public Task<Pessoa> AdicionarAsync(Pessoa pessoa)
    {
        lock (_lock)
        {
            _pessoas.Add(pessoa);
            return Task.FromResult(pessoa);
        }
    }

    public Task<Pessoa> AtualizarAsync(Pessoa pessoa)
    {
        lock (_lock)
        {
            var index = _pessoas.FindIndex(p => p.Id == pessoa.Id);
            if (index != -1)
            {
                _pessoas[index] = pessoa;
                return Task.FromResult(pessoa);
            }
            throw new InvalidOperationException("Pessoa não encontrada");
        }
    }

    public Task<bool> RemoverAsync(Guid id)
    {
        lock (_lock)
        {
            var pessoa = _pessoas.FirstOrDefault(p => p.Id == id);
            if (pessoa != null)
            {
                _pessoas.Remove(pessoa);
                return Task.FromResult(true);
            }
            return Task.FromResult(false);
        }
    }

    public Task<bool> ExistePorCPFAsync(string cpf, Guid? idExcluir = null)
    {
        lock (_lock)
        {
            var existe = _pessoas.Any(p => p.CPF == cpf && (!idExcluir.HasValue || p.Id != idExcluir.Value));
            return Task.FromResult(existe);
        }
    }

    public Task<bool> ExistePorEmailAsync(string email, Guid? idExcluir = null)
    {
        lock (_lock)
        {
            var existe = _pessoas.Any(p => p.Email == email && (!idExcluir.HasValue || p.Id != idExcluir.Value));
            return Task.FromResult(existe);
        }
    }
} 