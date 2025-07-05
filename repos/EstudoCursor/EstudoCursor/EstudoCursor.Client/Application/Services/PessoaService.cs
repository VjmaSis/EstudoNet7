using EstudoCursor.Client.Domain.Entities;
using EstudoCursor.Client.Domain.Interfaces;

namespace EstudoCursor.Client.Application.Services;

public class PessoaService
{
    private readonly IPessoaRepository _pessoaRepository;

    public PessoaService(IPessoaRepository pessoaRepository)
    {
        _pessoaRepository = pessoaRepository;
    }

    public async Task<IEnumerable<Pessoa>> ObterTodasAsync()
    {
        return await _pessoaRepository.ObterTodasAsync();
    }

    public async Task<Pessoa?> ObterPorIdAsync(Guid id)
    {
        return await _pessoaRepository.ObterPorIdAsync(id);
    }

    public async Task<Pessoa> AdicionarAsync(Pessoa pessoa)
    {
        await ValidarPessoaAsync(pessoa);
        return await _pessoaRepository.AdicionarAsync(pessoa);
    }

    public async Task<Pessoa> AtualizarAsync(Pessoa pessoa)
    {
        await ValidarPessoaAsync(pessoa, pessoa.Id);
        return await _pessoaRepository.AtualizarAsync(pessoa);
    }

    public async Task<bool> RemoverAsync(Guid id)
    {
        return await _pessoaRepository.RemoverAsync(id);
    }

    private async Task ValidarPessoaAsync(Pessoa pessoa, Guid? idExcluir = null)
    {
        // Validar se a pessoa tem pelo menos 18 anos
        if (pessoa.DataNascimento > DateTime.Now.AddYears(-18))
        {
            throw new InvalidOperationException("A pessoa deve ter pelo menos 18 anos");
        }

        // Validar se CPF já existe
        if (await _pessoaRepository.ExistePorCPFAsync(pessoa.CPF, idExcluir))
        {
            throw new InvalidOperationException("CPF já cadastrado");
        }

        // Validar se e-mail já existe
        if (await _pessoaRepository.ExistePorEmailAsync(pessoa.Email, idExcluir))
        {
            throw new InvalidOperationException("E-mail já cadastrado");
        }
    }
} 