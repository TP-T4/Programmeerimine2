namespace KooliProjekt.Application.Data.Repositories
{
    public class TastingLogRepository : BaseRepository<TastingLog>, ITastingLogRepository
    {
        public TastingLogRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}
