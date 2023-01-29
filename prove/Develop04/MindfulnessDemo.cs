using System;

class MindfulnessDemo
{
    private Controller _controller;

    public MindfulnessDemo()
    {
        _controller = new Controller();
    }
    static void Main(string[] args)
    {
        MindfulnessDemo demo = new MindfulnessDemo();
        demo._controller.Run();
    }
}