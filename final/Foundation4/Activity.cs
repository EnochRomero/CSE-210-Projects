
public abstract class Activity
{
    protected string _date;
    protected double _length;
    protected string _activityType;

    public Activity(string date, double length)
    {
        _date = date;

        _length = length;
    }

    public abstract double GetDistance();

    public abstract double GetPace();

    public abstract double GetSpeed();

    public void DisplaySummary()
    {
        Console.WriteLine($"{_activityType}: {_date} ({Math.Round(_length, 2)} mins): Distance {Math.Round(GetDistance(), 2)} miles, Speed {Math.Round(GetSpeed(), 2)} mph, Pace: {Math.Round(GetPace(), 2)} min per mile");
    }


    
}