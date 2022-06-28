namespace MauiApp3;

public partial class Logowanie : ContentPage
{
	public Logowanie()
	{
		InitializeComponent();
	}

    private void LoginU(object sender, EventArgs e)
    {
        //String UserName = UserNameL.Text;
        //String userPassword = UserNamePassword.Text;
        //if (UserName == null || userPassword == null)
        //{
        //     DisplayAlert("Uwaga", "Wpisz Login oraz Has³o", "Ok");
        //}
        //else
        //{
            
        //    Navigation.PushAsync(new MainPage());
        //}
    }
    private async void Rejestracja(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Rejestracja());
    }
}