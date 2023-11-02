using System.Windows;
using WinBlogger.UI.ViewModel;

namespace WinBlogger;

public partial class MainWindow : Window
{
  readonly MainViewModel _viewModel;

	public MainWindow(MainViewModel viewModel)
	{
		InitializeComponent();
		_viewModel = viewModel;
		DataContext = _viewModel;
		Loaded += MainWindow_Loaded;
	}

	async void MainWindow_Loaded(object sender, RoutedEventArgs e)
	{
    if (! await _viewModel.CheckDbAsync())
		{
			var message = "База данных не найдена, создать?";
			var caption = "База данных не найдена";
			var result = MessageBox.Show(message, caption, MessageBoxButton.YesNo);
			if (result == MessageBoxResult.No) return;
			await _viewModel.CreateDbAsync();
		}

    await _viewModel.LoadAsync();
  }
}
