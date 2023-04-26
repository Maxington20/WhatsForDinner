namespace WhatsForDinner.Pages;

public partial class CustomActionSheet : ContentPage
{
	public CustomActionSheet()
	{
		InitializeComponent();
	}

    private void OnBreakfastClicked(object sender, System.EventArgs e)
    {
        Close("Breakfast");
    }

    private void OnLunchClicked(object sender, System.EventArgs e)
    {
        Close("Lunch");
    }

    private void OnDinnerClicked(object sender, System.EventArgs e)
    {
        Close("Dinner");
    }

    private void OnCancelClicked(object sender, System.EventArgs e)
    {
        Close(null);
    }

    private async void Close(string result)
    {
        MessagingCenter.Send(this, "CustomActionSheetResult", result);
        await Navigation.PopModalAsync();
    }
}