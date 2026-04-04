public class Reception : Event
{
    private string _RSVPemail;



    public Reception(string title, string desc, string date, string time, Address address,
                     string rsvpEmail)
        : base(title, desc, date, time, address)
    {
        _RSVPemail = rsvpEmail;
        _eventType = "Reception";
    }

    public override void DisplayFull()
    {
        Console.WriteLine($"Event Type: {_eventType}");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_desc}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address}");
        Console.WriteLine($"RSVP Email: {_RSVPemail}");
        Console.WriteLine();
        Console.WriteLine("========================================");
    }



}