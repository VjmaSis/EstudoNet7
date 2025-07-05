namespace EstudoSOLID.Infraestrutura.Contratos.Base
{
    public interface IAtualizarRepositorio<T>
    {
        Task<T> Atualizar(T entidade);
    }
}
