namespace KooliProjekt.Application.Data.Repositories
{
    public interface IIngredientRepository
    {
        Task<Ingredient?> GetByIdAsync(int id);
        Task<List<Ingredient>> GetAllAsync();
        Task<Ingredient> SaveAsync(Ingredient entity);
        Task<bool> DeleteAsync(int id);
    }
}
