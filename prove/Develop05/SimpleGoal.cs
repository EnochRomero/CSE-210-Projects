public class SimpleGoal : Goal
{

    private bool _isCompleted = false;


    public SimpleGoal(string title, string desc, double pointsGiven, bool isCompleted) 
        : base(title, desc, pointsGiven)
    {
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

        return $"{checkbox} {_title} ({_desc})";
    }

    public override string GetSaveString()
    {
        return $"SimpleGoal|{_title}|{_desc}|{_pointsGiven}|{_isCompleted}";
    }

    public override double MarkComplete()
    {
        _isCompleted = true;

        return _pointsGiven;

    }




}