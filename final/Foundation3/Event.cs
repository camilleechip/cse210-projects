using System.Net.Sockets;

public abstract class Event
{
    private string _eventTitle;
    private string _description;
    private string _eventType;
    private DateTime _dateTime;
    private Address _address;

    public Event(string eventTitle, string description, string eventType, DateTime dateTime, Address address)
    {
        _eventTitle = eventTitle;
        _description = description;
        _eventType = eventType;
        _dateTime = dateTime;
        _address = address;
    }

    public string GetEventType()
    {
        return _eventType;
    }

    public string GetStandardDetails()
    {
        string date = _dateTime.ToShortDateString();
        string time = _dateTime.ToShortTimeString();

        return $"{_eventTitle} \n{_description} \nDate: {date} at {time} \nAddress: {_address.GetAddress()}";
    }

    public abstract string GetFullDetails();

    public string GetShortDescription()
    {
        string date = _dateTime.ToShortDateString();

        return $"{_eventType}: {_eventTitle} \n{date}";
    }
}