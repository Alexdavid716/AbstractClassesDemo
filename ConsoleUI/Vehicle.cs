
using System;

public abstract class Vehicle
{
   
    public string Year { get; set; } = "Unknown";
    public string Make { get; set; } = "Unknown";
    public string Model { get; set; } = "Unknown";

    
    public abstract void DriveAbstract();

    
    public virtual void DriveVirtual()
    {
        Console.WriteLine($"This {Year} {Make} {Model} is being driven (virtual method).");
    }
}