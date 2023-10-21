using Microsoft.EntityFrameworkCore;
using WinBlogger.Model;

namespace WinBlogger.DataAccess;

public class DataMigrator
{
  /*
  public void ApplyMigrations()
  {
    using var db = new WinBloggerDbContext();
    db.Database.Migrate();
  }
  */

  public static void SeedDatabase(WinBloggerDbContext db)
  {
    db.Database.Migrate();

    SeedBloggers(db);
    //SeedBlogs(db);
    //SeedPosts(db);
    //SeedComments(db);

    db.SaveChanges();
  }

  static void SeedBloggers(WinBloggerDbContext db)
  {
    var bloggers = new List<Blogger>
    {
      new Blogger
      {
        Nickname = "Schopenhauer",
        FullName = "Arthur Schopenhauer"
      },
      new Blogger
      {
        Nickname = "Spinoza",
        FullName = "Baruch Spinoza"
      },
      new Blogger
      {
        Nickname = "Nietzsche",
        FullName = "Friedrich Wilhelm Nietzsche"
      },
      new Blogger
      {
        Nickname = "Kant",
        FullName = "Immanuel Kant"
      },
      new Blogger
      {
        Nickname = "Descartes",
        FullName = "Rene Descartes"
      }
    };

    db.Bloggers.AddRange(bloggers);
  }

  void SeedBlogs(WinBloggerDbContext db)
  {
    throw new NotImplementedException();
  }

  void SeedPosts(WinBloggerDbContext db)
  {
    throw new NotImplementedException();
  }

  void SeedComments(WinBloggerDbContext db)
  {
    throw new NotImplementedException();
  }
}
