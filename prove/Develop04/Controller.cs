using System;

public class Controller
{
    private Breathing _breathing;
    private Reflection _reflection;
    private Listing _listing;
    private UserInterface _userInterface;
    public Controller()
    {
        _breathing = new Breathing();
        _reflection = new Reflection();
        _listing = new Listing();
        _userInterface = new UserInterface();
    }

    public void Run()
    {
        _reflection.GenerateRandomPrompt();
        _reflection.GenerateRandomQuestion();
        _userInterface.ChooseMenuOption(
            _breathing.GetName(),
            _breathing.GetStartMessage(),
            _reflection.GetName(),
            _reflection.GetStartMessage(),
            _reflection.GetPrompt(),
            _reflection.GetQuestion(),
            _listing.GetName(),
            _listing.GetStartMessage(),
            _listing.GetPrompt()
        );
    }

}