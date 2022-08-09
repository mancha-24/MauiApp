namespace MauiApp1;

public partial class AppShell : Shell
{
	public AppShell()
	{
		//Routing.RegisterRoute("Settings", typeof(Views.Settings));
		Routing.RegisterRoute("Detail", typeof(Views.Detail));

		InitializeComponent();

		//SettingsCommand = new Command(async () =>
		//{
		//	await AppShell.Current.GoToAsync("Settings");
		//});
		this.BindingContext = this;
	}
}
