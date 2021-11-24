using System.ComponentModel.DataAnnotations;

namespace server.Models;

public class User
{
    public long? id { get; set; }
    [Required]
    public string firstName { get; set; }
    public string middleName { get; set; }
    [Required]
    public string lastName { get; set; }
    [Required]
    [Required]
    public string mobile { get; set; }
    [Required]
    public string email { get; set; }
    [Required]
    public string passwordHash { get; set; }
    [Required]
    public DateTime registeredAt { get; set; }
    public DateTime lastLogin { get; set; }
    public string profile { get; set; }
}

