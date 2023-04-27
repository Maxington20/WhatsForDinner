namespace WhatsForDinner.Pages;

public partial class MealOptionsPage : ContentPage
{
    public string MealOfTheDay { get; set; }   
    public DateTime SelectedDate { get; set; }

	public MealOptionsPage(string result, DateTime selectedDate)
	{
		InitializeComponent();
        MealOfTheDay = result;
        SelectedDate = selectedDate;
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
}