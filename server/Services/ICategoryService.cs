using server.Models;

namespace server.Services
{
  public interface ICategoryService
  {
    Task<int> Delete(int id);
    Task<IEnumerable<Category>> FindAll();
    Task<Category> FindOne(int id);
    Task<int> Insert(Category forecast);
    Task<int> Update(Category forecast);
  }
}
