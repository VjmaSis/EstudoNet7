namespace EstudoSOLID.Infraestrutura.Contratos.Base
{
    public interface IBuscarTodosRepositorio<T>
    {
        Task<IEnumerable<T>> BuscarTodos();
    }
}
