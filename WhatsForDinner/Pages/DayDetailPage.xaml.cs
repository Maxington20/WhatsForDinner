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
        await Navigation.PushAsync(new CustomActionSheet());
    }
}