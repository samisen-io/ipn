using Microsoft.EntityFrameworkCore;

namespace server.Models;

[Keyless]
public class PostCategory
{
  public long postId { get; set; }
  public long categoryId { get; set; }
}