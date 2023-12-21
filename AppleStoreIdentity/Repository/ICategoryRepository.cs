using AppleStoreIdentity.Models;

namespace AppleStoreIdentity.Repository;

public interface ICategoryRepository
{
    public List<Category> GetAll();
}
