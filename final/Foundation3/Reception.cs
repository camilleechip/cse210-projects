public class Reception : Event
{
    private string _rsvpEmail;
    private bool _rsvp;

    public Reception(string title, string description, DateTime dateTime, Address address, string rsvpEmail) 
        : base(title, description, "Reception", dateTime, address)
    {
        _rsvpEmail = "";
        _rsvp = false;
    }

    public void SetEmail(string email)
    {
        _rsvpEmail = email;
    }

    public void SetRSVP(bool status)
    {
        _rsvp = status;
    }

    public override string GetFullDetails()
    {
        string rsvpStatus = _rsvp ? "[X]" : "[ ]";
        return $"{GetStandardDetails()} \nEvent Type: {GetEventType()} \nRSVP: {rsvpStatus} {_rsvpEmail}";
    }
}