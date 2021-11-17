namespace server.Models;

public class postComment
{
  public long id { get; set; }
  public long postId { get; set; }
  public long parentId { get; set; }
  public string title { get; set; }
  public byte published { get; set; }
  public DateTime createdAt { get; set; }
  public DateTime publishedAt { get; set; }
  public string content { get; set; }
}