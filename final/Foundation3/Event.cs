
public abstract class Event 
{

    protected string _title;

    protected string _eventType;

    protected string _desc;

    protected string _date;

    protected string _time;

    protected Address _address;

    public Event (string eventType)
    {
        _eventType = eventType;
    }

    public Event(string title, string desc, string date, string time, Address address)
    {
        _title = title;

        _desc = desc;

        _date = date;

        _time = time;

        _address = address;
    }

    public void DisplayStandard()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_desc}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address}");
        Console.WriteLine();
        Console.WriteLine("========================================");
    }
    public void DisplayShort()
    {
        Console.WriteLine($"Event Type: {_eventType}");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine();
        Console.WriteLine("========================================");
    }

    public abstract void DisplayFull();
    
}