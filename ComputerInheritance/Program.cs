using System;
using ComputerInheritance;

class Program
{
    static void Main(string[] args)
    {
        PersonalComputer myPC = new PersonalComputer("Dell XPS 15", "Intel Core i7");
        Console.WriteLine("Computer Type: " + myPC.getComputerType());
        Console.WriteLine("Model: " + myPC.getModel());
        Console.WriteLine("CPU: " + myPC.getComputerCPU());
        Console.WriteLine("Is Turned On: " + myPC.isComputerStatus());
        myPC.SwitchComputerStatus();
        Console.WriteLine("Is Turned On after switching: " + myPC.isComputerStatus());
    }
}
