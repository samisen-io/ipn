using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.EntityFrameworkCore;
using server.DataContext;
using server.Models;
using System.Security.Cryptography;
using System.Text;

namespace server.Services
{
  public sealed class UserService : IUserService
  {
    private readonly AppDBContext _dbContext;

    public UserService(AppDBContext dbContext)
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

    public async Task<int> Insert(User user)
    {
      user.passwordHash = HashPassword(user.passwordHash);
        _dbContext.Add(user);
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

    public string HashPassword(string password)
    {
      string hash;
      using (var sha256 = SHA256.Create())
      { 
        var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));     
        hash = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower(); 
       
      }

      return hash;
    }

    public Task<User> Authenticate(string username, string password)
    {
      User user;
      user = _dbContext.Users.SingleOrDefault(x => x.email == username && x.passwordHash == HashPassword(password));

      // return null if user not found
      if (user == null)
        return null;

      // authentication successful so return user details without password
      return Task.FromResult<User>(user);
    }
  }
}
