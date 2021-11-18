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

    public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<PostCategory> Post_Category { get; set; }
        public virtual DbSet<PostComment> Post_Comment { get; set; }

        public virtual DbSet<PostMeta> Post_Meta { get; set; }
    }
}
