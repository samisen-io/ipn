namespace server.Models;

public class PostMeta
{
  public long id { get; set; }
  public long postId { get; set; }
  public string key { get; set; }
  public string content { get; set; }
}