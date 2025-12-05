namespace KooliProjekt.Application.Data.Repositories
{
	public class BatchRepository : BaseRepository<Batch>, IBatchRepository
	{
		public BatchRepository(ApplicationDbContext db) : base(db)
		{
		}
	}
}
