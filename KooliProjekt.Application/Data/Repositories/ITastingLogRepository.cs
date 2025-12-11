using System.Collections.Generic;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Data.Repositories
{
    public interface ITastingLogRepository
    {
        Task<TastingLog?> GetByIdAsync(int id);
        Task<List<TastingLog>> GetAllAsync();
        Task<TastingLog> SaveAsync(TastingLog entity);
        Task<bool> DeleteAsync(int id);
    }
}
