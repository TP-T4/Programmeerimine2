namespace KooliProjekt.Application.Data.Repositories
{
	public interface IBatchRepository
	{
		Task<Batch?> GetByIdAsync(int id);
		Task<List<Batch>> GetAllAsync();
		Task<Batch> SaveAsync(Batch entity);
		Task<bool> DeleteAsync(int id);
	}
}
