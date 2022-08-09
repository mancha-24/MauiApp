namespace MauiApp1.Views;

public partial class Vitamins : ContentPage
{
	public Vitamins(ViewModels.VitaminsViewModel model)
	{
		InitializeComponent();
		BindingContext = model;
	}
}

