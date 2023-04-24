using static WhatsForDinner.Pages.GenerateFromIngredientsPage;
using static WhatsForDinner.MainPage;

namespace WhatsForDinner;

public partial class RecipeDetailsPage : ContentPage
{
    public Recipe Recipe { get; set; }

    public RecipeDetailsPage(Recipe recipe)
    {
        InitializeComponent();
        Recipe = recipe;
        BindingContext = this;
    }

    void OnSaveRecipeClicked(object sender, EventArgs e)
    {
        // Call the API to save the recipe to the database
        // Example: await ApiClient.SaveRecipeAsync(Recipe);
        // Display an alert or message to the user indicating the recipe has been saved
    }
}