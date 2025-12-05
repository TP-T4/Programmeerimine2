namespace KooliProjekt.Application.Data.Repositories
{
    public class BreweryRepository : BaseRepository<Brewery>, IBreweryRepository
    {
        public BreweryRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}
