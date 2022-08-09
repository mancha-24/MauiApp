namespace MauiApp1.Views;

public partial class Settings : ContentPage
{
	public Settings()
	{
		InitializeComponent();
		SelectedDate = DateTime.Now;
		BindingContext = this;
	}

	public DateTime SelectedDate { get; set; }

}

