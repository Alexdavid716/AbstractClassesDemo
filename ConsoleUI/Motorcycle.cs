
using System;

public class Motorcycle : Vehicle
{
    
    public bool HasSideCart { get; set; }

   
    public Motorcycle()
    {
       
        Make = "GenericMotorcycle";
        Model = "GenericModel";
    }

    
    public override void DriveAbstract()
    {
        Console.WriteLine($"This {Year} {Make} {Model} is being ridden (abstract method).");
    }

    
    public override void DriveVirtual()
    {
        Console.WriteLine($"This {Year} {Make} {Model} is being ridden (overridden virtual method).");
    }
}