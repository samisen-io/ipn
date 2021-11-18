using server.Models;

namespace server.Services
{
  public interface IPostMetaService
  {
    Task<int> Delete(int id);
    Task<IEnumerable<PostMeta>> FindAll();
    Task<PostMeta> FindOne(int id);
    Task<int> Insert(PostMeta forecast);
    Task<int> Update(PostMeta forecast);
  }
}
