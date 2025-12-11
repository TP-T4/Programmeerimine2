using System.Collections.Generic;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Data.Repositories
{
	public interface IBreweryRepository
	{
		Task<Brewery?> GetByIdAsync(int id);
		Task<List<Brewery>> GetAllAsync();
		Task<Brewery> SaveAsync(Brewery entity);
		Task<bool> DeleteAsync(int id);
	}
}
