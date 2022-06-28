namespace MauiApp3;

public partial class Bmi : ContentPage
{
	public Bmi()
	{
		InitializeComponent();
	}

    private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
    {
        int value = Convert.ToInt32( e.NewValue);
        Wynik.Text = String.Format("Masz {0} Cm", value );
    }

    private void WskaznikWagi(object sender, ValueChangedEventArgs e)
    {
        int value = Convert.ToInt32(e.NewValue);
        WynikWagi.Text = String.Format("wa¿ysz {0} Kg", value);
    }

    private void SprawdzBmi(object sender, EventArgs e)
    {
        DisplayAlert("Uwaga", "Funkcjonalnoœæ", "Ok");
    }

    private void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
    {
        int value = Convert.ToInt32( e.NewValue);
        
        WynikWiek.Text = string.Format("Masz {0} lat", value);
    }
}