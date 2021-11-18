using server.Models;

namespace server.Services
{
  public interface IPostCategoryService
  {
    Task<int> Delete(int id);
    Task<IEnumerable<PostCategory>> FindAll();
    Task<PostCategory> FindOne(int id);
    Task<int> Insert(PostCategory forecast);
    Task<int> Update(PostCategory forecast);
  }
}
