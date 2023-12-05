using System;

class Reception : Event{
    public bool NeedRSVP;

    public Reception(string eventTitle, string description, DateTime date, TimeSpan time, string address, bool needRSVP): base(eventTitle, description, date, time, address)
    {
        NeedRSVP = needRSVP;
    }

    public override string Message()
    {
        string rsvpInfo = NeedRSVP ? "RSVP required." : "No RSVP required.";
        return $"{base.Message()}\n{rsvpInfo}";
    }
}