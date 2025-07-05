namespace EstudoSOLID.Servico.Contratos.Basse
{
    public interface IServiceBase<T>
    {
        Task<T> GetByIdAsync(int id);
        Task<T> AddAsync(T model);
        Task<T?> UpdateAsync(T model);
        Task DeleteAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
    }
}
