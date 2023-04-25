namespace WhatsForDinner.Pages;
using WhatsForDinner.Controls;

public partial class MealCalendarPage : ContentPage
{
	public MealCalendarPage()
	{
		InitializeComponent();

        var calendar = new CustomCalendar();
        calendar.DaySelected += Calendar_DaySelected;

        Content = new StackLayout
        {
            Children = { calendar }
        };
    }

    private async void Calendar_DaySelected(object sender, DateTime e)
    {
        //await Navigation.PushAsync(new DayDetailPage(e));
    }
}