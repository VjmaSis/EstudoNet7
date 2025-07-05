namespace EstudoSOLID.Repositorio.Contratos.Base
{
    public interface IBuscarPorIdRepositorio<T>
    {
        Task<IEnumerable<T>> BuscarPorId(int id);
    }
}
