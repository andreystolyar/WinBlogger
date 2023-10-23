namespace WinBlogger.DataAccess;

public interface IDataMigrator
{
  void SeedDatabase(WinBloggerDbContext db);
}