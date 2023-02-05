using System;

public class Checklist : Goal
{

    // Attributes of the class
    protected int _numberOfTimes = 0;
    protected int _bonusPoints = 0;
    // Contructor
    public Checklist()
    {
    }

    // public override void ReadDetails()
    // {
    //     this.ReadDetails();
    //     Console.Write("How many times this goal need to be accomplished for a bonus?");
    //     _numberOfTimes = int.Parse(Console.ReadLine());
    //     Console.Write("What is the bonus for accomplishing it that many times?");
    //     _bonusPoints = int.Parse(Console.ReadLine());
    // }
}