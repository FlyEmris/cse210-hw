using System;

class Lecture : Event
{
    public string Speaker;
    public int Capacity;

    public Lecture(string eventTitle, string description, DateTime date, TimeSpan time, string address, string speaker, int capacity) : base(eventTitle, description, date, time, address)
    {
        Speaker = speaker;
        Capacity = capacity;
    }

    public override string Message()
    {
        return $"{base.Message()}\nSpeaker: {Speaker}\nCapacity: {Capacity} seats available.";
    }
}