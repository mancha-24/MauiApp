namespace MauiApp1;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
#pragma warning disable CA1416 // Validate platform compatibility
        builder
            .UseMauiApp<App>()
            .ConfigureEssentials((bldr) =>
			{
				if (AppActions.Current.IsSupported)
				{
                    var action = new AppAction("hplus:action1", "Settings");
                    bldr.AddAppAction(action);
                    bldr.OnAppAction((act) =>
                    {
                        AppShell.Current.Dispatcher.Dispatch(async () =>
                        {
                            if (act.Id == "hplus:action1")
                            {
                                await AppShell.Current.GoToAsync("Settings");
                            }
                        });

                    });
                }
			})
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("ionicons.ttf", "Ionicons");
            })
            .Services.AddSingleton<Views.Drinks>()
            .AddSingleton<ViewModels.DrinksViewModel>()
            .AddSingleton<Views.Vitamins>()
            .AddSingleton<ViewModels.VitaminsViewModel>()
            .AddSingleton<Views.PantsList>()
            .AddSingleton<ViewModels.PantsViewModel>()
            .AddSingleton<Views.Shirts>()
            .AddSingleton<ViewModels.ShirtsViewModel>()
            .AddSingleton<Services.ProductService>((svccoll) =>
            {
                var productSvc = new Services.ProductService();
                productSvc.Load();
                return productSvc;
            });

#pragma warning restore CA1416 // Validate platform compatibility

        return builder.Build();
	}
}
