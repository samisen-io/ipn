using Microsoft.EntityFrameworkCore;
using server.Models;

namespace server.DataContext
{
  public partial class UserDBContext : Microsoft.EntityFrameworkCore.DbContext
  {
    public UserDBContext(DbContextOptions<UserDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; }
  }
}
