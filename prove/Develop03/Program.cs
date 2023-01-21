using System;

class Program
{
    // Creating a new instance of the Corpus class and assigning it to 
    // the _corpus variable.
    private Corpus _corpus = new Corpus("Corpus.cs");

    // Creating a new instance of the UserInterface class and assigning it to 
    // the _userInterface variable.
    private UserInterface _userInterface = new UserInterface();

    static void Main(string[] args)
    {
        Corpus corpus = new Corpus("test_corpus.txt");
        Scripture currentScripture;
        UserInterface userInterface = new UserInterface();
        string response;

        corpus.LoadCorpusFromFile();
        corpus.GenerateRandomCurrentScripture();
        currentScripture = corpus.GetCurrentScripture();
        userInterface.DisplayCurrentScripture(currentScripture);
        response = userInterface.GetUserResponse();

        // while (response != "quit" && currentScripture.GetWordAppearances(pair => pair.value)
        while (response != "quit")
        {
            currentScripture = corpus.GetCurrentScripture();
            currentScripture.UpdateVisibility();
            userInterface.DisplayCurrentScripture(currentScripture);
            response = userInterface.GetUserResponse();
        }

        Console.WriteLine("Thank you for using the Scriptures Memorizer");
    }
}