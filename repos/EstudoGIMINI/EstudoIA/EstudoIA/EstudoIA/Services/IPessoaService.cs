using EstudoIA.Models;

namespace EstudoIA.Services;

public interface IPessoaService
{
    List<Pessoa> GetPessoas();
    Pessoa? GetPessoaById(int id);
    void AddPessoa(Pessoa pessoa);
    void UpdatePessoa(Pessoa pessoa);
    void DeletePessoa(int id);
}
