namespace EstudoSOLID.Infraestrutura.Contratos.Base
{
    public interface IAdicionarRepositorio<T>
    {
        Task<T> Adicionar(T entidade);
    }
}
