namespace MauiPlayerDemo;

public partial class MainPage : ContentPage
{
	public ViewModel VM { get; } = new ViewModel();

	public MainPage()
	{
		BindingContext = VM;
		InitializeComponent();
	}
}
