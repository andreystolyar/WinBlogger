using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WinBlogger.DataAccess;
using WinBlogger.Model;

namespace WinBlogger.UI.Data;

public class BloggerDataService : IBloggerDataService
{
  readonly Func<WinBloggerDbContext> _contextCreator;
	readonly IDataMigrator _migrator;

  public BloggerDataService
		(Func<WinBloggerDbContext> contextCreator, IDataMigrator migrator)
  {
		_contextCreator = contextCreator;
		_migrator = migrator;
  }

  public async Task<List<Blogger>> GetAllAsync()
	{
		using var db = _contextCreator();
		return await db.Bloggers.AsNoTracking().ToListAsync();

		/*
		yield return
			new Blogger
			{
				Nickname = "Schopenhauer",
				FullName = "Arthur Schopenhauer"
			};

		yield return
			new Blogger
			{
				Nickname = "Spinoza",
				FullName = "Baruch Spinoza"
			};

		yield return
			new Blogger
			{
				Nickname = "Nietzsche",
				FullName = "Friedrich Wilhelm Nietzsche"
			};

		yield return
			new Blogger
			{
				Nickname = "Kant",
				FullName = "Immanuel Kant"
			};

		yield return
			new Blogger
			{
				Nickname = "Descartes",
				FullName = "Rene Descartes"
			};
		*/
	}

	public async Task<bool> IsDbExistsAsync()
	{
		using var db = _contextCreator();
		return await db.Database.CanConnectAsync();
	}

	public async Task CreateDatabaseAsync()
	{
		using var db = _contextCreator();
		await _migrator.SeedDatabaseAsync(db);
	}
}
