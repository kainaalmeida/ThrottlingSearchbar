namespace SearchItemsDemo.Views;

public partial class MainPage : ContentPage
{

	private MainViewModel _viewModel;

	public MainPage(MainViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = _viewModel = viewModel;
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
		_viewModel.Init();
    }
}
