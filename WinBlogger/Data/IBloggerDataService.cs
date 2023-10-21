using System.Collections.Generic;
using System.Threading.Tasks;
using WinBlogger.Model;

namespace WinBlogger.UI.Data;

public interface IBloggerDataService
{
	Task<List<Blogger>> GetAllAsync();
	bool IsDbExists();
	void CreateDatabase();
}