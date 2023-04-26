namespace WhatsForDinner;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(Pages.GenerateFromIngredientsPage), typeof(Pages.GenerateFromIngredientsPage));
        Routing.RegisterRoute(nameof(Pages.MealCalendarPage), typeof(Pages.MealCalendarPage));
        //Routing.RegisterRoute(nameof(MenuItem3Page), typeof(MenuItem3Page));
    }
}
