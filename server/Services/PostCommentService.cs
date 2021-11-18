using Microsoft.EntityFrameworkCore;
using server.DataContext;
using server.Models;

namespace server.Services
{
  public sealed class PostCommentService : IPostCommentService
  {
    private readonly AppDBContext _dbContext;

    public PostCommentService(AppDBContext dbContext)
    {
      _dbContext = dbContext;
    }

    public async Task<int> Delete(int id)
    {
      try
      {
        _dbContext.Post_Comment.Remove(
            new PostComment
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

    public async Task<IEnumerable<PostComment>> FindAll()
    {
      return await _dbContext.Post_Comment.ToListAsync();
    }

    public async Task<PostComment> FindOne(int id)
    {
      return await _dbContext.Post_Comment.FirstOrDefaultAsync(x => x.id == id);
    }

    public async Task<int> Insert(PostComment forecast)
    {
      _dbContext.Add(forecast);
      return await _dbContext.SaveChangesAsync();
    }

    public async Task<int> Update(PostComment forecast)
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
