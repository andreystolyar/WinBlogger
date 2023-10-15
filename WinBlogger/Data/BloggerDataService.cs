using System.Collections.Generic;
using WinBlogger.Model;

namespace WinBlogger.UI.Data;

public class BloggerDataService : IBloggerDataService
{
	public IEnumerable<Blogger> GetAll()
	{
		//todo: load data from a real database

		#region add temporary data
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
		#endregion
	}
}
