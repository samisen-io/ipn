using server.Models;

namespace server.Services
{
  public interface IUserService
  {
    Task<int> Delete(int id);
    Task<IEnumerable<User>> FindAll();
    Task<User> FindOne(int id);
    Task<int> Insert(User forecast);
    Task<int> Update(User forecast);
  }
}
