using System;

public class ReceptionClass : Event
{
    public string RSVP_Email { get; set; }

    public ReceptionClass(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        RSVP_Email = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()} RSVP at: {RSVP_Email}";
    }
}
