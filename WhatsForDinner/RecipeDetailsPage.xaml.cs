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
}