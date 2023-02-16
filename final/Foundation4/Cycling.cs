using System;

public class Cycling : Activity
{
    // Class attributes
    private float _speed;

    // Constructor
    public Cycling(string date, float length, float speed) : base(date, length)
    {
        _speed = speed;
    }

    // Compute Distance in km
    public override float CalculateDistance()
    {
        return _speed * _length / 60;
    }

    // Compute pace in minutes per kilometer
    public override float CalculatePace()
    {
        return _length / CalculateDistance();
    }

    // Generate Summary
    public override string GenerateSummary()
    {
        string summary = $"{_date} Cycling ({_length} min): "
            + $"Distance {String.Format("{0:0.0}", CalculateDistance())} km, "
            + $"Speed: {_speed} kph, Pace: {String.Format("{0:0.0}", CalculatePace())} min per km";
        return summary;
    }
}