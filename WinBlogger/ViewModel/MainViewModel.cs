using System.Collections.ObjectModel;
using System.Threading.Tasks;
using WinBlogger.Model;
using WinBlogger.UI.Data;

namespace WinBlogger.UI.ViewModel;

public class MainViewModel : ViewModelBase
{
  readonly IBloggerDataService _bloggerDataService;
	Blogger? _selectedAuthor;

	public MainViewModel(IBloggerDataService bloggerDataService)
	{
		Authors = new ObservableCollection<Blogger>();
		_bloggerDataService = bloggerDataService;
	}

	public async Task LoadAsync()
	{
		var bloggers = await _bloggerDataService.GetAllAsync();

		Authors.Clear();

		foreach (var blogger in bloggers)
			Authors.Add(blogger);
	}

	public async Task<bool> CheckDbAsync()
	{
		return await _bloggerDataService.IsDbExistsAsync();
	}

	public async Task CreateDbAsync()
	{
		await _bloggerDataService.CreateDatabaseAsync();
	}

	public ObservableCollection<Blogger> Authors { get; set; }

	public Blogger? SelectedAuthor
	{
		get { return _selectedAuthor; }
		set
		{
			_selectedAuthor = value;
			OnNotifyPropertyChanged();
		}
	}
}
