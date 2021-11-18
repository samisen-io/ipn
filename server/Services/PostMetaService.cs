using Microsoft.EntityFrameworkCore;
using server.DataContext;
using server.Models;

namespace server.Services
{
  public sealed class PostMetaService : IPostMetaService
    {
    private readonly AppDBContext _dbContext;

    public PostMetaService(AppDBContext dbContext)
    {
      _dbContext = dbContext;
    }

    public async Task<int> Delete(int id)
    {
      try
      {
        _dbContext.Post_Meta.Remove(
            new PostMeta
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

    public async Task<IEnumerable<PostMeta>> FindAll()
    {
      return await _dbContext.Post_Meta.ToListAsync();
    }

    public async Task<PostMeta> FindOne(int id)
    {
      return await _dbContext.Post_Meta.FirstOrDefaultAsync(x => x.id == id);
    }

    public async Task<int> Insert(PostMeta forecast)
    {
      _dbContext.Add(forecast);
      return await _dbContext.SaveChangesAsync();
    }

    public async Task<int> Update(PostMeta forecast)
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
