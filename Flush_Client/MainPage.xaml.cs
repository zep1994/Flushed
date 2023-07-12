using Flushed.DataServices;
using System.Diagnostics;

namespace Flush_Client
{
    public partial class MainPage : ContentPage
    {
            private readonly IRestDataService _dataService;

            public MainPage(IRestDataService dataService)
            {
                InitializeComponent();

                _dataService = dataService;
            }

            protected async override void OnAppearing()
            {
                base.OnAppearing();

                collectionView.ItemsSource = await _dataService.GetIbsCountAsync();
            }

            private void OnAddToDoClicked(object sender, EventArgs e)
            {
                Debug.WriteLine("---> Add button clicked!");
            }

            private static void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
            {
                Debug.WriteLine("---> Item changed clicked!");
            }
    }
}