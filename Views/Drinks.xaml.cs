using MauiApp1.ViewModels;

namespace MauiApp1.Views;

public partial class Drinks : ContentPage
{
	public Drinks(DrinksViewModel model)
	{
		InitializeComponent();
		this.BindingContext = model;
	}

}

