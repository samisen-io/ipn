using Microsoft.EntityFrameworkCore;
using server.DataContext;
using server.Models;

namespace server.Services
{
  public sealed class CategoryService : ICategoryService
  {
    private readonly AppDBContext _dbContext;

    public CategoryService(AppDBContext dbContext)
    {
      _dbContext = dbContext;
    }

    public async Task<int> Delete(int id)
    {
      try
      {
        _dbContext.Category.Remove(
            new Category
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

    public async Task<IEnumerable<Category>> FindAll()
    {
      return await _dbContext.Category.ToListAsync();
    }

    public async Task<Category> FindOne(int id)
    {
      return await _dbContext.Category.FirstOrDefaultAsync(x => x.id == id);
    }

    public async Task<int> Insert(Category forecast)
    {
      _dbContext.Add(forecast);
      return await _dbContext.SaveChangesAsync();
    }

    public async Task<int> Update(Category forecast)
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
