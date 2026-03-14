public class ExponentialGoal : Goal
{
    private double _currentPoints; 

    public ExponentialGoal(string title, string desc, double pointsGiven)
        : base(title, desc, pointsGiven)
    {
        _currentPoints = pointsGiven;
    }



    public override string DisplayProgress()
    {
        return $"[^] {GetTitle()} ({GetDesc()}) - Next completion: {_currentPoints} pts";
    }

    public override string GetSaveString()
    {
        return $"ExponentialGoal|{GetTitle()}|{GetDesc()}|{_currentPoints}";
    }

    public override double MarkComplete()
    {
        double pointsForThisEvent = _currentPoints;


        _currentPoints *= 2;

        return pointsForThisEvent;
    }
}