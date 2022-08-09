using MauiApp1.ViewModels;

namespace MauiApp1.Views;

public partial class Shirts : ContentPage
{
	public Shirts(ShirtsViewModel model)
    {
        InitializeComponent();
		BindingContext = model;
	}
}