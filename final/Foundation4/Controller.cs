using System;

public class Controller
{
    // Class attributes
    private ActivitiesList _activitiesList;
    private UserInterface _userInterface;

    // Constructor
    public Controller()
    {
        _activitiesList = new ActivitiesList();
        _userInterface = new UserInterface();
    }

    // Display the activities details
    public void DisplaySummaryList()
    {
        string summaryDetails = _activitiesList.GenerateSummaryDetails();
        _userInterface.DisplaySummary(summaryDetails);

    }

    // Run the program
    public void Run()
    {
        DisplaySummaryList();
    }
}