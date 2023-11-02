namespace WinBlogger.DataAccess;

public interface IDataMigrator
{
  Task SeedDatabaseAsync(WinBloggerDbContext db);
}