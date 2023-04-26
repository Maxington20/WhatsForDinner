namespace WhatsForDinner.Pages;
using WhatsForDinner.Controls;
using Syncfusion.Maui.Calendar;
using Microsoft.Maui.Graphics.Text;

public partial class MealCalendarPage : ContentPage
{
	public MealCalendarPage()
	{
		InitializeComponent();

      

        SfCalendar calendar = new SfCalendar();        
        this.Content = calendar;
        this.Calendar = calendar;
        this.Calendar.ShowActionButtons = true;
        this.Calendar.TodayHighlightBrush = Color.FromRgba("#FFA500");
        this.Calendar.SelectionBackground = Color.FromRgba("#FFA500");

        CalendarTextStyle textStyle = new CalendarTextStyle()
        {
            TextColor = Color.FromRgba("#FFA500")
    };

        this.Calendar.MonthView = new CalendarMonthView()
        {
            //TodayBackground = Colors.Orange,
            TodayTextStyle = textStyle
        };                 
    }

    private async void Calendar_DaySelected(object sender, DateTime e)
    {
        //await Navigation.PushAsync(new DayDetailPage(e));
    }
}