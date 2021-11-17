using Microsoft.EntityFrameworkCore;
using server.Models;

namespace server.DataContext
{
  public partial class AppDBContext : Microsoft.EntityFrameworkCore.DbContext
  {
    public AppDBContext(DbContextOptions<AppDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<Post> Posts { get; set; }

  }
}
