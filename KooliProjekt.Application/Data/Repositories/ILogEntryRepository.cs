using System.Collections.Generic;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Data.Repositories
{
    public interface ILogEntryRepository
    {
        Task<LogEntry?> GetByIdAsync(int id);
        Task<List<LogEntry>> GetAllAsync();
        Task<LogEntry> SaveAsync(LogEntry entity);
        Task<bool> DeleteAsync(int id);
    }
}
