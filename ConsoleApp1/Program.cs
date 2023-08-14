using MigrationsDemo;


var db = new BlogContext();

if (!db.Posts.Any())
{
    Console.WriteLine("Adding sample data");
    db.AddRange(
        new Post { Title = "Intro to Migrations" },
        new Post { Title = "Migrations in Team Environments" },
        new Post { Title = "Advanced Migration" });
    db.SaveChanges();
}

Console.WriteLine("Posts:");
foreach (var post in db.Posts)
{
    Console.WriteLine($" {post.Title}");
}
