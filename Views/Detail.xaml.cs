namespace MauiApp1.Views;

[QueryProperty(nameof(Model), "Item")]
public partial class Detail : ContentPage
{
	private ViewModels.BaseViewModel model;

	public ViewModels.BaseViewModel Model
	{
		get { return model; }
		set
		{
			model = value;
			OnPropertyChanged(nameof(Model));
		}
	}
	public Detail()
	{
		InitializeComponent();
		BindingContext = this;
	}

}
