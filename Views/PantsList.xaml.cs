using MauiApp1.ViewModels;

namespace MauiApp1.Views;

public partial class PantsList : ContentPage
{
	public PantsList(PantsViewModel model)
	{
		InitializeComponent();
		BindingContext = model;
	}
}

