using server.Models;

namespace server.Services
{
  public interface IMediaService
  {
    Task<int> Delete(int id);
    Task<IEnumerable<Media>> FindAll();
    Task<Media> FindOne(int id);
    Task<int> Insert(Media media);
    Task<int> Update(Media media);
  }
}
