namespace server.Models;

public class post
{
  public long id { get; set; }
  public long authorId { get; set; }
  public long parentId { get; set; }
  public string title { get; set; }
  public string metaTitle { get; set; }
  public string slug { get; set; }
  public byte published { get; set; }
  public DateTime createdAt { get; set; }
  public DateTime updatedAt { get; set; }
  public DateTime publishedAt { get; set; }
  public string content { get; set; }
}