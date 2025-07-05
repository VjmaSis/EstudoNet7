namespace EstudoSOLID.Repositorio.Contratos.Base
{
    public interface IAtualizarRepositorio<T>
    {
        Task<T> Atualizar(T entidade);
    }
}
