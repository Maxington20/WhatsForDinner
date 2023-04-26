namespace WhatsForDinner;

public partial class App : Application
{
	public App()
	{
		Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTg0Nzk1OUAzMjMxMmUzMTJlMzQzMUdINHNLck95clBQd0sydk9QaTA2N1M2UUNnMmxMbWdXdm1VbG04MFhBa1E9");
		InitializeComponent();

		MainPage = new AppShell();
	}
}
