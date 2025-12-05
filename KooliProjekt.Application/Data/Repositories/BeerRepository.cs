namespace KooliProjekt.Application.Data.Repositories
{
    public class BeerRepository : BaseRepository<Beer>, IBeerRepository
    {
        public BeerRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}
