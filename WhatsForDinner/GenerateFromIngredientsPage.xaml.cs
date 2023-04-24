using System.Collections.ObjectModel;

namespace WhatsForDinner;

public partial class GenerateFromIngredientsPage : ContentPage
{
    private ObservableCollection<Recipe> _recipes;

    public GenerateFromIngredientsPage()
	{
        InitializeComponent();
        _recipes = new ObservableCollection<Recipe>();
        RecipesListView.ItemsSource = _recipes;
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
    }

    private void OnRemoveRecipeClicked(object sender, EventArgs e)
    {
        if (sender is Button removeButton)
        {
            var recipeToRemove = removeButton.CommandParameter as Recipe;
            if (recipeToRemove != null)
            {
                // Remove the recipe from the collection.
                // Assuming you have an ObservableCollection<Recipe> named Recipes
                _recipes.Remove(recipeToRemove);
            }
        }
    }
}