using System.Collections.Generic;
using WinBlogger.Model;

namespace WinBlogger.UI.Data;

public interface IBloggerDataService
{
	IEnumerable<Blogger> GetAll();
}