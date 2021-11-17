namespace server.Models;

public class post_meta
{
  public long id { get; set; }
  public long postId { get; set; }
  public string key { get; set; }
  public string content { get; set; }
}