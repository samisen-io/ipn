namespace server.Models;
public class category
{
  public long id { get; set; }
  public long parentId { get; set; }
  public string title { get; set; }
  public string metaTitle { get; set; }
  public string slug { get; set; }
  public string content { get; set; }
}