namespace server.Models;

public class user
{
  public long id { get; set; }
  public string firstName { get; set; }
  public string middleName { get; set; }
  public string lastName { get; set; }
  public string mobile { get; set; }
  public string email { get; set; }
  public string passwordHash { get; set; }
  public DateTime registeredAt { get; set; }
  public DateTime lastLogin { get; set; }
  public string profile { get; set; }
}

