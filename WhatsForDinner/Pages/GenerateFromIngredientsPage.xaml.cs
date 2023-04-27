using System.Collections.ObjectModel;

namespace WhatsForDinner.Pages;

public partial class GenerateFromIngredientsPage : ContentPage
{
    private ObservableCollection<Recipe> _recipes;

    public string MealOfTheDay { get; set; }
    public DateTime SelectedDate { get; set; }

    public GenerateFromIngredientsPage()
	{
        InitializeComponent();
        _recipes = new ObservableCollection<Recipe>();
        //RecipesListView.ItemsSource = _recipes;
        BindingContext = this;
    }

    public GenerateFromIngredientsPage(string mealOfTheDay, DateTime selectedDate)
    {
        InitializeComponent();
        MealOfTheDay = mealOfTheDay;
        SelectedDate = selectedDate;
        _recipes = new ObservableCollection<Recipe>();
        // RecipesListView.ItemsSource = _recipes;
        BindingContext = this;
    }

    async void OnRecipeTapped(object sender, EventArgs e)
    {
        var grid = sender as Grid;
        var recipe = grid.BindingContext as Recipe; // Replace 'Recipe' with your actual model class
        await Navigation.PushAsync(new RecipeDetailsPage(recipe));
    }

    private async void OnGenerateRecipesClicked(object sender, EventArgs e)
    {
        // Get the user input
        string ingredients = IngredientsEditor.Text;

        // Call your recipe API or algorithm here
        var generatedRecipes = await GenerateRecipesFromIngredients(ingredients);

        // Update the RecipesListView with the generated recipes
        _recipes.Clear();
        foreach (var recipe in generatedRecipes)
        {
            _recipes.Add(recipe);
        }
    }

    private async Task<List<Recipe>> GenerateRecipesFromIngredients(string ingredients)
    {
        // Implement your recipe generation logic or API call here
        // For this example, we return an empty list
        return new List<Recipe> { new Recipe { Name = "test recipe" }, new Recipe { Name = "pasta with cheese sauce" } };
    }

    public class Recipe
    {
        public string Name { get; set; }
        public string Directions { get; set; }
        
        public string Ingredients { get; set; }
    }
}