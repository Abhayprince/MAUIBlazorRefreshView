using MAUIBlazorRefreshView.States;

namespace MAUIBlazorRefreshView;

public partial class MainPage : ContentPage
{
    private readonly RefreshViewState _refreshViewState;

    public MainPage(RefreshViewState refreshViewState)
    {
        InitializeComponent();
        BindingContext = refreshViewState;
        _refreshViewState = refreshViewState;
    }

    private void RefreshView_Refreshing(object sender, EventArgs e)
    {
        _refreshViewState.SetIsRefreshing(true);
    }
}
