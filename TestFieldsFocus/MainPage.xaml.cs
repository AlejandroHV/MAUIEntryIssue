namespace TestFieldsFocus;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";


        SemanticScreenReader.Announce(CounterBtn.Text);
	}

    private void OnResetClicked(object sender, EventArgs e)
    {
        UnFocusedLbl.Text = "";
    }

    

    private void EntryUnfocused(System.Object sender, Microsoft.Maui.Controls.FocusEventArgs e)
    {

		var entry = (Entry)sender;
		

        UnFocusedLbl.Text = entry.Text;
    }
}


