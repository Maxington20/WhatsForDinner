using Microsoft.Maui.Graphics.Text;

namespace WhatsForDinner.Pages;

public partial class DayDetailPage : ContentPage
{
	public DateTime SelectedDate { get; set; }

	public DayDetailPage(DateTime selectedDate)
	{
		InitializeComponent();
		SelectedDate = selectedDate;
		BindingContext = this;		
	}

    private async void OnPlanMealButtonClicked(object sender, EventArgs e)
    {
        var mealOptions = new string[] { "Breakfast", "Lunch", "Dinner" };
        string selectedMeal = await DisplayActionSheet("Plan Meal", "Cancel", null, mealOptions);

        if (selectedMeal != null)
        {
            // Handle the selected meal (e.g., navigate to a new page or update the UI)
            Console.WriteLine($"Selected meal: {selectedMeal}");
        }
    }
}