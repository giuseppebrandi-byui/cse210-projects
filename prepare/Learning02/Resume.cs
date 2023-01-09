// A code template for the category of things known as Person. The
// responsibility of a Resume is to keep track of the person's name and a 
// list of their jobs.
public class Resume
{
    // The C# convention is to start member variables with an underscore _
    public string _name;
    public List<Job> _jobs = new List<Job>();

    // A method that displays the resume's full details
    public void Display()
    { 
        // Display the name of the person
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Iterate through each job in the _jobs list
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}