namespace WhatsForDinner;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(Pages.GenerateFromIngredientsPage), typeof(Pages.GenerateFromIngredientsPage));
        //Routing.RegisterRoute(nameof(MenuItem2Page), typeof(MenuItem2Page));
        //Routing.RegisterRoute(nameof(MenuItem3Page), typeof(MenuItem3Page));
    }
}
