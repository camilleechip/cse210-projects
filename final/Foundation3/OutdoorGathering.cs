public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string title, string description, DateTime dateTime, Address address, string weather) 
        : base(title, description, "Outdoor Gathering", dateTime, address)
    {
        string[] weatherStatments =
        {
            "The weather for this event will be beautiful and sunny.",
            "The weather for this event will be cloudy with a chance of rain.",
            "The weather for this event will be cold with possible snow.",
            "The weather for this event will be windy.",
            "The weather for this event will have hot temperatures."
        };

        Random rand = new Random();
        int index = rand.Next(weatherStatments.Length);
        _weather = weatherStatments[index];
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()} \nEvent Type: {GetEventType()} \nWeather: {_weather}";
    }
}