using System;

public class ActivitiesList
{
    private List<Activity> _activitiesList;


    public ActivitiesList()
    {
        // Create a list of dates for the activities
        List<string> datesList = new List<string>
        {
            "03 Nov 2023",
            "12 Dec 2023",
            "05 Jan 2024",
            "12 Dec 2024",
            "03 Nov 2024",
            "17 Dec 2024"
        };

        // Create a list of actvities length in minutes
        List<float> lengthsList = new List<float>
        {
            30, // Running
            45, // Running
            60, // Cycling
            25, // Cycling
            20, // Swimming
            70 // Swimming
        };

        // Create a list of distances
        List<float> distancesList = new List<float>
        {
            10, // Running
            20, // Running
            0, // Cycling
            0, // Cycling
            0, // Swimming
            0 // Swimming
        };

        // Create a list of speeds
        List<float> speedsList = new List<float>
        {
            0, // Running
            0, // Running
            30, // Cycling
            25, // Cycling
            0, // Swimming
            0 // Swimming
        };

        // Create a list laps
        List<int> lapsList = new List<int>
        {
            0, // Running
            0, // Running
            0, // Cycling
            0, // Cycling
            20, // Swimming
            25 // Swimming
        };

        // Allocate memory for the activities list
        _activitiesList = new List<Activity>();
        const int activityTypesNumber = 3;
        int runningIndex;
        int cyclingIndex;
        int swimmingIndex;

        // Loop through the number of running activities
        for (runningIndex = 0; runningIndex < datesList.Count() / activityTypesNumber; runningIndex++)
        {
            cyclingIndex = runningIndex + 2;
            swimmingIndex = cyclingIndex + 2;
            _activitiesList.Add(new Running(datesList[runningIndex], lengthsList[runningIndex],
                distancesList[runningIndex]));
            _activitiesList.Add(new Cycling(datesList[cyclingIndex], lengthsList[cyclingIndex],
            speedsList[cyclingIndex++]));
            _activitiesList.Add(new Swimming(datesList[swimmingIndex], lengthsList[swimmingIndex],
                lapsList[swimmingIndex]));
        }
    }

    // Generate Standard Details
    public string GenerateSummaryDetails()
    {
        string summaryDetails = "|| ACTIVITIES DETAILS ||\n\n";
        // Generate Standard Details
        foreach (Activity activity in _activitiesList)
        {
            // application of polymorphism
            // the activity object of the Activity parent-base class
            // behaves as an object of its children-derived classes
            summaryDetails += $"{activity.GenerateSummary()}\n";
        }
        return summaryDetails;

    }
}