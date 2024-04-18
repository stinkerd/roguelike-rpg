using System;
using rpg;

class SpeedControl
{
    public void TypeLineSlowly(string line)
    {
        foreach (char c in line)
        {
            Console.Write(c);
            Thread.Sleep(25); // Adjust delay as needed. lower is faster.
        }
        Console.WriteLine();
    }
    public void TypeLineFast(string line)
    {
        foreach (char c in line)
        {
            Console.Write(c);
            Thread.Sleep(1); // Adjust delay as needed. lower is faster.
        }
        Console.WriteLine();
    }
}