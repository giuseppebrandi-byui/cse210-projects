using System;

class Program
{
    // Class attributes
    private Controller _controller;

    // Controller
    public Program()
    {
        _controller = new Controller();
    }
    static void Main(string[] args)
    {
        Program demo = new Program();
        demo._controller.Run();
    }
}