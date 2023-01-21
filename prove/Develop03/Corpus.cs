using System;

public class Corpus
{

    // Class Attributes
    private string _fileName;
    private List<Scripture> _scriptures = new List<Scripture>();
    private Scripture _currentScripture;

    // A constructor
    public Corpus(string fileName)
    {
        _fileName = fileName;
    }

    // It returns the current scripture.
    public Scripture GetCurrentScripture()
    {
        return _currentScripture;
    }

    public void LoadCorpusFromFile()
    {
        // https://www.delftstack.com/howto/csharp/csharp-key-value-pair-list/
        _scriptures = new List<Scripture>
        {
            new Scripture("John 3:16", "God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture("Proverbs 3:5-6", "Trust in the Lord with all thine heart; and lean not unto thine own understanding.In all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture("Isaiah 26:3", "Thou wilt keep him in perfect peace, whose mind is stayed on thee: because he trusteth in thee.")
        };

    }

    // It generates a random scripture from the current book.
    public void GenerateRandomCurrentScripture()
    {
        Random randomScripture = new Random();
        int chosenScriptureIndex = randomScripture.Next(3);
        _currentScripture = _scriptures[chosenScriptureIndex];
    }
}
