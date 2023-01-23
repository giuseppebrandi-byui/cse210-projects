using System;

public class Scripture
{

    // Class Attributes
    private string _reference;
    private string _text;
    private List<KeyValuePair<string, bool>> _wordAppearances = new List<KeyValuePair<string, bool>>();

    /* A constructor. */
    public Scripture(string reference, string text)
    {
        _reference = reference;
        _text = text;
        string[] wordList = text.Split(" ");

        /* Iterating through the array of words and adding each word to the list
        of words. */
        foreach (string word in wordList)
        {
            _wordAppearances.Add(new KeyValuePair<string, bool>(word, true));
        }
    }

    // It returns a string.
    public string GetReference()
    {
        return _reference;
    }

    // It sets the reference of the object.
    // <param name="reference">The reference to the object you want to set.
    public void SetReference(string reference)
    {
        _reference = reference;
    }

    // The getter returns a string.
    public string GetText()
    {
        return _text;
    }

    // It sets the text of the textbox to the text passed in.
    // <param name="text">The text to display.
    public void SetText(string text)
    {
        _text = text;
    }

    /// It returns a list of key-value pairs, where the key is a string and the
    /// value is a boolean.
    public List<KeyValuePair<string, bool>> GetWordAppearances()
    {
        return _wordAppearances;
    }

    public void UpdateVisibility()
    {
        const int hiddenWords = 3;
        Random randomWord = new Random();
        List<int> _wordIndicesToRemoveList = new List<int>();

        List<KeyValuePair<string, bool>> updatedWordAppearances = _wordAppearances;
        /* Looping through the list of words and checking if the word is in the
        list of words that are hidden. */
        int hiddenWordsCounter = 0;

        // stop when you find 3 visible words to hide or when there are no nore words in the scripture
        for (int i = 0; hiddenWordsCounter < hiddenWords && i < updatedWordAppearances.Count; i++)
        {
            int chosenWordIndex = randomWord.Next(_wordAppearances.Count);

            // check if word is visible
            if (updatedWordAppearances[chosenWordIndex].Value)
            {
                // if yes make it hidden and update the hidden words counter
                updatedWordAppearances[chosenWordIndex] = new KeyValuePair<string, bool>(updatedWordAppearances[chosenWordIndex].Key, false);
                hiddenWordsCounter++;
            }
        }
        _wordAppearances = updatedWordAppearances;
    }

    public bool hasWordsLeft()
    {
        bool wordsLeft = false;

        foreach (KeyValuePair<string, bool> word in _wordAppearances)
        {
            if (word.Value)
            {
                wordsLeft = true;
                break;
            }
        }

        return wordsLeft;
    }
}