using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WinBlogger.DataAccess;
using WinBlogger.Model;

namespace WinBlogger.UI.Data;

public class BloggerDataService : IBloggerDataService
{
	public IEnumerable<Blogger> GetAll()
	{
		using var db = new WinBloggerDbContext();
		return db.Bloggers.AsNoTracking().ToList();

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

	public bool IsDbExists()
	{
		using var db = new WinBloggerDbContext();
		return db.Database.CanConnect();
	}

	public void CreateDatabase()
	{
		var dataMigrator = new DataMigrator();
		dataMigrator.SeedDatabase();
	}
}
