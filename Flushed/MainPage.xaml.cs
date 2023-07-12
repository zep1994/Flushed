using Flushed.DataServices;
using System.Diagnostics;

namespace Flushed;

public partial class MainPage : ContentPage
{
    private readonly IRestDataService _dataService;

    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    public MainPage(IRestDataService dataService)
	{
		InitializeComponent();

        _dataService = dataService;
	}

    public MainPage(IRestDataService dataService, object dataService1) : this(dataService)
    {
        InitializeComponent();
    }

    protected async override void OnAppearing()
    {
        base.OnAppearing();

        //collectionView.ItemsSource = await _dataService.GetIbsCountAsync();
    }

    async void OnAddIbsCountClicked(object sender, EventArgs e)
    {
        Debug.WriteLine("Success");
    }

    async void OnSelectClick(object sender, SelectionChangedEventArgs e)
    {
        Debug.WriteLine("Yes");
    }

}


