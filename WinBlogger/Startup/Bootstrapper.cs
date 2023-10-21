using Autofac;
using WinBlogger.DataAccess;
using WinBlogger.UI.Data;
using WinBlogger.UI.ViewModel;

namespace WinBlogger.UI.Startup;

public class Bootstrapper
{
	public static IContainer Bootstrap()
	{
		var builder = new ContainerBuilder();

		builder.RegisterType<WinBloggerDbContext>().AsSelf();

		builder.RegisterType<MainWindow>().AsSelf();
		builder.RegisterType<MainViewModel>().AsSelf();
		builder.RegisterType<BloggerDataService>().As<IBloggerDataService>();

		return builder.Build();
	}
}
