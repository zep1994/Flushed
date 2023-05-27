namespace Flushed;

public partial class BowelMovementPage : ContentPage
{
	public BowelMovementPage()
	{
		InitializeComponent();
	}

    void OnEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        string oldText = e.OldTextValue;
        string newText = e.NewTextValue;
        string myText = entry.Text;
    }

    void OnEntryCompleted(object sender, EventArgs e)
    {
        string text = ((Entry)sender).Text;
    }
}
