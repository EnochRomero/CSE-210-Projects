
public class EternalGoal : Goal
{

    private int _timesCompleted = 0;

    public EternalGoal(string title, string desc, double pointsGiven) 
    : base(title, desc, pointsGiven)
    {
    }

    public void IncreaseTimesCompleted()
    {
        _timesCompleted += 1;
    }

    public override string DisplayProgress()
    {
        return $"[∞] {_title} ({_desc})";
    }

    public override string GetSaveString()
    {
        return $"EternalGoal|{_title}|{_desc}|{_pointsGiven}";
    }


    public override double MarkComplete()
    {
        return _pointsGiven;
    }
    
}