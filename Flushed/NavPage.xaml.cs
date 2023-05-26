namespace Flushed;

public partial class NavPage : ContentPage
{
	public NavPage()
	{
		InitializeComponent();
	}

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }

    void Button_Clicked_1(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new FlyoutContent());
    }

    void Button_Clicked_2(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new TabbedContent());
    }

    void Button_Clicked_3(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new BowelMovementPage());
    }

}
