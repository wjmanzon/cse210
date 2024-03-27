using System;

public class LectureClass : Event
{
    public string Speaker { get; set; }
    public int Capacity { get; set; }

    public LectureClass(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        Speaker = speaker;
        Capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()} Speaker: {Speaker}, Capacity: {Capacity}";
    }
}
