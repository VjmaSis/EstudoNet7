namespace EstudoSOLID.Repositorio.Contratos.Base
{
    public interface IBuscarTodosRepositorio<T>
    {
        Task<IEnumerable<T>> BuscarTodos();
    }
}
