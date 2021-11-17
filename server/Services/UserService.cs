using Microsoft.EntityFrameworkCore;
using server.DataContext;
using server.Models;

namespace server.Services
{
  public sealed class UserService : IUserService
  {
    private readonly UserDBContext _dbContext;

    public UserService(UserDBContext dbContext)
    {
      _dbContext = dbContext;
    }

    public async Task<int> Delete(int id)
    {
      try
      {
        _dbContext.Users.Remove(
            new User
            {
              id = id
            }
        );

        return await _dbContext.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        return 0;
      }
    }

    public async Task<IEnumerable<User>> FindAll()
    {
      return await _dbContext.Users.ToListAsync();
    }

    public async Task<User> FindOne(int id)
    {
      return await _dbContext.Users.FirstOrDefaultAsync(x => x.id == id);
    }

    public async Task<int> Insert(User forecast)
    {
      _dbContext.Add(forecast);
      return await _dbContext.SaveChangesAsync();
    }

    public async Task<int> Update(User forecast)
    {
      try
      {
        _dbContext.Update(forecast);
        return await _dbContext.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        return 0;
      }
    }
  }
}
