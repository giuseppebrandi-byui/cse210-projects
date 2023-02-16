using System;

public class Swimming : Activity
{
    // Class attributes
    private int _laps;

    // Construct
    public Swimming(string date, float length, int laps) : base(date, length)
    {
        _laps = laps;
    }

    // Compute Distance in km
    public override float CalculateDistance()
    {
        return _laps * 50f / 1000; // kilometer
    }

    // Compute the speed in kilometers per hour
    public override float CalculateSpeed()
    {
        return CalculateDistance() / _length * 60;
    }

    // Compute pace in minutes per kilometer
    public override float CalculatePace()
    {
        return _length / CalculateDistance();
    }

    // Generate Summary
    public override string GenerateSummary()
    {
        string summary = $"{_date} Swimming ({_length} min): "
            + $"Distance: {String.Format("{0:0.0}", CalculateDistance())} km, "
            + $"Speed: {String.Format("{0:0.0}", CalculateSpeed())} kph, "
            + $"Pace: {String.Format("{0:0.0}", CalculatePace())} min per km";
        return summary;
    }
}