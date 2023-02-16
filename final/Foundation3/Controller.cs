using System;

public class Controller
{
    // Class attributes
    private EventsList _eventsList;
    private UserInterface _userInterface;

    // Constructor
    public Controller()
    {
        _eventsList = new EventsList();
        _userInterface = new UserInterface();
    }

    // Display the event details
    public void DisplayEventsList()
    {
        string standardDetails = _eventsList.GenerateStandardDetails();
        _userInterface.DisplayDetails(standardDetails);

        string fullDetails = _eventsList.GenerateFullDetails();
        _userInterface.DisplayDetails(fullDetails);

        string shortDetails = _eventsList.GenerateShortDetails();
        _userInterface.DisplayDetails(shortDetails);

    }

    // Run the program
    public void Run()
    {
        DisplayEventsList();
    }
}