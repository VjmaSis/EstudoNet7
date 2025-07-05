using EstudoSOLID.Dominio.Entidades;
using EstudoSOLID.Infraestrutura.Contratos.Base;

namespace EstudoSOLID.Infraestrutura.Contratos.Pessoas
{
    public interface IPessoaRepositorio : IAdicionarRepositorio<Pessoa>, IAtualizarRepositorio<Pessoa>,
                  IBuscarPorIdRepositorio<Pessoa>, IDeletarRepositorio,
                  IBuscarTodosRepositorio<Pessoa>
    {
        Task<Pessoa?> BuscarPorNome(string nome);
    }
}
