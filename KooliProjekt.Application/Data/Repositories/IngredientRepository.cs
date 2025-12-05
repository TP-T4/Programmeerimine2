namespace KooliProjekt.Application.Data.Repositories
{
    public class IngredientRepository : BaseRepository<Ingredient>, IIngredientRepository
    {
        public IngredientRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}
