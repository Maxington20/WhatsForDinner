namespace WhatsForDinner.Pages;

public partial class MealOptionsPage : ContentPage
{
	public MealOptionsPage(string result)
	{
		InitializeComponent();
	}

    private void OnNewRecipeButtonClicked(object sender, System.EventArgs e)
    {
        // Handle the New Recipe button click
    }

    private void OnSavedRecipesButtonClicked(object sender, System.EventArgs e)
    {
        // Handle the Saved Recipes button click
    }

    private void OnGenerateRandomRecipeButtonClicked(object sender, System.EventArgs e)
    {
        // Handle the Generate Random Recipe button click
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}