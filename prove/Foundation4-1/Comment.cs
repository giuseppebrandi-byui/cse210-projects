using System;

public class Comment
{
    // Class attributes
    public string _author;
    public string _text;

    // It displays a single comment
    public void DisplayComment()
    {
        Console.WriteLine($"\n- {_text}\n- By {_author}");
    }

}

