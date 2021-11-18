using Microsoft.EntityFrameworkCore;
using server.DataContext;
using server.Models;

namespace server.Services
{
  public sealed class PostCategoryService : IPostCategoryService
  {
    private readonly AppDBContext _dbContext;

    public PostCategoryService(AppDBContext dbContext)
    {
      _dbContext = dbContext;
    }

    public async Task<int> Delete(int id)
    {
      try
      {
        _dbContext.Post_Category.Remove(
            new PostCategory
            {
              postId = id
            }
        );

        return await _dbContext.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        return 0;
      }
    }

    public async Task<IEnumerable<PostCategory>> FindAll()
    {
      return await _dbContext.Post_Category.ToListAsync();
    }

    public async Task<PostCategory> FindOne(int id)
    {
      return await _dbContext.Post_Category.FirstOrDefaultAsync(x => x.postId == id);
    }

    public async Task<int> Insert(PostCategory forecast)
    {
      _dbContext.Add(forecast);
      return await _dbContext.SaveChangesAsync();
    }

    public async Task<int> Update(PostCategory forecast)
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
