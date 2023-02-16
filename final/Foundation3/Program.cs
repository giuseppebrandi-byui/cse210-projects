using System;

public class Program
{
    private Controller _controller;

    public Program()
    {
        _controller = new Controller();
    }

    static void Main(string[] args)
    {
        Program program = new Program();
        program._controller.Run();
    }

}

