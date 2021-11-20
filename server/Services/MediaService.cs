using Microsoft.EntityFrameworkCore;
using server.DataContext;
using server.Models;

namespace server.Services
{
  public sealed class MediaService : IMediaService
  {
    private readonly AppDBContext _dbContext;

    public MediaService(AppDBContext dbContext)
    {
      _dbContext = dbContext;
    }

    public async Task<int> Delete(int id)
    {
      try
      {
        _dbContext.Media.Remove(
            new Media
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

    public async Task<IEnumerable<Media>> FindAll()
    {
      return await _dbContext.Media.ToListAsync();
    }

    public async Task<Media> FindOne(int id)
    {
      return await _dbContext.Media.FirstOrDefaultAsync(x => x.id == id);
    }

    public async Task<int> Insert(Media forecast)
    {
      _dbContext.Add(forecast);
      return await _dbContext.SaveChangesAsync();
    }

    public async Task<int> Update(Media forecast)
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
