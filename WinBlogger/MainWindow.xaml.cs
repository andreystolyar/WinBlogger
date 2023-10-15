using System.Windows;
using WinBlogger.UI.ViewModel;

namespace WinBlogger;

public partial class MainWindow : Window
{
	MainViewModel _viewModel;

	public MainWindow(MainViewModel viewModel)
	{
		InitializeComponent();
		_viewModel = viewModel;
		DataContext = _viewModel;
		Loaded += MainWindow_Loaded;
	}

	void MainWindow_Loaded(object sender, RoutedEventArgs e)
	{
		_viewModel.Load();
	}
}
