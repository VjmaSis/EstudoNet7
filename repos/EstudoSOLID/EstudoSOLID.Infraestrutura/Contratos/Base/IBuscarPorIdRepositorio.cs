namespace EstudoSOLID.Infraestrutura.Contratos.Base
{
    public interface IBuscarPorIdRepositorio<T>
    {
        Task<T?> BuscarPorId(int id);
    }
}
