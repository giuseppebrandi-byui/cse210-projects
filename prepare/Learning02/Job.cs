// A code template for the category of things known as Person. The
// responsibility of a Job is to keep track of the company, job title, 
// start year, and end year.
public class Job
{
     // The C# convention is to start member variables with an underscore _
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;

    // A method that displays the job's full details
    public void Display()
    { 
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}