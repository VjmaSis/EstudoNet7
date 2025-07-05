using EstudoSOLID.Servico.Contratos.Basse;
using EstudoSOLID.Servico.Dtos;

namespace EstudoSOLID.Servico.Servico
{
    public interface IPessoaService : IServiceBase<PessoaDto>
    {
       Task<PessoaDto?> BuscarPorNome(string nome);
    }
}
