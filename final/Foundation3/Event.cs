using System;

class Event
{
    public string EventTitle;
    public string Description;
    public DateTime Date;
    public TimeSpan Time;
    public string Address;

    public Event(string eventTitle, string description, DateTime date, TimeSpan time, string address)
    {
        EventTitle = eventTitle;
        Description = description;
        Date = date;
        Time = time;
        Address = address;
    }

    public virtual string Message()
    {
        return $"Join us for {EventTitle} on {Date.ToShortDateString()} at {Time}.\n{Description}\nAddress: {Address}";
    }
}