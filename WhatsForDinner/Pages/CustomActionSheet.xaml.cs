namespace WhatsForDinner.Pages;

public partial class CustomActionSheet : ContentPage
{
    public DateTime MealDate { get; set; }

	public CustomActionSheet(DateTime selectedDate)
	{
		InitializeComponent();
        MealDate = selectedDate;
        BindingContext = this;
	}

    private async void OnBreakfastClicked(object sender, EventArgs e)
    {
        await Close("Breakfast");
    }

    private async void OnLunchClicked(object sender, EventArgs e)
    {
        await Close("Lunch");
    }

    private async void OnDinnerClicked(object sender, EventArgs e)
    {
        await Close("Dinner");
    }

    private async void OnCancelClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async Task Close(string result)
    {
        await Navigation.PushAsync(new MealOptionsPage(result));
    }
}