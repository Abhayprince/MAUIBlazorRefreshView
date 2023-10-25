using System.ComponentModel;

namespace MAUIBlazorRefreshView.States;
public class RefreshViewState : INotifyPropertyChanged
{
    public bool IsRefreshing { get; private set; }
    public bool IsEnabled { get; private set; }

    public event PropertyChangedEventHandler PropertyChanged;

    public void SetIsRefreshing(bool isRefreshing)
    {
        IsRefreshing = isRefreshing;
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsRefreshing)));  
    }

    public void SetIsEnabled(bool isEnabled)
    {
        IsEnabled = isEnabled;
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsEnabled)));  
    }
}
