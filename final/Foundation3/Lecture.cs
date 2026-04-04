
public class Lecture : Event
{
    private string _speaker;

    private int _capacity;

        public Lecture(string title, string desc, string date, string time, Address address,
                   string speaker, int capacity)
        : base(title, desc, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
        _eventType = "Lecture";
    }


    public override void DisplayFull()
    {
        Console.WriteLine($"Event Type: {_eventType}");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Description: {_desc}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address}");
        Console.WriteLine($"Capacity: {_capacity}");
        Console.WriteLine();
        Console.WriteLine("========================================");
    }



}