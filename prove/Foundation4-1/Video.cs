using System;

public class Video
{
    // Class attributes
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _commentsList = new List<Comment>();

    // It displays the video details
    public void DisplayDetails()
    {
        Console.WriteLine($"\n> VIDEO DETAILS\n- Title: {_title}\n- Author: {_author}\n- Length: {_length} seconds\n- Number of Comments: {ComputeNumberOfComments()}");
    }

    // It displays all comments
    public void DisplayComments()
    {
        Console.Write("\n>> COMMENTS");

        foreach (Comment comment in _commentsList)
        {
            comment.DisplayComment();
        }
    }

    // It computes the number of comments for a video
    public int ComputeNumberOfComments()
    {
        return _commentsList.Count();
    }

}