using EstudoSOLID.Dominio.Entidades;

namespace EstudoSOLID.Repositorio.Contratos.Pessoas
{
    public interface IBuscarPessoaPorNome
    {
        Task<Pessoa> BuscarPorNome(string nome);
    }
}
