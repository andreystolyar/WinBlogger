using System.Windows;
using WinBlogger.UI.Data;
using WinBlogger.UI.ViewModel;

namespace WinBlogger;

public partial class App : Application
{
	void Application_Startup(object sender, StartupEventArgs e)
	{
		var mainWindow = new MainWindow(
			new MainViewModel(
				new BloggerDataService()
				)
			);
		mainWindow.Show();
	}
}
