using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WinBlogger.UI.ViewModel;

public class ViewModelBase : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnNotifyPropertyChanged
        ([CallerMemberName] string propName = null!)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }
}
