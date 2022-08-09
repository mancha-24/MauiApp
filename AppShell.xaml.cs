using System.Windows.Input;

namespace MauiApp1;

public partial class AppShell : Shell
{
	public AppShell()
	{
		Routing.RegisterRoute("Settings", typeof(Views.Settings));
		Routing.RegisterRoute("Detail", typeof(Views.Detail));

		InitializeComponent();

		SettingsCommand = new Command(async () =>
		{
			await AppShell.Current.GoToAsync("Settings");
		});
		this.BindingContext = this;


		#if ANDROID
				this.Title = this.Title + "-Android";
		#elif IOS
				this.Title = this.Title + "-ios";
		#elif WINDOWS
				this.Title = this.Title + "-WinUI";
		#endif
	}

	public ICommand SettingsCommand { get; }
}
