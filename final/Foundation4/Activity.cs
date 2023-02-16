using System;

public abstract class Activity
{
    // Class attributes
    protected string _date;
    protected float _length;

    // Constructor
    public Activity(string date, float length)
    {
        _date = date;
        _length = length; // minutes
    }

    // The getter returns the date of the activity
    public string GetDate()
    {
        return _date;
    }

    // The setter sets the date of the activity
    public void SetDate(string date)
    {
        _date = date;
    }

    // The getter returns the length of the activity
    public float GetLength()
    {
        return _length;
    }

    //The setter sets the length of the activities
    public void SetLength(float length)
    {
        _length = length;
    }

    public virtual float CalculateDistance()
    {
        return 0f;
    }

    public virtual float CalculateSpeed()
    {
        return 0f;
    }

    public abstract float CalculatePace();

    public abstract string GenerateSummary();

}