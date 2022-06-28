namespace MauiApp3;

public partial class App : Application
{
	public App()
	{
		 new NavigationPage(new Logowanie());
		InitializeComponent();

		//MainPage = new NavigationPage(new Logowanie());
		
	}
}
