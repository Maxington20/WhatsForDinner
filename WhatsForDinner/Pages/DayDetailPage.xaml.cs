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
                // Navigate to the MealOptionsPage with the selected meal
                Navigation.PushAsync(new MealOptionsPage(selectedMeal));
            }

            // Unsubscribe the message after it's handled
            MessagingCenter.Unsubscribe<CustomActionSheet, string>(this, "CustomActionSheetResult");
        });

        await Navigation.PushModalAsync(customActionSheet);
    }
}