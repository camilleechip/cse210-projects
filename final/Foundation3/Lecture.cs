using System.Net.Sockets;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, DateTime dateTime, Address address, string speaker, int capacity) 
        : base(title, description, "Lecture", dateTime, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()} \nEvent Type: {GetEventType()} \nSpeaker: {_speaker} \nCapacity: {_capacity}";
    }
}