namespace KooliProjekt.Application.Data.Repositories
{
    public class LogEntryRepository : BaseRepository<LogEntry>, ILogEntryRepository
    {
        public LogEntryRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}
