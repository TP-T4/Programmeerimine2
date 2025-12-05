namespace KooliProjekt.Application.Data.Repositories
{
    public interface IBeerRepository
    {
        Task<Beer?> GetByIdAsync(int id);
        Task<List<Beer>> GetAllAsync();
        Task<Beer> SaveAsync(Beer entity);
        Task<bool> DeleteAsync(int id);
    }
}
