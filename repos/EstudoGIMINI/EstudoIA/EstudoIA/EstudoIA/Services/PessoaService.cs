using EstudoIA.Models;

namespace EstudoIA.Services;

public class PessoaService : IPessoaService
{
    private readonly List<Pessoa> _pessoas = new()
    {
        new Pessoa { Id = 1, Nome = "João", Sobrenome = "Silva", Email = "joao.silva@example.com", DataNascimento = new DateTime(1990, 1, 1) },
        new Pessoa { Id = 2, Nome = "Maria", Sobrenome = "Santos", Email = "maria.santos@example.com", DataNascimento = new DateTime(1985, 5, 10) },
        new Pessoa { Id = 3, Nome = "Pedro", Sobrenome = "Almeida", Email = "pedro.almeida@example.com", DataNascimento = new DateTime(2000, 12, 25) }
    };

    public List<Pessoa> GetPessoas() => _pessoas;

    public Pessoa? GetPessoaById(int id)
    {
        return _pessoas.FirstOrDefault(p => p.Id == id);
    }

    public void AddPessoa(Pessoa pessoa)
    {
        pessoa.Id = _pessoas.Max(p => p.Id) + 1;
        _pessoas.Add(pessoa);
    }

    public void UpdatePessoa(Pessoa pessoa)
    {
        var pessoaExistente = _pessoas.FirstOrDefault(p => p.Id == pessoa.Id);
        if (pessoaExistente != null)
        {
            pessoaExistente.Nome = pessoa.Nome;
            pessoaExistente.Sobrenome = pessoa.Sobrenome;
            pessoaExistente.Email = pessoa.Email;
            pessoaExistente.DataNascimento = pessoa.DataNascimento;
        }
    }

    public void DeletePessoa(int id)
    {
        var pessoa = _pessoas.FirstOrDefault(p => p.Id == id);
        if (pessoa != null)
        {
            _pessoas.Remove(pessoa);
        }
    }
}
