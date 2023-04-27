namespace WhatsForDinner.Pages;

public partial class NewRecipePage : ContentPage
{
    public string MealOfTheDay { get; set; }
    public DateTime SelectedDate { get; set; }

    public NewRecipePage(string mealOfTheDay = null, DateTime? selectedDate = null)
    {
        InitializeComponent();
        MealOfTheDay = mealOfTheDay;
        SelectedDate = selectedDate ?? DateTime.Now;
        BindingContext = this;
    }

    private void OnSaveRecipeButtonClicked(object sender, EventArgs e)
    {
        // Get the values from the input fields
        string recipeName = RecipeNameEntry.Text;
        string ingredients = IngredientsEditor.Text;
        string directions = DirectionsEditor.Text;

        // Do something with the values
        // For example, you could save the recipe to a database or file

        // Output the values to the console
        Console.WriteLine($"Recipe Name: {recipeName}");
        Console.WriteLine($"Ingredients: {ingredients}");
        Console.WriteLine($"Directions: {directions}");
        Console.WriteLine($"Meal Of The Day: {MealOfTheDay}");
        Console.WriteLine($"Selected Date: {SelectedDate}");
    }
}