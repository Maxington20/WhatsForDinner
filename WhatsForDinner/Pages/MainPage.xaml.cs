using System.Collections.ObjectModel;

namespace WhatsForDinner.Pages;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();       
    }

    // navigate to saved recipes page when SavedRecipesButton is clicked
    private void OnSavedRecipesButtonClicked(object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new SavedRecipesPage());
    }

    private void Button_Clicked(object sender, EventArgs e)
    {

    }
}