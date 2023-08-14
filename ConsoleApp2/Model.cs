using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MigrationsDemo;

class BlogContext : DbContext
{
    public DbSet<Post> Posts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
      => options.UseNpgsql("Host=localhost;Database=blog;Username=postgres;Password=example");
}

class Post
{
    public int Id { get; set; }

    [Required]
    public string Title { get; set; }
    public string Content { get; set; }
}
