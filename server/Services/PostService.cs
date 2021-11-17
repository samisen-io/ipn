using Microsoft.EntityFrameworkCore;
using server.DataContext;
using server.Models;

namespace server.Services
{
  public sealed class PostService : IPostService
  {
    private readonly AppDBContext _dbContext;

    public PostService(AppDBContext dbContext)
    {
      _dbContext = dbContext;
    }

    public async Task<int> Delete(int id)
    {
      try
      {
        _dbContext.Posts.Remove(
            new Post
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

    public async Task<IEnumerable<Post>> FindAll()
    {
      return await _dbContext.Posts.ToListAsync();
    }

    public async Task<Post> FindOne(int id)
    {
      return await _dbContext.Posts.FirstOrDefaultAsync(x => x.id == id);
    }

    public async Task<int> Insert(Post forecast)
    {
      _dbContext.Add(forecast);
      return await _dbContext.SaveChangesAsync();
    }

    public async Task<int> Update(Post forecast)
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
