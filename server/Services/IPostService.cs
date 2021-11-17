using server.Models;

namespace server.Services
{
  public interface IPostService
  {
    Task<int> Delete(int id);
    Task<IEnumerable<Post>> FindAll();
    Task<Post> FindOne(int id);
    Task<int> Insert(Post forecast);
    Task<int> Update(Post forecast);
  }
}
