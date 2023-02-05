using System;

class Program
{
    private Controller _controller;

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