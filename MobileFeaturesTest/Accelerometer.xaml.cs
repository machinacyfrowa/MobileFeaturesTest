using Microsoft.Maui.Devices.Sensors;

namespace MobileFeaturesTest;

public partial class Accelerometer : ContentPage
{
	public Accelerometer()
	{
		InitializeComponent();
        //dodajemy obsluge zdarzenia zmiany wartosci sensora
        Microsoft.Maui.Devices.Sensors.Accelerometer.ReadingChanged += ReadingChanged;
        //uruchamiamy sensor
        Microsoft.Maui.Devices.Sensors.Accelerometer.Start(SensorSpeed.UI);
    }
    void ReadingChanged(object sender, AccelerometerChangedEventArgs e)
	{
		//wczytujemy sobie stan sensora
		AccelerometerData data = e.Reading;
        //wypisujemy dane dla konkrenej osi na ekran
		XLabel.Text = "X: " + data.Acceleration.X;
        YLabel.Text = "Y: " + data.Acceleration.Y;
        ZLabel.Text = "Z: " + data.Acceleration.Z;
    }
}