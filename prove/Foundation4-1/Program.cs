using System;

class Program
{
    static void Main(string[] args)
    {
        // Videos list
        List<Video> videosList = new List<Video>();

        // Create an instance of the class Video and assign it to the video1 variable
        Video video1 = new Video();
        // Assign to the _title attribute the title of the video
        video1._title = "Getting the user's location with JavaScript";
        // Assign to the _author attribute a name
        video1._author = "Jonah Lawrence";
        // Assign to the _length attribute the number of seconds for the video
        video1._length = 548;
        // Create an instance of the class Comment and assign it to the Comment1Video1 variable
        Comment comment1Video1 = new Comment();
        // Assign to the _text attribute a comment for video1
        comment1Video1._text = "Well structured tutorial. I liked the way you explained the logic behind the project.";
        // Assign to the _author attribute a name
        comment1Video1._author = "Giuseppe Brandi";
        // Create an instance of the class Comment and assign it to the Comment2Video1 variable
        Comment comment2Video1 = new Comment();
        // Assign to the _text attribute a comment for video1
        comment2Video1._text = "Hands down to the best tutorial channel.";
        // Assign to the _author attribute a name
        comment2Video1._author = "Nick Lewis";
        // Create an instance of the class Comment and assign it to the Comment3Video1 variable
        Comment comment3Video1 = new Comment();
        // Assign to the _text attribute a comment for video1
        comment3Video1._text = "Bravo!";
        // Assign to the _author attribute a name
        comment3Video1._author = "Jack Ricker";

        // Create an instance of the class Video and assign it to the video2 variable
        Video video2 = new Video();
        video2._title = "Create a Weather App Using JavaScript, HTML and CSS";
        video2._author = "Code Explained";
        video2._length = 2274;
        Comment comment1Video2 = new Comment();
        comment1Video2._text = "Superb programming skills";
        comment1Video2._author = "Laura Holt";
        Comment comment2Video2 = new Comment();
        comment2Video2._text = "I loved the way you explained the design concepts";
        comment2Video2._author = "John Doe";
        Comment comment3Video2 = new Comment();
        comment3Video2._text = "Can you make an app about searching best restaurants in town?";
        comment3Video2._author = "Xing Chen";

        // Create an instance of the class Video and assign it to the video3 variable
        Video video3 = new Video();
        video3._title = "Build and Deploy 5 JavaScript & React API Projects in 10 Hours";
        video3._author = "JavaScript Mastery";
        video3._length = 35454;
        Comment comment1Video3 = new Comment();
        comment1Video3._text = "That's some insane amount of work put in Adrian! The efforts put in editing along with the time put in to make these projects!";
        comment1Video3._author = "Rivaan Singh";
        Comment comment2Video3 = new Comment();
        comment2Video3._text = "This is unreal. I can only imagine the amount of hours you poured into created these projects. Thank you so much.";
        comment2Video3._author = "Peter Smith";
        Comment comment3Video3 = new Comment();
        comment3Video3._text = "Fantastic course. I am eternally grateful to you, Adrian, for your work. It pumped me a lot as a front-end developer!";
        comment3Video3._author = "Angela Colt";
        Comment comment4Video3 = new Comment();
        comment4Video3._text = "You are a gem of a human Adrian! Your selflessness in putting all these detailed courses for free on YT is admirable and commendable! I'll always be indebted!";
        comment4Video3._author = "Jessica Reese";

        // Add to the comment list for video1 all comments associated with that video
        video1._commentsList.Add(comment1Video1);
        video1._commentsList.Add(comment2Video1);
        video1._commentsList.Add(comment3Video1);
        // Add to the comment list for video2 all comments associated with that video
        video2._commentsList.Add(comment1Video2);
        video2._commentsList.Add(comment2Video2);
        video2._commentsList.Add(comment3Video2);
        // Add to the comment list for video3 all comments associated with that video
        video3._commentsList.Add(comment1Video3);
        video3._commentsList.Add(comment2Video3);
        video3._commentsList.Add(comment3Video3);
        video3._commentsList.Add(comment4Video3);

        // Add to the videosList each video
        videosList.Add(video1);
        videosList.Add(video2);
        videosList.Add(video3);

        // Use a loop to iterate through the videos in the videos list and use the methods associated with displaying the video details and comments
        foreach (Video video in videosList)
        {
            video.DisplayDetails();
            video.DisplayComments();
        }

    }
}

