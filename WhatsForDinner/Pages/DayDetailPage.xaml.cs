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
        var customActionSheet = new CustomActionSheet();
        MessagingCenter.Subscribe<CustomActionSheet, string>(this, "CustomActionSheetResult", (sender, arg) =>
        {
            string selectedMeal = arg;

            if (selectedMeal != null)
            {
                // Handle the selected meal (e.g., navigate to a new page or update the UI)
                Console.WriteLine($"Selected meal: {selectedMeal}");
            }
        });

        await Navigation.PushModalAsync(customActionSheet);
    }
}