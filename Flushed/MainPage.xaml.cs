namespace Flushed;

public partial class MainPage : ContentPage
{

	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new NavPage());
	}

    private void GlobalCounterBtn(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NavPage());
    }

    private void OneButtonGutAttackAdder(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            OneCounterButton.Text = $"Clicked {count} time";
        else
            OneCounterButton.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(OneCounterButton.Text);
    }

}


