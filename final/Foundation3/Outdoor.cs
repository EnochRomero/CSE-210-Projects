public class Outdoor : Event
{
    private string _weather;


    public Outdoor(string title, string desc, string date, string time, Address address,
                   string weather)
        : base(title, desc, date, time, address)
    {
        _weather = weather;
        _eventType = "Outdoor";
    }
    
    public override void DisplayFull()
    {
        Console.WriteLine($"Event Type: {_eventType}");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_desc}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address}");
        Console.WriteLine($"Weather Email: {_weather}");
        Console.WriteLine();
        Console.WriteLine("========================================");
    }

}