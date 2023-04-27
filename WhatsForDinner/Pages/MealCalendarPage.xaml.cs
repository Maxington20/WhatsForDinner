namespace WhatsForDinner.Pages;
using WhatsForDinner.Controls;
using Syncfusion.Maui.Calendar;
using Microsoft.Maui.Graphics.Text;
using System.Runtime.CompilerServices;

public partial class MealCalendarPage : ContentPage
{
	public MealCalendarPage()
	{
		InitializeComponent();
     
        SfCalendar calendar = new SfCalendar();        
        this.Content = calendar;
        this.Calendar = calendar;
        this.Calendar.TodayHighlightBrush = Color.FromRgba("#FFA500");
        this.Calendar.SelectionBackground = Color.FromRgba("#FFA500");
        this.Calendar.DoubleTapped += this.DateSelected;

        CalendarTextStyle todayTextStyle = new CalendarTextStyle()
        {
            TextColor = Color.FromRgba("#FFA500"),
        };

        CalendarTextStyle selectionTextStyle = new CalendarTextStyle()
        {
            FontAttributes = FontAttributes.Bold,
            TextColor = Colors.White
        };

        this.Calendar.MonthView = new CalendarMonthView()
        {
            //TodayBackground = Colors.Orange,
            TodayTextStyle = todayTextStyle,
            SelectionTextStyle = selectionTextStyle,
            FirstDayOfWeek = DayOfWeek.Monday,
        };        
    }

    private async void DateSelected(object sender,  CalendarDoubleTappedEventArgs e)
    {
        await Navigation.PushAsync(new DayDetailPage(e.Date));
    }
}