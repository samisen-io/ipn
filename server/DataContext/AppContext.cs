using Microsoft.EntityFrameworkCore;

namespace Server.DataContext
{
  public class AppContext : DbContext
  {
    public AppContext() { }
    public AppContext(DbContextOptions<AppContext> options) : base(options) { }
  }
}