

using System.ComponentModel;
using System.Reflection;

public abstract class Goal
 {
    protected string _title;

    protected string _desc;

    protected double _pointsGiven;


    public Goal(string title, string desc, double pointsGiven)
    {
        _title = title;

        _desc = desc;

        _pointsGiven = pointsGiven;
    }


    public string GetTitle()
    {
        return _title;
    }

    public string GetDesc()
    {
        return _desc;
    }


    public abstract string DisplayProgress();

    public abstract string GetSaveString();

    public abstract double MarkComplete();


}