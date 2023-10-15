using Autofac;
using System.Windows;
using WinBlogger.UI.Startup;

namespace WinBlogger;

public partial class App : Application
{
	void Application_Startup(object sender, StartupEventArgs e)
	{
		var container = Bootstrapper.Bootstrap();

		var mainWindow = container.Resolve<MainWindow>();

		mainWindow.Show();
	}
}
