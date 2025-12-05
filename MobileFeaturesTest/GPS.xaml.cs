namespace MobileFeaturesTest;

public partial class GPS : ContentPage
{
	public GPS()
	{
		InitializeComponent();
	}

    async private void Start_GPS(object sender, EventArgs e)
    {
        //poproœ / sprawdŸ uprawnienia do lokalizacji
        var status = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();
        if (status != PermissionStatus.Granted)
        {
            //jeœli nie mamy uprawnieñ, to poka¿ komunikat i zakoñcz
            await DisplayAlert("Brak uprawnieñ", "Aplikacja nie ma uprawnieñ do lokalizacji", "OK");
            return;
        }
        //teraz dopiero faktycznie pobierz lokalizacjê
        var location = await Geolocation.Default.GetLocationAsync();
        if (location != null)
        {
            LatitudeLabel.Text = "Szerokoœæ: " + location.Latitude;
            LongitudeLabel.Text = "D³ugoœæ: " + location.Longitude;
        }


    }
}