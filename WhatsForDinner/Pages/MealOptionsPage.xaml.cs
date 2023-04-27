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
        Navigation.PushAsync(new NewRecipePage(MealOfTheDay, SelectedDate));
    }

    private void OnSavedRecipesButtonClicked(object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new SavedRecipesPage());
    }

    private void OnGenerateRandomRecipeButtonClicked(object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new GenerateFromIngredientsPage(MealOfTheDay, SelectedDate));
    }
}