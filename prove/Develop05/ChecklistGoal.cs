public class ChecklistGoal : Goal
{
    private bool _isCompleted = false;

    private int _timesToComplete; 

    private int _timesAlreadyCompleted;

    private double _bonusPoints;

    public ChecklistGoal(string title, string desc, double pointsGiven, bool isCompleted, int timesToComplete, int timesAlreadyCompleted, double bonusPoints) 
    : base(title, desc, pointsGiven)
    {
        _timesToComplete = timesToComplete;

        _timesAlreadyCompleted = timesAlreadyCompleted;

        _bonusPoints = bonusPoints;

        _isCompleted = isCompleted;
    }

    public override string DisplayProgress()
    {

        string checkbox; 

        if (_isCompleted == false)
        {
            checkbox = "[ ]";
        }

        else
        {
            checkbox = "[X]";
        }

        return $"{checkbox} {_title} ({_desc}) -- Currently Completed {_timesAlreadyCompleted}/{_timesToComplete}";
    }

    public override string GetSaveString()
    {
        return $"ChecklistGoal|{_title}|{_desc}|{_pointsGiven}|{_isCompleted}|{_timesToComplete}|{_timesAlreadyCompleted}|{_bonusPoints}";
    }

    public override double MarkComplete()
    {

        _timesAlreadyCompleted ++;

        double extraPoints = 0;

        if (_timesToComplete <= _timesAlreadyCompleted)
        {
            extraPoints = _bonusPoints;
        }


        return _pointsGiven + extraPoints;

    }





}