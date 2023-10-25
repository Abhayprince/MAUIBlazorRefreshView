using MAUIBlazorRefreshView.States;

namespace MAUIBlazorRefreshView;

public partial class App : Application
{
    public App(RefreshViewState refreshViewState)
    {
        InitializeComponent();

        MainPage = new MainPage(refreshViewState);
    }
}
