using System;

public class Running : Activity
{
    // Class attributes
    private float _distance;

    // Constructor
    public Running(string date, float length, float distance) : base(date, length)
    {
        _distance = distance;
    }

    // Compute the speed in kilometers per hour
    public override float CalculateSpeed()
    {
        return _distance / _length * 60;
    }

    // Compute the pace in minutes per kilometer
    public override float CalculatePace()
    {
        return _length / _distance;
    }

    // Generate Summary
    public override string GenerateSummary()
    {
        string summary = $"{_date} Running ({_length} min): Distance {_distance} km, "
        + $"Speed: {String.Format("{0:0.0}", CalculateSpeed())} kph, "
        + $"Pace: {String.Format("{0:0.0}", CalculatePace())} min per km";
        return summary;
    }
}