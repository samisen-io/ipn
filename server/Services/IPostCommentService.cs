using server.Models;

namespace server.Services
{
  public interface IPostCommentService
  {
    Task<int> Delete(int id);
    Task<IEnumerable<PostComment>> FindAll();
    Task<PostComment> FindOne(int id);
    Task<int> Insert(PostComment forecast);
    Task<int> Update(PostComment forecast);
  }
}
