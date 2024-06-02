namespace PowerGenerationLocationChecker.Views;

public partial class MapPage : ContentPage
{
	public MapPage()
	{
		InitializeComponent();

	}

    private async void HomeButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(MainPage));
    }

    private async void InfoButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Views.SuppliersPage));
    }
}