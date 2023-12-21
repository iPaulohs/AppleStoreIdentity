using AppleStoreIdentity.Database;
using AppleStoreIdentity.Models;

namespace AppleStoreIdentity.Repository; 

public class CategoryRepository : ICategoryRepository
{
    private readonly AppleDbContext _db;

    public CategoryRepository(AppleDbContext db) => _db = db;

    public List<Category> GetAll()
    {
        return _db.Categories.ToList();
    }
}
