using System;

class Outdoor : Event
{
    public string WeatherForecast;

    public Outdoor(string eventTitle, string description, DateTime date, TimeSpan time, string address, string weatherForecast) : base(eventTitle, description, date, time, address)
    {
        WeatherForecast = weatherForecast;
    }

    public override string Message()
    {
        return $"{base.Message()}\nWeather Forecast: {WeatherForecast}";
    }
}