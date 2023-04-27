using static WhatsForDinner.Pages.GenerateFromIngredientsPage;

namespace WhatsForDinner.Pages;

public partial class NewRecipePage : ContentPage
{
    public string MealOfTheDay { get; set; }
    public DateTime SelectedDate { get; set; }

    public NewRecipePage()
    {
        InitializeComponent();
        BindingContext = this;
    }

    public NewRecipePage(string mealOfTheDay = null, DateTime? selectedDate = null)
    {
        InitializeComponent();
        MealOfTheDay = mealOfTheDay;
        SelectedDate = selectedDate.HasValue ? selectedDate.Value : DateTime.Now;
        BindingContext = this;
    }

    private void OnSaveRecipeButtonClicked(object sender, EventArgs e)
    {
        if(string.IsNullOrWhiteSpace(RecipeNameEntry.Text) || string.IsNullOrWhiteSpace(IngredientsEditor.Text) || string.IsNullOrWhiteSpace(DirectionsEditor.Text))
        {
            DisplayAlert("Error", "Please enter a recipe name, ingredients, and directions.", "OK");
            return;
        }
        // Get the values from the input fields
        string recipeName = RecipeNameEntry.Text;
        string ingredients = IngredientsEditor.Text;
        string directions = DirectionsEditor.Text;

        Recipe recipe = new Recipe() { Name = recipeName, Ingredients = ingredients, Directions = directions };

        // Do something with the values
        // For example, you could save the recipe to a database or file

        // Output the values to the console
        Console.WriteLine($"Recipe Name: {recipeName}");
        Console.WriteLine($"Ingredients: {ingredients}");
        Console.WriteLine($"Directions: {directions}");
        Console.WriteLine($"Meal Of The Day: {MealOfTheDay}");
        Console.WriteLine($"Selected Date: {SelectedDate}");


        if(MealOfTheDay != null)
        {
            // navigate to the DayDetailPage passing the selected date
            Navigation.PushAsync(new DayDetailPage(SelectedDate));
        }

        // else navigate to the savedrecipedpage
        else
        {
            Navigation.PushAsync(new SavedRecipesPage());
        }

        // else navigate to a new RecipeDetailsPage passing a Recipe object
        //else
        //{
        //    Navigation.PushAsync(new RecipeDetailsPage(recipe));
        //}

        // navigates to profile page
        //else
        //{
        //    Application.Current.MainPage = new AppShell();
        //}



    }
}