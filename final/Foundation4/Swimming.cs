public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, double length, int laps) : base(date, length)
    {
        _laps = laps;
        _activityType = "Swimming";
    }



    public override double GetDistance()
    {
        return _laps * 50.0 / 1000.0 * 0.62;

    }

    public override double GetPace()
    {
        double distance = GetDistance();
        return _length / distance;
    }

    public override double GetSpeed()
    {
        double pace = GetPace();
        return 60 / pace;


    }

}